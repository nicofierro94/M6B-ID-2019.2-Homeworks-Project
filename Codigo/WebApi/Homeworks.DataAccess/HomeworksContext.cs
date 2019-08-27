using System;
using Microsoft.EntityFrameworkCore;
using Homeworks.Domain;

namespace Homeworks.DataAccess
{
    public class HomeworksContext : DbContext
    {
        public DbSet<Homework> Homeworks { get; set; }
        public DbSet<Excercise> Excercises { get; set; }
        public DbSet<User> Users { get; set; }
        public HomeworksContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
