using System;
using System.Collections.Generic;
using System.Text;
using CampgroundFinder.Entities;
namespace CampgroundFinder.Business.Abstract
{
    public interface ICampgroundService
    {
        List<Campground> GetAllCampgrounds();
        Campground GetCampgroundById(int id);
        Campground CreateCampground(Campground campground);
        Campground UpdateCampground(Campground campground);
        void DeleteCampground(int id);
    }
}
