using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public record Dog : AuditableEntity
    {
        public Guid id { get; init; }
        public string name { get; init; }
        public string race { get; init; }
        public int age { get; init; }
        public string gender { get; init; }
    }
}
