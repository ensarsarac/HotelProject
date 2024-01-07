using HotelProjectBusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelProjectWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUser;

        public AppUserController(IAppUserService appUser)
        {
            _appUser = appUser;
        }

        [HttpGet]
        public IActionResult AppUserList()
        {
            var values = _appUser.TUserListWithLocation();
            return Ok(values);
        }
    }
}
