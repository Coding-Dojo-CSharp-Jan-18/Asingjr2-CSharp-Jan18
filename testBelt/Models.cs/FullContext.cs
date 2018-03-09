using Microsoft.EntityFrameworkCore;
using System;

namespace testBelt.Models
{
    public class FullContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public FullContext(DbContextOptions<FullContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Game> Games { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<GameCharacter> GameCharacters { get; set; }
    }
}