using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uApply.Data.Models;
using uApply.Data.Models.Education;
using uApply.Data.Models.Location;


namespace uApply.DAL
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<Learner> Learners { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<SchoolLevel> SchoolLevels { get; set; }
        public DbSet<Town> Towns { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Gender> Genders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Province>().HasData(new Province()
            {
                Id = 1,
                Name = "Free State"
            });

            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 1,
                Name = "Mangaung",
                ProvinceId = 1
            });
            
            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 2,
                Name = "Lejweleputswa",
                ProvinceId = 1
            });
            
            modelBuilder.Entity<District>().HasData(new District()
            {
                Id = 3,
                Name = "Xhariep",
                ProvinceId = 1
            });

        }
    }
}
