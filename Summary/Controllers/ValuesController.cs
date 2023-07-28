using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Summary.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Add Customer To Db
        /// </summary>
        /// <param name="Name">Customer's Name</param>
        /// <param name="Email">Customer's Email</param>
        /// <param name="Phone">Customer's Phone</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string Name, string Email, int Phone)
        {
            return Ok();

        }
    }
}
