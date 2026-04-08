using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly ITestIService _service1;
        private readonly ITestIService _service2;

        public TestController(ITestIService service1, ITestIService service2)
        {
            _service1 = service1;
            _service2 = service2;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new
            {
                Service1 = _service1.GetId(),
             
                Service2 = _service2.GetId()
            });
        }
        [HttpGet("1")]
        public IActionResult Get2()
        {
            return Ok(new
            {
                Service1 = _service1.GetId(),
                Service2 = _service2.GetId()
            });
        }
    }
}
