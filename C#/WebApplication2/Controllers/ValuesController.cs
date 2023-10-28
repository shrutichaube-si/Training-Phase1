using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Welcome")]
        [HttpGet("Welcome1")]
        public string Welcome()
        {
            return "Jai Shree Ram";
        }
        public string Welcome1()
        {
            return "Jai Shree Ram";
        }

    }
}
