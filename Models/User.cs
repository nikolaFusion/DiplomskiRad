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
        [Required]
        public Education Education { get; set; }
        [NotMapped]
        public List<UserRole> UserRoles { get; set; }

        public User()
        {
        }

        public User(IUser user)
        {
            UserID=user.UserID;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Password = user.Password;
            Age = user.Age;
            Education = user.Education;
        }

    }
}
