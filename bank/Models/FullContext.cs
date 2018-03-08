using Microsoft.EntityFrameworkCore;
using System;

namespace bank.Models
{
    public class FullContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public FullContext(DbContextOptions<FullContext> options) : base(options) { }
        public DbSet<User> users { get; set; }
        public DbSet<Account> accounts { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<UserAccount> useraccounts { get; set; }
    }
}