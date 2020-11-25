using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lenta.Shared.Filters
{
    public class PaginationFilter
    {
        public int PageNumber { get; set; } = 1;
        public int PageSize { get; set; } = 10;

        public PaginationFilter()
        {
        }

        public PaginationFilter(int pageNumber, int pageSize)
        {
            PageNumber = pageNumber < PageNumber ? PageNumber : pageNumber;
            PageSize = pageSize > PageSize ? PageSize : pageSize;
        }
    }
}
