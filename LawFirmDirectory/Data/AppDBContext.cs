using Microsoft.EntityFrameworkCore;

namespace LawFirmDirectory.Data
{
    public class AppDBContext : DbContext
    {
        string _connectionString = "data source=Nootbook;initial catalog=LawFirmDB;trusted_connection=true;TrustServerCertificate=True";

        public DbSet<Attorney> Attorneys {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
