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
    public class RolePermission : IRolePermission
    {
        [Key]
        public int RoleID { get; set; }
        [Key]
        public int PermissionID { get; set; }
        [NotMapped]
        public Role Role { get; set; }
        [NotMapped]
        public Permission Permission { get; set; }
    }
}
