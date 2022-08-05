using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Helpers;

namespace WebAPI.Filters
{
    public class SortingFilter
    {
        public string sortField { get; set; }
        public bool ascending { get; set; } = true;
        public SortingFilter()
        {
            sortField = "id";
        }
        public SortingFilter(string _sortField, bool _ascending)
        {
            var sortFields = SortingHelper.GetSortFields();

            _sortField = _sortField.ToLower();

            if (sortFields.Select(x => x.Key).Contains(_sortField.ToLower()))
                _sortField = sortFields.Where(x => x.Key == _sortField).Select(x => x.Value).SingleOrDefault();
            else
                _sortField = "id";

            sortField = _sortField;
            ascending = _ascending;
        }
    }
}
