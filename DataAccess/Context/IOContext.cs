using Microsoft.EntityFrameworkCore;
using Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class IOContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-8EHVPE9\\SQLEXPRESS;Database=IOProject;Trusted_Connection=True; Encrypt=False;");
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Category>().HasKey(a => a.Id);
            modelBuilder.Entity<Instructor>().HasKey(a => a.Id);
            modelBuilder.Entity<Course>().HasKey(a => a.Id);

            modelBuilder.Entity<Course>().HasData(
                new Course() { Id = 1, Description = "burası açıklama kısmı", Image = "~/wwwroot/images/default.png", Title="başlık" });


        }
    }
}
