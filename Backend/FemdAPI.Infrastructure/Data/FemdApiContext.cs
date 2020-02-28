using FemdAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Data
{
    public class FemdApiContext : DbContext
    {
        public DbSet<User> UserDbSet { get; set; }
        public DbSet<Student> StudentDbSet { get; set; }
        

        private readonly string _connectionString = @"Data Source=MATM94\SQLEXPRESS;Initial Catalog=FemdApi;Integrated Security=True;Pooling=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("FemdAPI.Api"));   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly((typeof(FemdApiContext).Assembly));

            modelBuilder.Entity<User>()
                .HasKey(k => k.Id);
                
            modelBuilder.Entity<User>()
                .HasOne<Student>(s => s.Student)
                .WithOne(u => u.User)
                .HasForeignKey<Student>(fk => fk.UserId)
                .OnDelete(DeleteBehavior.Cascade);


        }

    }
}

