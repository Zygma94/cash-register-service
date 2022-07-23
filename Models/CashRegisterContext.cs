using Microsoft.EntityFrameworkCore;

namespace CashRegister.Models
{
    public class CashRegisterContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; } = null!;

        public string DbPath { get; }

        public CashRegisterContext(DbContextOptions<CashRegisterContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "CashRegisterDBL.db");
            Console.WriteLine(DbPath);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"data source={DbPath}; foreign keys=true ");
        }
    }
}