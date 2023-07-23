using Dispose.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dispose.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            Customer customer = new Customer();
            try
            {
                customer.Add();
                Console.WriteLine(customer.Get(1).TelNo + " created");
                var data = customer.Get(1);
                Console.WriteLine("customer disposed");
                return Ok(data);
            }
            catch (Exception)
            {

                Console.WriteLine("error");
            }
            finally
            {
                customer.Dispose();
            }
            return null;

        }
    }
}
