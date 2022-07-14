using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Utils.Interfaces;
using Utils.Models;

namespace Utils.Handlers
{
    public class JwtTokenGenerator
    {
        private IConfiguration _config;

        public JwtTokenGenerator(IConfiguration config)
        {
            _config = config;
        }

        //public ITokenModel GetToken(List<Claim> authClaims)
        //{
        //    var token = new JwtSecurityToken(
        //        expires: DateTime.Now.AddHours(3),
        //        claims: authClaims
        //        );

        //    var tokenModel = new JwtTokenModel
        //    {
        //        JWTToken = token.EncodedPayload
        //    };

        //    return tokenModel;
        //}

        public string Generate(IUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[]
            {
                new Claim(ClaimTypes.NameIdentifier, user.UserID.ToString()),
                //new Claim("Permissions", JsonSerializer.Serialize(permissions))
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
                   _config["Jwt:Audience"],
                   claims,
                   expires: DateTime.Now.AddMinutes(15),
                   signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
