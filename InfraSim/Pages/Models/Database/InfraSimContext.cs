using Microsoft.EntityFrameworkCore;

namespace InfraSim.Pages.Models.Database
{
    public class InfraSimContext : DbContext
    {
        public DbSet<DbServer> DbServers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=InfraSim.db");
        }
    }
}
