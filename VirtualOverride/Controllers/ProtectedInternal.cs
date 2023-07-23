using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using VirtualOverride.Models;

namespace VirtualOverride.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProtectedInternal : ControllerBase
    {
        [HttpGet]
        public string GetName()
        {
            ProtectedInt name = new ProtectedInt();

            return (name.GetName());
        }
    }
}
