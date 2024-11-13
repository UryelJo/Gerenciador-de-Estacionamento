using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using JwtRegisteredClaimNames = System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames;

namespace estacionamento_api.Utils.Security;

internal sealed class TokenProvider(IConfiguration configuration)
{
    public string Create(String nick)
    {
        string secretKey = configuration["Jwt:Key"];
        var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
        var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
        var tokenDescriptor = new SecurityTokenDescriptor
        {
            Subject = new ClaimsIdentity([
                new Claim(JwtRegisteredClaimNames.Sub, nick)
            ]),
            Expires = DateTime.UtcNow.AddDays(1),
            SigningCredentials = credentials,
            Issuer = configuration["Jwt:Issuer"],
            Audience = configuration["Jwt:Audience"],
        };

        var handler = new JsonWebTokenHandler();
        return handler.CreateToken(tokenDescriptor);
    }
}