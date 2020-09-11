using Microsoft.EntityFrameworkCore;
using Starter.Models;
namespace Starter.DAO
{
    public class StarterDbContext : DbContext
    {
        public StarterDbContext(DbContextOptions<StarterDbContext> options) : base (options)
        {
        }
        // make and apply migrations
        public DbSet<BandModel> bands{get;set;}
        public DbSet<AlbumModel> albums{get;set;}
    }
}