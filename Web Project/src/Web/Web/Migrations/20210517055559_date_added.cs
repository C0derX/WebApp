using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Web.Migrations
{
    public partial class date_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "seminar",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 404, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5844));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5847));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5851));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5855));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5862));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5962));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5970));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5974));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5977));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5981));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5984));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5988));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6007));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6028));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6031));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6039));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6068));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6071));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6078));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6083));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6087));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6091));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6095));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6098));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6156));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6233));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6240));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6243));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6281));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6285));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6418));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6426));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6443));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6455));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6458));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6479));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6488));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6496));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6499));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6502));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6528));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6531));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6539));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6609));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6612));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6616));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6622));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6635));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6638));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6645));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6648));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6655));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6660));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6667));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6670));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6673));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6677));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6680));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 155L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 156L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 157L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 158L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 159L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6708));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 160L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 405, DateTimeKind.Local).AddTicks(9688));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(606));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(633));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(637));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(666));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(670));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(674));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(692));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(696));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(700));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(745));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(833));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(837));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(849));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(862));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(866));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(873));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(877));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(881));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(885));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(899));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(903));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(911));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(915));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(930));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(938));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(942));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(949));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(953));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(963));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(967));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(974));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(978));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(981));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(985));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1007));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1015));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1018));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1077));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1092));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1096));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1250));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1265));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1272));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1276));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1296));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1306));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1313));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1350));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1357));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1365));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1368));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1372));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 406, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 397, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 399, DateTimeKind.Local).AddTicks(5905));

            migrationBuilder.UpdateData(
                table: "organization",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 401, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "organization_module_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "role_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(6693));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 402, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "user_role_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 17, 11, 40, 57, 404, DateTimeKind.Local).AddTicks(2327));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "seminar");

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8021));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8074));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8078));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8087));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8107));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8135));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8139));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8145));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8152));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8166));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8170));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8173));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8176));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8186));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8189));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8235));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8248));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8253));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8257));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8260));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8264));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8267));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8271));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8277));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8281));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8288));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8292));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8296));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8310));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8313));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8345));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8354));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8370));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8376));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8392));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8396));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8417));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8433));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8436));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8440));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8443));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8446));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8450));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8492));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8502));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8514));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8531));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8539));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8542));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8555));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8569));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8573));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8586));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 155L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 156L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 157L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 158L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 159L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "menu",
                keyColumn: "Id",
                keyValue: 160L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 657, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 3L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 4L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 5L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 6L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2226));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 7L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 8L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 9L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 10L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 11L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2245));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 12L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2249));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 13L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 14L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 15L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 16L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 17L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 18L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2272));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 19L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2276));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 20L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 21L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 22L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2288));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 23L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 24L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 25L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 26L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 27L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 28L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2310));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 29L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2314));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 30L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 31L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2321));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 32L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 33L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 34L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 35L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 36L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 37L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 38L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 39L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 40L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2355));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 41L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 42L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 43L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 44L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2370));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 45L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 46L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 47L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2395));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 48L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2398));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 49L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 50L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 51L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 52L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 53L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 54L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 55L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2425));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 56L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 57L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 58L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 59L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 60L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 61L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2448));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 62L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 63L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 64L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 65L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 66L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 67L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 68L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 69L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 70L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2481));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 71L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2485));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 72L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 73L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 74L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 75L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 76L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 77L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 78L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 79L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 80L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 81L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 82L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 83L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 84L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 85L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 86L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 87L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 88L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 89L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 90L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 91L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 92L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2563));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 93L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 94L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 95L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 96L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 97L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 98L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 99L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 100L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 101L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 102L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2605));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 103L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2608));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 104L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2612));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 105L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 106L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 107L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 108L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 109L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 110L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 111L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 112L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 113L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 114L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 115L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2653));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 116L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 117L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 118L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 119L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 120L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 121L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2676));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 122L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 123L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 124L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 125L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 126L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 127L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 128L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 129L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 130L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 131L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 132L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 133L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 134L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 135L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 136L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2739));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 137L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 138L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 139L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 140L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 141L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 142L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 143L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 144L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 145L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 146L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2776));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 147L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2779));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 148L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 149L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 150L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 151L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 152L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2798));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 153L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2801));

            migrationBuilder.UpdateData(
                table: "menu_permission_map",
                keyColumn: "Id",
                keyValue: 154L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 658, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 650, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "module",
                keyColumn: "Id",
                keyValue: 2L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 652, DateTimeKind.Local).AddTicks(1679));

            migrationBuilder.UpdateData(
                table: "organization",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 654, DateTimeKind.Local).AddTicks(3546));

            migrationBuilder.UpdateData(
                table: "organization_module_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 654, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "role_permission_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "user",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(5537));

            migrationBuilder.UpdateData(
                table: "user_role",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 655, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "user_role_map",
                keyColumn: "Id",
                keyValue: 1L,
                column: "created_date",
                value: new DateTime(2021, 5, 16, 13, 59, 34, 656, DateTimeKind.Local).AddTicks(7494));
        }
    }
}
