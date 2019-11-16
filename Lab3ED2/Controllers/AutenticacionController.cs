using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab3ED2.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab3ED2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutenticacionController : ControllerBase
    {
        // GET: api/Autenticacion
        [HttpGet]
        public string Get()
        {
            return ConfiguracionAut.GenerarJWT();
        }

        // GET: api/Autenticacion/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Autenticacion
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Autenticacion/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
