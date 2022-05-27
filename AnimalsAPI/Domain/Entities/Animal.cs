using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public record Animal : AuditableEntity
    {
        public Guid id { get; init; }
        public string specie { get; init; }
        public string name { get; init; }
        public string race { get; init; }
        public int age { get; init; }
        public string gender { get; init; }

        public Animal (string _specie, string _name, string _race, int _age, string _gender)
        {
            id = Guid.NewGuid();
            specie = _specie;
            name = _name;
            race = _race;
            age = _age;
            gender = _gender;
        }
    }
}
