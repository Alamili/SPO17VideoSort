using Microsoft.EntityFrameworkCore;
using SPO17VideoSort.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPO17VideoSort.Data
{
    public class VideoDbContext : DbContext
    {
        public DbSet<Video> Videos { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public VideoDbContext(DbContextOptions<VideoDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
