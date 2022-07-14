using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models
{
    public class UserRole : IUserRole
    {
        [Key]
        public int UserID { get; set; }
        [Key]
        public int RoleID {get; set; }
        [NotMapped]
        public User User { get; set; }
        [NotMapped]
        public Role Role { get; set; }

        public UserRole()
        {

        }

    }
}
