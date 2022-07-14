using AutoMapper;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services
{
    public class ServicesAutoMapperProfile:Profile
    {
        public ServicesAutoMapperProfile()
        {
            CreateMap<IArrangement, Arrangement>();
        }
    }
}
