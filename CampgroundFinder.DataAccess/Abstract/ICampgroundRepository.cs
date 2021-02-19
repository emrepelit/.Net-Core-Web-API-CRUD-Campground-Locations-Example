using CampgroundFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CampgroundFinder.DataAccess.Abstract
{
    public interface ICampgroundRepository
    {
        List<Campground> GetAllCampgrounds();

        Campground GetCampgroundById(int id);
        Campground CreateCampground(Campground campground);
        Campground UpdateCampground(Campground campground);
        void DeleteCampground(int id);
    }
}
