using Microsoft.AspNetCore.Mvc;
using ssd_authorization_solution.Services;

namespace ssd_authorization_solution.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtAuthenticationService _jwtService;

        public AuthController(JwtAuthenticationService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginModel model)
        {
            // In a real application, validate credentials against your database
            // This is a simplified example
            if (IsValidUser(model.Username, model.Password))
            {
                var userId = GetUserId(model.Username); // Get from your database
                var roles = GetUserRoles(model.Username); // Get from your database
                
                var token = _jwtService.GenerateToken(userId, model.Username, roles);
                
                return Ok(new { Token = token });
            }
            
            return Unauthorized();
        }

        // In a real application, these methods would check against your database
        private bool IsValidUser(string username, string password)
        {
            // Replace with your user validation logic
            return username == "user" && password == "password";
        }

        private string GetUserId(string username)
        {
            // Replace with your user ID retrieval logic
            return "123";
        }

        private IEnumerable<string> GetUserRoles(string username)
        {
            // Replace with your role retrieval logic
            return new[] { "User" };
        }
    }

    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}