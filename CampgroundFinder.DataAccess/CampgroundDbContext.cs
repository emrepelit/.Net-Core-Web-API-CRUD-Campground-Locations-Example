using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CampgroundFinder.Entities;

namespace CampgroundFinder.DataAccess
{
    public class CampgroundDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-8SN80FP; Database=CampgroundDb;uid=testuser;pwd=xxx");
        }
        public DbSet<Campground> Campgrounds { get; set; }
    }
}
