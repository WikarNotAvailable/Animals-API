using Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    [Table("Animals")]
    public record Animal : AuditableEntity
    {
        [Key]
        public Guid id { get; init; }
        [Required]
        [MaxLength(30)]
        public string specie { get; init; }
        [Required]
        [MaxLength(30)]
        public string name { get; init; }
        [Required]
        [MaxLength(20)]
        public string race { get; init; }
        [Required]
        public int age { get; init; }
        [Required]
        [MaxLength(10)]
        public string gender { get; init; }
        public Animal () { }

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
