using LookForMaster.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Data
{
    public class BookStoreDbContext : DbContext
    {
        private const string connectionString = $"Server=localhost;Database=LookForMasterDb;User Id=admin;Password=admin;TrustServerCertificate=True;";
        public DbSet<User> Users { get; set; }
        public DbSet<Card> Cards { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
