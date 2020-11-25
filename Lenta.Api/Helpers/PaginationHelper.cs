using Lenta.Shared.Filters;
using Lenta.Shared.Wrappers;
using System;
using System.Collections.Generic;
using Lenta.Shared.Extensions;

namespace Lenta.Api.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<List<T>> CreatePagedResponse<T>(List<T> data, PaginationFilter pageFilter, int totalRecords, string url)
        {
            var response = new PagedResponse<List<T>>(data, pageFilter);
            int totalPages = Convert.ToInt32(totalRecords / (double)pageFilter.PageSize);
            response.TotalRecords = totalRecords;
            response.TotalPages = totalPages;
            int pageNumber = pageFilter.PageNumber;
            response.NextPage = pageNumber >= 1 && pageNumber < totalPages
                ? new UriBuilder(url).UpdateQuery("page", (pageNumber + 1).ToString()).ToString()
                : null;
            response.PreviousPage = pageNumber - 1 >= 1 && pageNumber <= totalPages
                ? new UriBuilder(url).UpdateQuery("page", (pageNumber - 1).ToString()).ToString()
                : null;

            return response;
        }
    }
}
