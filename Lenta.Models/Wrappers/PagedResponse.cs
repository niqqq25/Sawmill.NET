using Lenta.Shared.Filters;

namespace Lenta.Shared.Wrappers
{
    public class PagedResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public string NextPage { get; set; }
        public string PreviousPage { get; set; }

        public PagedResponse()
        {

        }

        public PagedResponse(T data, PaginationFilter pageFilter)
        {
            Data = data;
            PageNumber = pageFilter.PageNumber;
            PageSize = pageFilter.PageSize;

        }
    }
}
