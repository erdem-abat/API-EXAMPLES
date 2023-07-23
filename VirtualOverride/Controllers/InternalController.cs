using ClassModifiers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VirtualOverride.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InternalController : ControllerBase
    {
        //[HttpGet]
        //public IActionResult Get()
        //{
        //    Internal counter = new Internal();

        //    return (counter.counter);

        //}
    }
}
