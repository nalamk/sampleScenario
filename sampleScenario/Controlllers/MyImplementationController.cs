using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using sampleScenario.Services;

namespace sampleScenario.Controlllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyImplementationController : ControllerBase
    {
        private readonly MyImplementation _myImplementation;

        public MyImplementationController(MyImplementation myImplementation)
        {
            _myImplementation = myImplementation;
        }

        [HttpGet(Name = "GetMyImplementation")]
        public IActionResult Get()
        {
            // Use methods or properties of MyImplementation directly
            var username = _myImplementation.GetUserName();
            var address = _myImplementation.GetAddress();

            // ...

            var jsonResult = new { username, address };

            return Ok(jsonResult);
        }
    }
}
