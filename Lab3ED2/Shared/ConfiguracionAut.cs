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
        public static string GenerarJWT(string Llave, string Name, string ID)
        { 

            var llaveDeSeguridad = new SymmetricSecurityKey(Encoding.Default.GetBytes(Llave));
            var credenciales = new SigningCredentials(llaveDeSeguridad, SecurityAlgorithms.HmacSha256);

            var claims = new Claim[]
            {
                new Claim("Nombre", Name),
                new Claim("ID", ID),
            };
            
            var tokenGenerado = new JwtSecurityToken(issuer: "null", audience: "null", claims: claims, notBefore: DateTime.Now, expires: DateTime.Now.AddMinutes(20), credenciales);
            
            return new JwtSecurityTokenHandler().WriteToken(tokenGenerado);
        }
    }
}
