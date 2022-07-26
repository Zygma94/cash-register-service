using Microsoft.EntityFrameworkCore;

namespace CashRegister.Models
{
    public class CashRegisterContext : DbContext
    {

        public string DbPath { get; }

        public DbSet<Product> Products { get; set; } = null!;

        public DbSet<ProductSale> ProductSales { get; set; } = null!;

        public DbSet<Sale> Sales { get; set; } = null!;

        public CashRegisterContext(DbContextOptions<CashRegisterContext> options, IConfiguration configuration) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, configuration.GetConnectionString("SQLite"));
            Console.WriteLine(DbPath);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"data source={DbPath}; foreign keys=true ");
        }
    }
}