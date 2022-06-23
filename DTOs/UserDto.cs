using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class UserDto : IUser
    {
        public int UserID {get; set;}

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public int Age { get; set; }

        public Education Education { get; set; }

        public UserDto(LoginDto user)
        {
            Username = user.Username;
            Password = user.Password;
        }

        public UserDto(RegostrationDto user)
        {
            Username = user.Username;
            Password = user.Password;
            LastName = user.LastName;
            FirstName = user.FirstName;
            Age = user.Age;
        }
    }
}
