using Encapsulation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Encapsulation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        [HttpPut]
        public int Put(int no)
        {
            User user = new User();
            user.no = no;
            return user.no;
        }
    }
}
