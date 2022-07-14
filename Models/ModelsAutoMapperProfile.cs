using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models
{
    public class ModelsAutoMapperProfile:Profile
    {
        public ModelsAutoMapperProfile()
        {
            CreateMap<IUser, User>();
            CreateMap<IUserRole, UserRole>();
            CreateMap<IArrangementGroup, ArrangementGroup>();
        }
    }
}
