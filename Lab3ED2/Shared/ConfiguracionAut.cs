using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Lab3ED2.Shared
{
    public static class ConfiguracionAut
    {
        public static string GenerarJWT()
        {
            var llaveDeSeguridad = new SymmetricSecurityKey(Encoding.Default.GetBytes("LlaveLlaveLlaveLlave"));
            var credenciales = new SigningCredentials(llaveDeSeguridad, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim("Username", "Admin"),
                new Claim("Role", "1"),
            };
            
            var tokenGenerado = new JwtSecurityToken(issuer: "null", audience: "null", claims: claims, notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(20), credenciales);
            
            return new JwtSecurityTokenHandler().WriteToken(tokenGenerado);
        }
    }
}
