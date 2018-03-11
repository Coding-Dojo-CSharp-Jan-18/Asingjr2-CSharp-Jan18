using Microsoft.EntityFrameworkCore;
using System;
namespace album.Models
{
    public class FullContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public FullContext(DbContextOptions<FullContext> options) : base(options) { }
        public DbSet<Artist> artists { get; set; }
        public DbSet<Album> albums { get; set; }
    }
}