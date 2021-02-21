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
        /// <summary>
        /// Kamp lokasyonlarının hepsini getirir.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Campground> Get()
        {
            return _campgroundService.GetAllCampgrounds();
        }
        /// <summary>
        /// Kamp lokasyonunu id ye göre getirir.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Campground Get(int id)
        {
            return _campgroundService.GetCampgroundById(id);
        }
        /// <summary>
        /// Kamp lokasyonunu post eder.
        /// </summary>
        /// <param name="campground"></param>
        /// <returns></returns>
        [HttpPost]
        public Campground Post([FromBody]Campground campground)
        {
            return _campgroundService.CreateCampground(campground);
        }
        /// <summary>
        /// Kamp lokasyonu güncelleme metodu.
        /// </summary>
        /// <param name="campground"></param>
        /// <returns></returns>
        [HttpPut]
        public Campground Put([FromBody] Campground campground)
        {
            return _campgroundService.UpdateCampground(campground);
        }
        /// <summary>
        /// Kamp lokasyonunu siler.
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _campgroundService.DeleteCampground(id);
        }
    }
}
