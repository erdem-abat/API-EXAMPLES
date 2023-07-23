using Attributes.Attributes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Attributes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Custom("GetMethod", "car")]
        public IActionResult Get() {
            return Ok();
        }
    }
}
