using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Utils.Models
{
    public class UtilsMapperProfile : Profile
    {
        public UtilsMapperProfile()
        {
            CreateMap<IUser, User>();
        }
    }
}

