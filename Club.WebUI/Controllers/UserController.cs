using AutoMapper;
using Club.Application.Services;
using Club.Domain.Entities;
using Club.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Club.WebUI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private UserService userService;
        private IMapper mapper;
        public UserController(UserService userService, IMapper mapper)
        {
            this.userService = userService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetUser(Guid id)
        {
            User user = userService.Get(id);
            UserView userView = mapper.Map<UserView>(user);
            return new ObjectResult(userView);
        }
    }
}
