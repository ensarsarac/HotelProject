using HotelProjectBusinessLayer.Abstract;
using HotelProjectEntityLayer.Concrete;
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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }
        [HttpGet]
        public IActionResult BookingList()
        {
            var values = _bookingService.TGetListWithInclude();
            return Ok(values);
        }
        

        [HttpPost]
        public IActionResult AddBooking(Booking booking)
        {
            _bookingService.TAdd(booking);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TRemove(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateBooking(Booking booking)
        {
            _bookingService.TUpdate(booking);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetByIdBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }


        [HttpGet("BookingChangeApproved")]
        public IActionResult BookingChangeApproved(int id)
        {
             _bookingService.TBookingStatusChangeApproved(id);
            return Ok();
        }

        [HttpGet("BookingChangeCanceled")]
        public IActionResult BookingChangeCanceled(int id)
        {
            _bookingService.TBookingStatusChangeCanceled(id);
            return Ok();
        }

        [HttpGet("BookingChangeWaiting")]
        public IActionResult BookingChangeWaiting(int id)
        {
            _bookingService.TBookingStatusChangeWaiting(id);
            return Ok();
        }


    }
}
