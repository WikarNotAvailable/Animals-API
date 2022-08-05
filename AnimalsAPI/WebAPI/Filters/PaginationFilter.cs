using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Filters
{
    // filter used for pagination
    public class PaginationFilter
    {
        private const int maxPageSize = 20;
        public int pageNumber { get; set; }
        public int pageSize { get; set; }

        public PaginationFilter()
        {
            pageNumber = 1;
            pageSize = maxPageSize;
        }

        public PaginationFilter(int _pageNumber, int _pageSize)
        {
            pageNumber = _pageNumber < 1 ? 1 : _pageNumber;
            pageSize = _pageSize > maxPageSize ? maxPageSize : _pageSize;
        }

    }
}
