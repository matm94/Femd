using FemdAPI.Infrastructure.Extensions;
using FemdAPI.Infrastructure.Models;
using FemdAPI.Infrastructure.Options;
using Microsoft.Extensions.Options;
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
        public JwtService(IOptions<JwtOptions> jwtOptions)
        {
            _jwtOptions = jwtOptions.Value;
        }

        public JwtDTO CreateToken(Guid id, string role)
        {
            var now = DateTime.UtcNow;
            var claims = new Claim[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub, id.ToString()),
                    new Claim(JwtRegisteredClaimNames.UniqueName, id.ToString()),
                    new Claim(ClaimTypes.Role, role),
                    //uniwersalne id tokena
                    new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                    // data stworzneia tokena
                    new Claim(JwtRegisteredClaimNames.Iat,now.ToTimestamp().ToString()),
                };

            var expires = now.AddMinutes(_jwtOptions.LifeTime);

            var signingCredentials = new SigningCredentials(
                new SymmetricSecurityKey(
                    Encoding.UTF8.GetBytes(_jwtOptions.SecretKey)), SecurityAlgorithms.HmacSha256Signature);
            var jwt = new JwtSecurityToken(

                issuer: _jwtOptions.Issuer,
                claims: claims,
                notBefore: now,
                expires:expires,
                signingCredentials: signingCredentials

                );
            var createToken = new JwtSecurityTokenHandler().WriteToken(jwt);

            return new JwtDTO
            {
                Token = createToken,
                LifeTime = expires.ToTimestamp()
            };
        }


    }

}
