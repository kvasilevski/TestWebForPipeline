using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestWebForPipeline.Models;

namespace TestWebForPipeline.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<UserDto> GetUsers()
        {
            //getusers
            //getusers2
            //getusers3
            return _userService.GetUser();
        }

        [HttpGet("{id}")]
        public UserDto GetUser(int id)
        {
            //getuser
            //getuser2
            //getuser3
            return _userService.GetUserById(id);
        }

    }
}