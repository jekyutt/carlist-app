using Microsoft.EntityFrameworkCore;
using SemestriProject.Data.Order;

namespace SemestriProject.Infra.Order
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options)
            : base(options)
        {
        }

        public DbSet<MakeOrderData> MakeOrder { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            InitializeTables(builder);
        }
        public static void InitializeTables(ModelBuilder builder)
        {
            if (builder is null) return;
            builder.Entity<MakeOrderData>().ToTable(nameof(MakeOrder)).HasKey(x => x.Id);
        }
    }
}
