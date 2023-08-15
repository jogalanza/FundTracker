using Microsoft.EntityFrameworkCore;
using WebApp.Model;

namespace WebApp.API.Helpers
{
    public class DataContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public DataContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("FundTrackerDB"));
        }

        public DbSet<Account> Accounts { get; set; }
    }
}
