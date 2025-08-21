using Microsoft.EntityFrameworkCore;
using NZWalksNew.Models.Domain;

namespace NZWalksNew.Data
{
    public class NZWalksDBContext:DbContext
    {
        public NZWalksDBContext(DbContextOptions<NZWalksDBContext> options ) : base(options)
        {
                
        }

        public DbSet<Region> regions { get; set; }
        public DbSet<Walk> walks { get; set; }
        public DbSet<WalkDifficulty> walkDifficulties { get; set; }
    }
}
