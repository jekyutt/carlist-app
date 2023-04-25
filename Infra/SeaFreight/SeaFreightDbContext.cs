using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.SeaFreight;

namespace SemestriProject.Infra.SeaFreight
{
    public class SeaFreightDbContext : DbContext
    {
        public SeaFreightDbContext(DbContextOptions<SeaFreightDbContext> options)
            : base(options)
        {
        }

        public DbSet<EuropeData> Europe { get; set; }
        public DbSet<AfricaData> Africa { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<EuropeData>().ToTable(nameof(Europe)).HasKey(x => x.Id);
            builder.Entity<AfricaData>().ToTable(nameof(Africa)).HasKey(x => x.Id);
        }
    }
}
