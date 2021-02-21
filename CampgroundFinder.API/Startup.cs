using CampgroundFinder.Business.Abstract;
using CampgroundFinder.Business.Concrete;
using CampgroundFinder.DataAccess.Abstract;
using CampgroundFinder.DataAccess.Concrete;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CampgroundFinder.API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSingleton<ICampgroundService, CampgroundManager>();
            services.AddSingleton<ICampgroundRepository, CampgroundRepository>();
            services.AddSwaggerDocument(config => {
                config.PostProcess = (doc => {
                    doc.Info.Title = "Campground Locations Api";
                    doc.Info.Version = "1.1.3";
                    //doc.Info.Contact = new NSwag.OpenApiContact()
                    //{
                    //    Name = "Emre Pelit",
                    //    Url = "linkedin.com/in/emrepelit",
                    //    Email = "emre.pelit@outlook.com"
                    //};
                });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseOpenApi();
            app.UseSwaggerUi3();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
