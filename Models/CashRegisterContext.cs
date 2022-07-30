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

            DbPath = Environment.GetEnvironmentVariable("MYSQL_CONNECTION")!;

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(DbPath, new MySqlServerVersion(new Version(5,5,62)));
        }
    }
}