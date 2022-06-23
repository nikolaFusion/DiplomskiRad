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
    public class Permission : IPermission
    {
        [Key]
        public int PermissionID { get; set; }
        [Required]
        public string NamePermission { get; set; }
        [NotMapped]
        public List<RolePermission> RolePermissions { get; set; }
    }
}
