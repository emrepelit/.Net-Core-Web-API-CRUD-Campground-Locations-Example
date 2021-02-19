using CampgroundFinder.Business.Abstract;
using CampgroundFinder.Business.Concrete;
using CampgroundFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampgroundFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampgroundsController : ControllerBase
    {
        private ICampgroundService _campgroundService;
        public CampgroundsController(ICampgroundService campgroundService)
        {
            _campgroundService = campgroundService; //dependency injection
        }
        [HttpGet]
        public List<Campground> Get()
        {
            return _campgroundService.GetAllCampgrounds();
        }
        [HttpGet("{id}")]
        public Campground Get(int id)
        {
            return _campgroundService.GetCampgroundById(id);
        }
        [HttpPost]
        public Campground Post([FromBody]Campground campground)
        {
            return _campgroundService.CreateCampground(campground);
        }
        [HttpPut]
        public Campground Put([FromBody] Campground campground)
        {
            return _campgroundService.UpdateCampground(campground);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _campgroundService.DeleteCampground(id);
        }
    }
}
