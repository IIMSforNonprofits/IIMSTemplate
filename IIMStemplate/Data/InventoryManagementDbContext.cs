using IIMStemplate.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IIMStemplate.Data
{
    public class InventoryManagementDbContext : DbContext
    {
        public InventoryManagementDbContext(DbContextOptions<InventoryManagementDbContext> options) : base(options)
        {

        }

        //public DbSet<Product> Products { get; set; }
        //public DbSet<Order> Orders { get; set; }
        //public DbSet<Log> Logs { get; set; }
        //public DbSet<Donor> Donors { get; set; }
    }
}
