using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class UserRole : IUserRole
    {
        public int UserID { get; set; }

        public int RoleID { get; set; }
    }
}
