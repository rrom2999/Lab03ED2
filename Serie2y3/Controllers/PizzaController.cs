using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Serie2y3.CLASES;
using Serie2y3.Servicios;
using Microsoft.AspNetCore.Mvc;

namespace Serie2y3.Controllers
{
    public class PizzaController
    {
        [Route("api/[controller]")]
        [ApiController]
        public class BooksController : ControllerBase
        {
            private readonly PizzaServicio _pizzaService;

            public BooksController(PizzaServicio pizzaService)
            {
                _pizzaService = pizzaService;
            }

            [HttpGet]
            public ActionResult<List<Pizza>> Get() => _pizzaService.Get();

            [HttpGet("{id:length(24)}", Name = "GetPizza")]
            public ActionResult<Pizza> Get(string id)
            {
                var pizza = _pizzaService.Get(id);

                if (pizza == null)
                {
                    return NotFound();
                }

                return pizza;
            }

            [HttpPost]
            public ActionResult<Pizza> Create(Pizza pizza)
            {
                _pizzaService.Create(pizza);

                return CreatedAtRoute("GetPizza", new { id = pizza.Id.ToString() }, pizza);
            }

            [HttpPut("{id:length(24)}")]
            public IActionResult Update(string id, Pizza pizzaIn)
            {
                var pizza = _pizzaService.Get(id);

                if (pizza == null)
                {
                    return NotFound();
                }

                _pizzaService.Update(id, pizzaIn);

                return NoContent();
            }

            [HttpDelete("{id:length(24)}")]
            public IActionResult Delete(string id)
            {
                var pizza = _pizzaService.Get(id);

                if (pizza == null)
                {
                    return NotFound();
                }

                _pizzaService.Remove(pizza.Id);

                return NoContent();
            }
        }
    }
}
