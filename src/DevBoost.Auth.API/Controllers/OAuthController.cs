using DevBoost.Auth.Aplication.DTO;
using DevBoost.Auth.Aplication.Services;
using DevBoost.Auth.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Auth.API.Controllers
{
    public class OAuthController : Controller
    {
        private IUserService _userService;
        public OAuthController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        [Route("login")]
        public ActionResult<dynamic> Authenticate([FromBody]User model)
        {
            
 

            var user = _userService.GetUser(model.Username);

            
            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            
            return TokenService.GenerateToken(user);
            
        }
    }
}