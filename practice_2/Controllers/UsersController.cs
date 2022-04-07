﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace practice_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok();
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