using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using VirtualOverride.Models;

namespace VirtualOverride.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Triangle triangle = new Triangle();
            float a =triangle.area();
            Square square = new Square();
            float b = square.area();
            return Ok(a+"  "+b);
        }
    }
}
