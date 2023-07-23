using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RefOut.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public void Get()
        {
            int refA = 3;
            int outB;

            Change(out outB, ref refA);

            Console.WriteLine("refValue: " + refA);
            Console.WriteLine("outValue: " + outB); 
        }
        static void Change(out int i, ref int j)
        {
            i = 8; 
            j = j + 2; 
        }
    }
}
