using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.RoadFreight;

namespace SemestriProject.Infra.RoadFreight
{
    public class RoadFreightDbContext : DbContext
    {
        public RoadFreightDbContext(DbContextOptions<RoadFreightDbContext> options)
            : base(options)
        {
        }

        public DbSet<BalticData> Baltics { get; set; }
        public DbSet<RussiaAndCISData> RussiaAndCIS { get; set; }
        public DbSet<ScandinaviaData> Scandinavia { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<BalticData>().ToTable(nameof(Baltics)).HasKey(x => x.Id);
            builder.Entity<RussiaAndCISData>().ToTable(nameof(RussiaAndCIS)).HasKey(x => x.Id);
            builder.Entity<ScandinaviaData>().ToTable(nameof(Scandinavia)).HasKey(x => x.Id);
        }
    }
}
