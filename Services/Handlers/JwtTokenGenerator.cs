using Services.Models;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;

namespace Services.Handlers
{
    public class JwtTokenGenerator
    {
        public JwtTokenGenerator()
        {

        }

        public ITokenModel GetToken(List<Claim> authClaims)
        {
            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddHours(3),
                claims: authClaims
                );

            var tokenModel = new JwtTokenModel
            {
                JWTToken = token.EncodedPayload
            };

            return tokenModel;  
        }
    }
}
