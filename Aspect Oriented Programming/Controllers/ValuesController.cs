using Aspect_Oriented_Programming.Attributes;
using Aspect_Oriented_Programming.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aspect_Oriented_Programming.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [PerformanceAspect]
        [Logger]
        [HttpGet]
        public IActionResult Get()
        {
            Student student = new Student();
            //clear cache
            //user permission control
            //.....
            Student();
            student.Name = "Test";
            student.No = 1090;
            return Ok(student.Name +"      "+ student.No);
        }
        [PerformanceAspect]
        private string Student()
        {
            Student student = new Student();

            student.Name = "Test";
            student.No = 1090;
            return (student.Name + "      " + student.No);
        }
    }
}
