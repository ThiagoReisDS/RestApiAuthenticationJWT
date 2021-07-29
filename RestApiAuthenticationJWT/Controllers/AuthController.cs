using Microsoft.AspNetCore.Mvc;
using RestApiAuthenticationJwt.Business;
using RestApiAuthenticationJwt.Data.VO;

namespace RestApiAuthenticationJwt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private ILoginBusiness _loginBusiness;

        public AuthController(ILoginBusiness loginBusiness)
        {
            _loginBusiness = loginBusiness;
        }

        [HttpPost]
        [Route("signin")]
        public IActionResult Signin([FromBody] UserVO user)
        {
            if (user == null) return BadRequest("Invalid client request");
            var token = _loginBusiness.ValidationCredentions(user);
            if (token == null) return Unauthorized();

            return Ok(token);
        }
    }
}
