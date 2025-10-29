using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyWebAPIProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetName()
        {
            var data = new { name = "Ian Imsicke" }; 
            return Ok(data);
        }
    }
}
