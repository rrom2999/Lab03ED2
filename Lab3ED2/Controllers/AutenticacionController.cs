using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3ED2.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Lab3ED2.Clases;

namespace Lab3ED2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        
        // GET: api/Autenticacion
        [HttpGet("{Llave}")]
        public string Get([FromBody] JsonRecibido value, string Llave)
        {
            return ConfiguracionAut.GenerarJWT(Llave, value.Nombre, value.ID);
        }
    }
}
