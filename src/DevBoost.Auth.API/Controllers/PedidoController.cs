using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Auth.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [Authorize(Roles= "ADMIN,USER")]
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }
        [Authorize(Roles = "ADMIN,USER")]
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        [HttpDelete("{id}"), Authorize(Roles = "ADMIN")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
