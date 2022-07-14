using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class AutoMapperDto : Profile
    {
        public AutoMapperDto()
        {
            CreateMap<IUser, UserDto>();
        }

    }
}
