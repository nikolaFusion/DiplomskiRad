using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Models
{
    public class JwtTokenModel : ITokenModel
    {
        public string JWTToken { get; set; }
    }
}
