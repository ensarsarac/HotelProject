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
    public class DashboardWidgetsController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IBookingService _bookingService;
        private readonly IAppUserService _appUserSerevice;
        private readonly IRoomService _roomService;

        public DashboardWidgetsController(IStaffService staffService, IBookingService bookingService, IAppUserService appUserService, IRoomService roomService)
        {
            _staffService = staffService;
            _bookingService = bookingService;
            _appUserSerevice = appUserService;
            _roomService = roomService;
        }

        [HttpGet("DashboardStaffCount")]
        public IActionResult DashboardStaffCount()
        {
            var values = _staffService.TGetList().Count();
            return Ok(values);
        }


        [HttpGet("DashboardBookingCount")]
        public IActionResult DashboardBookingCount()
        {
            var values = _bookingService.TGetList().Count();
            return Ok(values);
        }


        [HttpGet("DashboardUserCount")]
        public IActionResult DashboardUserCount()
        {
            var values = _appUserSerevice.TGetList().Count();
            return Ok(values);
        }

        [HttpGet("DashboardRoomCount")]
        public IActionResult DashboardRoomCount()
        {
            var values = _roomService.TGetList().Count();
            return Ok(values);
        }

        [HttpGet("DashboardGetStaffList")]
        public IActionResult DashboardGetStaffList()
        {
            var values = _staffService.TGetList();
            return Ok(values);
        }
        [HttpGet("DashboardGetBookingList")]
        public IActionResult DashboardGetBookingList()
        {
            var values = _bookingService.TGetListWithInclude();
            return Ok(values);
        }

    }
}
