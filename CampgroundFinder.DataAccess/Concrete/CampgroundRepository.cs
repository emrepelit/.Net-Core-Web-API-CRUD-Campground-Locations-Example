using CampgroundFinder.DataAccess.Abstract;
using CampgroundFinder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CampgroundFinder.DataAccess.Concrete
{
    public class CampgroundRepository : ICampgroundRepository
    {
        public Campground CreateCampground(Campground campground)
        {
            using (var campgroundDbContext = new CampgroundDbContext())
            {
                campgroundDbContext.Campgrounds.Add(campground);
                campgroundDbContext.SaveChanges();
                return campground;
            }
        }

        public void DeleteCampground(int id)
        {
            using (var campgroundDbContext = new CampgroundDbContext())
            {
                var deletedCampground = GetCampgroundById(id);
                campgroundDbContext.Remove(deletedCampground);
                campgroundDbContext.SaveChanges();
            }
        }

        public List<Campground> GetAllCampgrounds()
        {
            using (var campgroundDbContext = new CampgroundDbContext())
            {
                return campgroundDbContext.Campgrounds.ToList();
            }
        }

        public Campground GetCampgroundById(int id)
        {
            using (var campgroundDbContext = new CampgroundDbContext())
            {
                return campgroundDbContext.Campgrounds.Find(id);
            }
        }

        public Campground UpdateCampground(Campground campground)
        {
            using (var campgroundDbContext = new CampgroundDbContext())
            {
                campgroundDbContext.Campgrounds.Update(campground);
                campgroundDbContext.SaveChanges();
                return campground;
            }
        }
    }
}
