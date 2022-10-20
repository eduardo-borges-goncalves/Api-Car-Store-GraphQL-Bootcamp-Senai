using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;

namespace ApiDevInCarGQL.Services
{
    public class TokenService : ITokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GenerateJwt(string user)
        {
            var userClaim = GetIdentityByUser(user);
            var generated = DateTime.UtcNow;
            var expires = generated.AddHours(1);

            var handler = new JwtSecurityTokenHandler();

            var propertiesToken = new SecurityTokenDescriptor()
            {
                Issuer = _configuration.GetSection("TokenSettings").GetValue<string>("Issuer"),
                IssuedAt = generated,
                Expires = expires,
                Subject = userClaim,
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(_configuration.GetSection("TokenSettings").GetValue<string>("Key"))),
                    SecurityAlgorithms.HmacSha256Signature
                    )
            };

            var accessToken = handler.WriteToken(handler.CreateToken(propertiesToken));
            return accessToken;
        }

        private ClaimsIdentity GetIdentityByUser(
            string user
        )
        {
            var claimsUser = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            return new ClaimsIdentity(
                new GenericIdentity(user),
                claimsUser
            );
        }
    }
}
