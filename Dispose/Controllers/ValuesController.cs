using dispose.Data.Abstract;
using dispose.Data.Concrete;
using dispose.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dispose.Controllers
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
            var data =userRepository.Get(id);
            if (data != null)
            {
                userRepository.Dispose();
                return Ok(data);
            }
            else
                return BadRequest();

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
