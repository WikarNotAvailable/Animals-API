using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common
{
    public abstract record AuditableEntity
    {
        public DateTime created { get; init; }
        public string createdBy { get; init; }
        public DateTime? lastModified { get; init; }
        public string lastModifiedBy { get; init; }
    }
}
