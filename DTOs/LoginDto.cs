using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace DTOs
{
    public class LoginDto
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public LoginDto()
        {

        }

        public LoginDto(IUser user)
        {
            Username = user.Username;
            Password = user.Password;
        }
    }
}
