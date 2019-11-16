using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab3ED2.Clases;
using Lab3ED2.Shared;

namespace Lab3ED2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        // GET: api/Autenticacion
        [HttpGet("{Llave}")]
        public string Get([FromBody] JsonRecibido value, string Llave)
        {
            return ConfiguracionAut.GenerarJWT(Llave, value.Nombre, value.ID);
        }
    }
}
