using Dispose.Data.Abstract;
using Dispose.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Dispose.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IUserRepository userRepository;
        public ValuesController(IUserRepository _userRepository)
        {
            userRepository = _userRepository;
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var data = userRepository.Get(id);
            userRepository.Dispose();
            return Ok(data);
        }
        [HttpPost]
        public IActionResult Add(User user)
        {
            userRepository.Add(user);
            userRepository.SaveChanges();
            userRepository.Dispose();
            return Ok(user);
        }
    }
}
