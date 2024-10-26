using System.Data.Entity;

namespace StockMonitoringNetF.Models
{
    public class StockContext : DbContext
    {
        public StockContext() : base(nameOrConnectionString: "Default")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Account> Accounts { get; set; } = null;
    }
}
