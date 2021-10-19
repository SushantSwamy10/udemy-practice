using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route(template:"[controller]")]
    public class DepartmentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Get All Students");
        }

        [HttpGet(template:"{code}")]
        public IActionResult GetA(string code)
        {
            return Ok("get this" + code + "department data");
        }
        
        [HttpPost]
        public IActionResult Insert()
        {
            return Ok("Insert new department");
        }
        
        [HttpPut(template:"{code}")]
        public IActionResult Update(string code)
        {
            return Ok("Update this" + code + "department data");
        }
        
        [HttpDelete(template:"{code}")]
        public IActionResult Delete(string code)
        {
            return Ok("Delete this" + code + "department data");
        }
    }
}