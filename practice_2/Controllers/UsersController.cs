﻿using Logic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserManager _userManager;
        public UsersController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_userManager.GetUsers());
        }

        [HttpPost]
        public IActionResult PostUsers(User user)
        {
            return Ok(_userManager.PostUsers(user));
        }

        [HttpPut]
        public IActionResult PutUsers(User user)
        {
            return Ok(_userManager.PutUsers(user));
        }

        [HttpDelete]
        public IActionResult DeleteUsers(User user)
        {
            return Ok(_userManager.DeleteUsers(user));
        }
    }
}
