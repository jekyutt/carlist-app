using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.AirFreight;

namespace SemestriProject.Infra.AirFreight
{
    public class AirFreightDbContext : DbContext
    {
        public AirFreightDbContext(DbContextOptions<AirFreightDbContext> options)
            : base(options)
        {
        }

        public DbSet<AmericaData> America { get; set; }
        public DbSet<AustraliaData> Australia { get; set; }
        public DbSet<ChinaData> China { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<AmericaData>().ToTable(nameof(America)).HasKey(x => x.Id);
            builder.Entity<AustraliaData>().ToTable(nameof(Australia)).HasKey(x => x.Id);
            builder.Entity<ChinaData>().ToTable(nameof(China)).HasKey(x => x.Id);
        }
    }
}
