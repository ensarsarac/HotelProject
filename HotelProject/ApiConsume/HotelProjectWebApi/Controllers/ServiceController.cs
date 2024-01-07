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
    public class ServiceController : ControllerBase
    {
        private readonly IServiceService _serviceService;

        public ServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        [HttpGet]
        public IActionResult RoomList()
        {
            var values = _serviceService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddRoom(Service service)
        {
            _serviceService.TAdd(service);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(int id)
        {
            var value = _serviceService.TGetById(id);
            _serviceService.TRemove(value);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Service service)
        {
            _serviceService.TUpdate(service);
            return Ok();
        }


        [HttpGet("{id}")]
        public IActionResult GetByIdRoom(int id)
        {
            var value = _serviceService.TGetById(id);
            return Ok(value);
        }
    }
}
