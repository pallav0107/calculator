using Microsoft.EntityFrameworkCore;

namespace CalculatorTest.Diagnostics
{
    public class DiagnosticsContext : DbContext
    {
        public DbSet<Models.Diagnostics> Diagnostics { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Constants.ConnectionString);
        }
    }

}
