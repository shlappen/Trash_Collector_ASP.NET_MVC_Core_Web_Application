using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TrashCollector.Models;

namespace TrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<CollectionDay> CollectionDays { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentityRole>()
                .HasData(
                new IdentityRole
                {
                    Name = "Customer",
                    NormalizedName = "Customer"
                },
                new IdentityRole
                {
                    Name = "Employee",
                    NormalizedName = "Employee"
                });
                builder.Entity<CollectionDay>()
                .HasData(
                new CollectionDay
                {
                    Id = 1,
                    Day = "Sunday",
                }, new CollectionDay
                {
                    Id = 2,
                    Day = "Monday"
                }, new CollectionDay
                {
                    Id = 3,
                    Day = "Tuesday"
                }, new CollectionDay
                {
                    Id = 4,
                    Day = "Wednesday"
                }, new CollectionDay
                {
                    Id = 5,
                    Day = "Thursday"
                }, new CollectionDay
                {
                    Id = 6,
                    Day = "Friday"
                }, new CollectionDay
                {
                    Id = 7,
                    Day = "Saturday"
                });
        }
    }
}
