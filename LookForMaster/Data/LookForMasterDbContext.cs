using LookForMaster.Models;
using LookForMaster.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class LookForMasterDbContext : DbContext
    {
        private const string connectionString = $"Server=localhost;Database=LookForMasterDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
        public DbSet<Card> Cards { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Master> Masters { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<MasterCategory> MasterCategories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
