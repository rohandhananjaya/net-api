using Microsoft.AspNetCore.Mvc;
namespace net_api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        [HttpPost]
        public IActionResult Login([FromBody] LoginModel login)
        {
            if (login.Username == "user" && login.Password == "password")
            {
                return Ok(new { message = "Login successful" });
            }

            return Unauthorized(new { message = "Invalid credentials" });
        }
    }
}
