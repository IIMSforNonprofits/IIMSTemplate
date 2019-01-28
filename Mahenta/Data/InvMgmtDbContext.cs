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

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Donor> Donors { get; set; }
    }
}
