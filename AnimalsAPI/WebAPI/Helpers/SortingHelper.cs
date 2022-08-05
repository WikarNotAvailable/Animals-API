using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Helpers
{
    public class SortingHelper
    {
        public static KeyValuePair<string, string>[] GetSortFields()
        {
            return new[] { SortFields.name, SortFields.creationDate };
        }
    }
    public class SortFields
    {
        public static KeyValuePair<string, string> name { get; } = new KeyValuePair<string, string>("name", "name");
        public static KeyValuePair<string, string> creationDate { get; } = new KeyValuePair<string, string>("creationdate", "created");

    }
}
