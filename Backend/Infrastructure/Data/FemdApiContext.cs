using FemdAPI.Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Data
{
    public class FemdApiContext : DbContext
    {
        public DbSet<User> UserDbSet { get; set; }
        public DbSet<Lecture> LectureDbSet { get; set; }
        public DbSet<Verb> VerbDbSet { get; set; }
        public DbSet<Noun> NounDbSet { get; set; }


        private readonly string _connectionString = @"Data Source=MATM94\SQLEXPRESS;Initial Catalog=FemdAPIContext;Integrated Security=True;Pooling=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("FemdAPI.Api"));   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly((typeof(FemdApiContext).Assembly));

            modelBuilder.Entity<Lecture>()
               .HasKey(k => k.Id);
            modelBuilder.Entity<Lecture>()
                .HasMany(v => v.Verbs)
                .WithOne(l => l.Lecture)
                .HasForeignKey(fk => fk.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Lecture>()
                .HasKey(k => k.Id);
            modelBuilder.Entity<Lecture>()
                .HasMany(v => v.Nouns)
                .WithOne(l => l.Lecture)
                .HasForeignKey(fk => fk.LectureId)
                .OnDelete(DeleteBehavior.Cascade);

        }

    }
}

