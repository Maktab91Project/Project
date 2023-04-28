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
            optionsBuilder.UseSqlServer("Server=.;Initial Catalog=MaktabProjectDB;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Offer>()
               .HasOne<Order>(o => o.Order)
               .WithMany(p => p.Offers)
               .HasForeignKey(p => p.OrderId)
               .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Comment>()
            //   .HasOne<Expert>(c => c.Expert)
            //   .WithMany(e => e.Comments)
            //   .HasForeignKey(p => p.ExpertId)
            //   .OnDelete(DeleteBehavior.SetNull);

            //modelBuilder.Entity<Expert>()
            //    .HasMany<Comment>(e => e.Comments)
            //    .WithOne(c => c.Expert)
            //    .HasForeignKey(p => p.ExpertId)
            //    .OnDelete(DeleteBehavior.Cascade);

            //modelBuilder.Entity<Customer>()
            //    .HasMany<Comment>(e => e.Comments)
            //    .WithOne(c => c.Customer)
            //    .HasForeignKey(p => p.CustomerId)
            //    .OnDelete(DeleteBehavior.SetNull);



            //modelBuilder.Entity<Comment>()
            //   .HasOne<Customer>(c => c.Customer)
            //   .WithMany(e => e.Comments)
            //   .HasForeignKey(p => p.CustomerId)
            //   .OnDelete(DeleteBehavior.SetNull);
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet <ExpertSubServices> ExpertsSubServices { get; set; }
        public DbSet <MainService> MainServices { get; set; }
        public DbSet <Offer> Offers { get; set; }
        public DbSet <Order> Orders { get; set; }
        public DbSet <SubService> SubServices { get; set; }
        public DbSet <Comment> Comments { get; set; }



    }
}
