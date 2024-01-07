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
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService _subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            _subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _subscribeService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Subscribe subscribe)
        {
            _subscribeService.TAdd(subscribe);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _subscribeService.TGetById(id);
            _subscribeService.TRemove(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Subscribe subscribe)
        {
            _subscribeService.TUpdate(subscribe);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetByIdRoom(int id)
        {
            var value = _subscribeService.TGetById(id);
            return Ok(value);
        }
    }
}
