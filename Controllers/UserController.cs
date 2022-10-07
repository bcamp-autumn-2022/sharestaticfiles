using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace sharestaticfiles.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {

        // GET api/User
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = "I am a user";
            return new OkObjectResult(result);
        }
        
    }
}