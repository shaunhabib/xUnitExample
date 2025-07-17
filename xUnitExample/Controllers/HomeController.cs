using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace xUnitExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        [HttpGet]
        public string GetWithFact()
        {
            return "Hello, World!";
        }

        [HttpGet]
        public string GetWithTheory(int guessnumber)
        {
            if (guessnumber == 100)
            {
                return "You guessed correct number";
            }
            else if (guessnumber < 100)
            {
                return "You guessed too low";
            }
            else
            {
                return "You guessed too high";
            }
        }
    }
}
