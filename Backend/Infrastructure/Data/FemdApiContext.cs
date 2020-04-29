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
        public DbSet<Lecture> LectureDbSet { get; set; }
        public DbSet<Verb> VerbDbSet { get; set; }


        private readonly string _connectionString = @"Data Source=MATM94\SQLEXPRESS;Initial Catalog=FemdAPIContext;Integrated Security=True;Pooling=False";

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

            modelBuilder.Entity<Lecture>()
               .HasKey(k => k.Id);
            modelBuilder.Entity<Lecture>()
                .HasMany<Verb>(v => v.Verbs)
                .WithOne(l => l.Lecture)
                .HasForeignKey(fk => fk.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Lecture>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<Lecture>()
                .HasMany<Noun>(v => v.Nouns)
                .WithOne(l => l.Lecture)
                .HasForeignKey(fk => fk.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}

