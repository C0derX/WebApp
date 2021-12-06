using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Linq;

namespace Core.Common.Extensions
{
    public static class Downloader
    {
        public static MemoryStream download(this DataTable dt, string worksheet_name)
        {
            MemoryStream memStream;

            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add(worksheet_name);

                string[] columnNames = (from dc in dt.Columns.Cast<DataColumn>()
                                        select dc.ColumnName).ToArray();

                addColumnsToWorksheet(worksheet, columnNames);


                int rowStartIndex = 2;
                int columnIndex = 1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    for (int j = 0; j < dt.Columns.Count; j++)
                    {
                        worksheet.Cells[rowStartIndex, columnIndex].Value = dt.Rows[rowStartIndex - 2][columnIndex - 1].ToString();
                        columnIndex++;
                    }
                    rowStartIndex++;
                    columnIndex = 1;
                }

                memStream = new MemoryStream(package.GetAsByteArray());
            }

            return memStream;

        }

        private static void addColumnsToWorksheet(ExcelWorksheet worksheet, string[] columnNames)
        {
            int rowIndexForColumns = 1;
            int columnIndexForColumns = 1;
            foreach (var columnName in columnNames)
            {
                worksheet.Cells[rowIndexForColumns, columnIndexForColumns].Value = columnName;
                columnIndexForColumns++;
            }
        }
    }
}
