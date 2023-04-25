using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Order;
using SemestriProject.Infra.RoadFreight;
using SemestriProject.Infra.SeaFreight;

namespace SemestriProject.Soft
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var scope = host.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var dbRoadFreights = services.GetRequiredService<RoadFreightDbContext>();
                RoadFreightDbInitializer.Initialize(dbRoadFreights);
                var dbSeaFreights = services.GetRequiredService<SeaFreightDbContext>();
                SeaFreightDbInitializer.Initialize(dbSeaFreights);
                var dbAirFreights = services.GetRequiredService<AirFreightDbContext>();
                AirFreightDbInitializer.Initialize(dbAirFreights);
                var dbOrders = services.GetRequiredService<OrderDbContext>();
                OrderDbInitializer.Initialize(dbOrders);
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
