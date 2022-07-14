using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Utils.Models
{
    public class TokenModel : ITokenModel
    {
        public string JWTToken { get; set; }
    }
}
