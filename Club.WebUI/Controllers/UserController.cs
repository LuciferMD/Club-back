using Club.Application.Services;
using Club.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Club.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private UserService userService;

        public UserController(UserService userService)
        {
            this.userService = userService;
        }

        [HttpGet]
        public IActionResult GetUser(Guid id)
        {
            User user = userService.Get(id);
            return new ObjectResult(user);
        }
    }
}
