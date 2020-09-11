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
        DbSet<BandModel> bands{get;set;}
        DbSet<AlbumModel> albums{get;set;}
    }
}