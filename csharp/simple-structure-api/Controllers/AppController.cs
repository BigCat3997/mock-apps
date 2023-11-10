using Microsoft.AspNetCore.Mvc;

namespace simple_structure_api.Controllers
{
    [ApiController]
    [Route("Api/[controller]/[action]")]
    public class AppController : ControllerBase
    {
       
        private readonly ILogger<AppController> _logger;

        public AppController(ILogger<AppController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Version")]
        public string Version()
        {
            return "1.0.0";
        }
    }
}
