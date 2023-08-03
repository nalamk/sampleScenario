using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sampleScenario.Services;

namespace sampleScenario.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyImplementationController : ControllerBase
    {
        private readonly Interface1 _myInterface1;
        private readonly Interface2 _myInterface2;

        public MyImplementationController(Interface1 myInterface1, Interface2 myInterface2)
        {
            _myInterface1 = myInterface1;
            _myInterface2 = myInterface2;
        }

        [HttpGet(Name = "GetMyImplementation")]
        public IActionResult Get()
        {
            // Use methods or properties of MyImplementation directly
            var username = _myInterface1.GetUserName();
            var address = _myInterface2.GetAddress();

            // ...

            var jsonResult = new { username, address };

            return Ok(jsonResult);
        }
    }
}
