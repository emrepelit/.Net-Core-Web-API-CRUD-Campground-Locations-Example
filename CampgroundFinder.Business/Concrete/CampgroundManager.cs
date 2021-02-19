using CampgroundFinder.Business.Abstract;
using CampgroundFinder.DataAccess.Abstract;
using CampgroundFinder.Entities;
using CampgroundFinder.DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampgroundFinder.Business.Concrete
{
    public class CampgroundManager : ICampgroundService
    {
        private ICampgroundRepository _campgroundRepository;
        public CampgroundManager(ICampgroundRepository campgroundRepository)
        {
            _campgroundRepository = campgroundRepository; //dependency injection
        }
        public Campground CreateCampground(Campground campground)
        {
            //business gelecek.
            return _campgroundRepository.CreateCampground(campground);
        }

        public void DeleteCampground(int id)
        {
            //business gelecek.
            _campgroundRepository.DeleteCampground(id);
        }

        public List<Campground> GetAllCampgrounds()
        {
            //business gelecek.
            return _campgroundRepository.GetAllCampgrounds();
        }

        public Campground GetCampgroundById(int id)
        {
            if(id > 0) { // if basit bir business kodu örneği
                return _campgroundRepository.GetCampgroundById(id);
            }else throw new Exception("id can't be less than 1");

        }

        public Campground UpdateCampground(Campground campground)
        {
            //business gelecek.
            return _campgroundRepository.UpdateCampground(campground);
        }
    }
}
