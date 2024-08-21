using Microsoft.EntityFrameworkCore;
using Rafat.Core;
using Rafat.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rafat.Data.EF
{
    public class DBContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string conString = @"Server=.\SQLEXPRESS;Database=REMSDB;Encrypt=false;Trusted_Connection=True;";
          //  string conString = ConString.ConStringValue;


            optionsBuilder.UseSqlServer(conString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Property>()
                .Property(p => p.Listing)
                .HasConversion<string>();

            modelBuilder.Entity<Property>()
                .Property(p => p.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Property>()
                .Property(p => p.PType)
                .HasConversion<string>();

            modelBuilder.Entity<Order>()
                .Property(o => o.Status)
                .HasConversion<string>();

            modelBuilder.Entity<Order>()
                .Property(o => o.Ordertype)
                .HasConversion<string>();   
                

         

            base.OnModelCreating(modelBuilder);
        }


        // Tables
        public DbSet<Users> Users { get; set; }
        public DbSet<SystemRecords> SystemRecords { get; set; }

        public DbSet<Agent> Agents { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public  DbSet<Order> Orders { get; set; }

        public  DbSet<Property> Properties { get; set; }

        public DbSet<PropertyFile> PropertyFiles { get; set; }



    }
}
