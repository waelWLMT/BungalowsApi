using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Core.Utils;
using Microsoft.IdentityModel.Tokens;

namespace BLL.Utils
{
    public class JwtTokenGenerator : IJwtTokenGenerator
    {
        private readonly MyConfiguration _myConfiguration;

        public JwtTokenGenerator(MyConfiguration myConfiguration)
        {
            _myConfiguration = myConfiguration;
        }

        public string GenerateToken(string userName)
        {
            var claims = new[]
           {
            new Claim(JwtRegisteredClaimNames.Sub, userName),
            new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_myConfiguration.ApiSecretKey));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: "yourdomain.com", // must be set by configuration
                audience: "yourdomain.com", // must be set by configuration
                claims: claims,
                expires: DateTime.Now.AddMinutes(30),
                signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
