using AppCore.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataBase
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> optionBuilder) : base(optionBuilder)
        //{

        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=MaktabProject;Integrated Security=True;TrustServerCertificate=True");
        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<MainService> MainServices { get; set; }
        public DbSet<PersonSubServices> PersonsSubServices { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SubService> SubServices { get; set; }
        public DbSet <PersonRoles> PersonsRoles { get; set; }
    }
}
