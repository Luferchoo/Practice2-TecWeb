using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public UserManager _usermanager = new UserManager();

        [HttpGet]
        public IActionResult GetUsers()
        {
            var UserList = _usermanager.GetUsers();
            return Ok(UserList);
        }

        [HttpPost]
        public IActionResult PostUsers()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult PutUsers()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteUsers()
        {
            return Ok();
        }
    }
}
