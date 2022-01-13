using APITestUnitario.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APITestUnitario.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(User user)
        {
            var usuario80 = new User();

            if (usuario80.Nome == user.Nome && user.Idade ==
                usuario80.Idade)
                return Ok();

            return BadRequest();


        }

          
            


    }
}
