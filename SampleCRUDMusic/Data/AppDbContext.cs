using Microsoft.EntityFrameworkCore;
using SampleCRUDMusic.Models.Entities;


namespace SampleCRUDMusic.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=MICHAELRHEY\\SQLEXPRESS;Database=SampleCRUDMusicDB;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
    }
}
