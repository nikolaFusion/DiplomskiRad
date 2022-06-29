using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utils.Interfaces
{
    public interface IUser
    {
        public int UserID { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Username { get; }
        public string Password { get; }
        public int Age { get; }

    }
}
