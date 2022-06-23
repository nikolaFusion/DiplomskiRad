using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Utils.Interfaces;

namespace Models
{
    public class Role : IRole
    {
        [Key]
        public int RoleID { get; set; }
        [Required]
        public string Name { get; set; }
        [NotMapped]
        public List<UserRole> UserRoles { get; set; }
        [NotMapped]
        public List<RolePermission> RolePermissions { get; set; }

    }
}