using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static CodeFirst.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class SampleContext : DbContext
    {
        public SampleContext() : base("MyShop")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
               .Property(c => c.LastName).IsRequired().HasMaxLength(30);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<VipOrder> VipOrders { get; set; }
    }
}
