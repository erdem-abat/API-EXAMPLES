using ClassModifiers.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassModifiers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet("Public")]
        public string GetUser(string name)
        {
            Public user = new Public { Name = name };

            return (user.Name+"  "+user.GetName());
        }
        [HttpGet("Private")]
        public int GetCar(int cost)
        {
            Private car = new Private();    

            //return (car.cost + "  " + car.getPrice());
            return (cost);
        }
        [HttpGet("Protected")]
        public string GetName()
        {
            Protected contact = new Protected();
            Protected2 contact2 = new Protected2();
            //return (contact.Name);
            return (contact2.GetName());
        }
        [HttpGet("Internal")]
        public int GetCounter()
        {
            Internal counter = new Internal();
            counter.counter += 1;
            return (counter.counter);
        }
        [HttpGet("ProtectedInternal")]
        public string GetNameValue()
        {
            ProtectedInternal name = new ProtectedInternal();

            return (name.Name);
        }
        [HttpGet("PrivateProtected")]
        public int GetModel()
        {
            PrivateProtected2 name = new PrivateProtected2();

            return (name.GetModel());
        }
    }
}
