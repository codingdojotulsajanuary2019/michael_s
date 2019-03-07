using Microsoft.AspNetCore.Mvc;

namespace First_ASP.Controllers
{

    public class HomeController : Controller
    {
        // REQUESTS
        // Localhost: 5000/
        [HttpGet("")]
        public string Index()
        {
            return "Hello from Controller";
        }
        // Localhost: 5000/hello
        [HttpGet("hello")]
        public string Hello()
        {
            return "Hi Again!";
        }
        // Localhost/5000/users/????
        [HttpGet("users/{username}/{location}")]
        public string HelloUser(string username, string location)
        {
            return $"Hello {username} from {location}";
        }
    }

}