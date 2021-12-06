using Web.Models;

namespace Web.FilterModel
{
    public class Filter:PaginationFilter
    {
        public string search_key { get; set; }
    }
}
