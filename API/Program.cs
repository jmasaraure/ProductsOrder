using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Infrastructure.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace API
{
      public class Program
      {
            public static async Task Main(string[] args)
            {
                  var createHost = CreateHostBuilder(args).Build();
                  using (var inScope = createHost.Services.CreateScope())
                  {
                        var services = inScope.ServiceProvider;
                        var context = services.GetRequiredService<ProductsOrderDbContext>();
                        await context.Database.MigrateAsync();
                        await ProductsOrderDbInitializer.SeedData(context);
                  }
                  createHost.Run();
            }

            public static IHostBuilder CreateHostBuilder(string[] args) =>
                Host.CreateDefaultBuilder(args)
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                          webBuilder.UseStartup<Startup>()
                          .UseUrls("https://localhost:62183");
                    });
      }
}
