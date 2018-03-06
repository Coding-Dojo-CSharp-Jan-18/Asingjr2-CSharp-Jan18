using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace enrollments.Models
{
   
    public class SchoolContext : DbContext
    {
        public SchoolContext(DbContextOptions options) : base (options) 
        { }
        public DbSet<Student> students {get;set;}
        public DbSet<Course> courses {get;set;}
        public DbSet<Enrollment> enrollments {get;set;}

    }
}