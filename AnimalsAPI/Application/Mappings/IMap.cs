using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappings
{
    //interface used for configuration of automapper
    public interface IMap
    {
        void Mapping(Profile profile);
    }
}
