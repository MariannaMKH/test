using DTO.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Check> Checks { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<HistoryCheck> HistoryChecks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Check>().ToTable("Check");
            modelBuilder.Entity<Menu>().ToTable("Menu");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Manager>().ToTable("Manager");
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<HistoryCheck>().ToTable("HistoryCheck");
        }

        public void SetValues(object from, object to)
        {
            Entry(to).CurrentValues.SetValues(from);
            //todo implement logic for update version against concurency exceptions
        }

    }
}
