using Microsoft.EntityFrameworkCore;
using VideoGamesManager.DataLayer.Entities;

namespace VideoGamesManager.DataLayer.DBContext
{
    public class VideoGamesManagementDBContext : DbContext
    {
        public VideoGamesManagementDBContext() { }
        public DbSet<VideoGame> VideoGames { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Set your own connection string
            optionsBuilder.UseSqlServer("Data Source=.\\SQLEXPRESS;Initial Catalog=VideoGamesManagement;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}