using Microsoft.AspNetCore.Mvc;

namespace Client.ApiModule.UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return StatusCode(200);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return StatusCode(200);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return StatusCode(200);
        }
    }
}