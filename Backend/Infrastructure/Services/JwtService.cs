using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace FemdAPI.Infrastructure.Services
{
    public class JwtService : IJwtService
    {
  
        private readonly JwtOptions _jwtOptions;

        public JwtService(JwtOptions jwtOptions )
        {
            _jwtOptions = jwtOptions;
        }

        public string CreatToken(string email, string role)
        {

            var SecretKey = Encoding.UTF8.GetBytes(_jwtOptions.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, email),
                    new Claim(ClaimTypes.Role, role),
                    //uniwersalne id tokena
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                }),

                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = new SigningCredentials( 
                    new SymmetricSecurityKey(SecretKey),SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var createToken = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(createToken);
            
        }
     
        
    }
}
