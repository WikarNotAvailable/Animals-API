using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class UpdateAnimalDto
    {
        public string specie { get; init; }
        public string name { get; init; }
        public string race { get; init; }
        public int age { get; init; }
        public string gender { get; init; }
    }
}
