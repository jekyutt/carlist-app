using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SemestriProject.Infra.AirFreight;
using SemestriProject.Infra.Order;
using SemestriProject.Infra.RoadFreight;
using SemestriProject.Infra.SeaFreight;

namespace SemestriProject.Soft.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            initializeTables(builder);
        }

        internal void initializeTables(ModelBuilder builder)
        {
            RoadFreightDbContext.InitializeTables(builder);
            SeaFreightDbContext.InitializeTables(builder);
            AirFreightDbContext.InitializeTables(builder);
            OrderDbContext.InitializeTables(builder);
        }
    }
}
