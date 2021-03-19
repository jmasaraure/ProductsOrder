using Core.Contracts;
using Infrastructure.Data;
using Infrastructure.Data.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using AutoMapper;
using API.Helpers;

namespace API
{
      public class Startup
      {
            private readonly IConfiguration _config;
            public Startup(IConfiguration configuration)
            {
                  _config = configuration;
            }

            // This method gets called by the runtime. Use this method to add services to the container.
            public void ConfigureServices(IServiceCollection services)
            {

                  services.AddControllers();
                  services.AddSwaggerGen(c =>
                  {
                        c.SwaggerDoc("v1", new OpenApiInfo { Title = "API", Version = "v1" });
                  });
                  //Configuring the connection string
                  services.AddDbContext<ProductsOrderDbContext>(x =>
                        x.UseSqlServer(_config.GetConnectionString("DefaultConnection")));

                  services.AddScoped<IProductRepository, ProductRepository>();
                  services.AddScoped<IStaffRepository, StaffRepository>();
                  services.AddScoped(typeof(IRepository<>), (typeof(RepositoryBase<>)));
                  services.AddAutoMapper(typeof(AutoMapperProfiles));
                  services.AddCors(options =>
                  {
                        options.AddPolicy("MyCorsPolicy", policy =>
                        {
                              policy.AllowAnyHeader()
                              .AllowAnyMethod()
                              .WithOrigins("*");
                        });
                  });
            }

            // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
            public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                  if (env.IsDevelopment())
                  {
                        app.UseDeveloperExceptionPage();
                        app.UseSwagger();
                        app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "API v1"));
                  }

                  app.UseHttpsRedirection();

                  app.UseRouting();

                  app.UseCors("MyCorsPolicy");

                  app.UseAuthorization();

                  app.UseEndpoints(endpoints =>
                  {
                        endpoints.MapControllers();
                  });
            }
      }
}
