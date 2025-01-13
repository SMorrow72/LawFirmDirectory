using Microsoft.EntityFrameworkCore;

namespace LawFirmDirectory.Data
{
    public class AppDBContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DbSet<Attorney> Attorneys { get; set; }

        public AppDBContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
        }
        public async Task<List<Attorney>> GetAllAttorneys()
        {
            return await Attorneys.AsNoTracking().ToListAsync();
        }
    }
}
