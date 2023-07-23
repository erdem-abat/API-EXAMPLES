using AbstractAndInterface.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AbstractAndInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            AlfaRomeo alfaRomeo= new AlfaRomeo();
            alfaRomeo.Race(alfaRomeo);
            return Ok();
        }
    }
}
