using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Models
{
    public class TokenModel : ITokenModel
    {
        public string JWTToken { get;set; }

        public TokenModel(JwtSecurityToken token)
        {
            JWTToken = token.EncodedPayload;
        }
    }
}
