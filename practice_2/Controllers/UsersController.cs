using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UserManager _usermanager;
        public UsersController(UserManager userManager)
        {
            _usermanager = userManager;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
           // var UserList = _usermanager.GetUsers();
            return Ok(_usermanager.GetUsers());
        }

        [HttpPost]
        public IActionResult PostUsers(User user)
        {
            return Ok(_usermanager.PostUsers(user));
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
