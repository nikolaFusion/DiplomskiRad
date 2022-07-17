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
    public class User : IUser
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Username { get; set; } 
        [Required]
        public string Password { get; set; }
        [Required]
        public int Age { get; set; }
        [NotMapped]
        public List<UserRole> UserRoles { get; set; }
        [NotMapped]
        public List<UserArrangementGroup> UserArrangements { get; set; }

        public User()
        {
        }


    }
}
