using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend_herhaling_sneakers.Configuration;
using backend_herhaling_sneakers.Data;
using backend_herhaling_sneakers.Repositories;
using backend_herhaling_sneakers.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace backend_herhaling_sneakers
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.Configure<ConnectionStrings>(Configuration.GetSection("ConnectionStrings"));
            services.AddDbContext<SneakerContext>();

            services.AddTransient<ISneakerContext, SneakerContext>();
            services.AddTransient<IBrandRepository, BrandRepository>();
            services.AddTransient<ISneakerService, SneakerService>();


            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "backend_herhaling_sneakers", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "backend_herhaling_sneakers v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
