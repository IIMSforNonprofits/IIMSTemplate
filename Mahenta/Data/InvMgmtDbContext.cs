using Mahenta.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mahenta.Data
{
    public class InvMgmtDbContext : DbContext
    {
        public InvMgmtDbContext(DbContextOptions<InvMgmtDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region SeedData_Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ID = 1,
                    DonorID = 1,
                    Sku = "PROD001",
                    Name = "Crunch Bar",
                    Description = "It's crumptious, when it crunches"
                },
                new Product
                {
                    ID = 2,
                    DonorID = 2,
                    Sku = "PROD002",
                    Name = "Mars bar",
                    Description = "It's out of this woooooorld"
                },
                new Product
                {
                    ID = 3,
                    DonorID = 3,
                    Sku = "PROD003",
                    Name = "M&Ms",
                    Description = "Guess whose back...wait wrong kind of wrapper"
                },
                new Product
                {
                    ID = 4,
                    DonorID = 4,
                    Sku = "PROD004",
                    Name = "Skittles",
                    Description = "M&Ms without chocolate"
                },
                new Product
                {
                    ID = 5,
                    DonorID = 5,
                    Sku = "PROD005",
                    Name = "Twix",
                    Description = "Left, left, right, right..."
                },
                new Product
                {
                    ID = 6,
                    DonorID = 6,
                    Sku = "PROD006",
                    Name = "Pocky",
                    Description = "Pokey"
                },
                new Product
                {
                    ID = 7,
                    DonorID = 7,
                    Sku = "PROD007",
                    Name = "100 Grand",
                    Description = "ha, I wish"
                });
            #endregion

            #region SeedData_Donors
            modelBuilder.Entity<Donor>().HasData(
                new Donor
                {
                    ID = 1,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 2,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 3,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 4,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 5,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 6,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                },
                new Donor
                {
                    ID = 7,
                    Email = "email1@gmail.com",
                    DonorName = "Jon Doe",
                    PhoneNumber = "1234567890"
                });
            #endregion
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Donor> Donors { get; set; }
    }
}
