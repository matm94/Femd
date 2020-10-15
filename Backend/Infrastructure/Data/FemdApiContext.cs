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
        public DbSet<WordsDictionary> WordsDictionaryDbSet { get; set; }
        public DbSet<Verb> VerbDbSet { get; set; }
        public DbSet<Noun> NounDbSet { get; set; }
        public DbSet<Photo> PhotoDbSet { get; set; }


        private readonly string _connectionString = @"Data Source=MATM94\SQLEXPRESS;Initial Catalog=FEMD_API;Integrated Security=True;Pooling=False";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString, b => b.MigrationsAssembly("FemdAPI.Api"));   
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly((typeof(FemdApiContext).Assembly));

            modelBuilder.Entity<Lecture>()
               .HasOne(wd => wd.WordsDictionary)
               .WithOne(lc => lc.Lecture)
               .HasForeignKey<WordsDictionary>(fk => fk.LectureId);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(vr => vr.Verbs)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(non => non.Nouns)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Verb>()
                .HasOne(ph => ph.Photo)
                .WithOne(vr => vr.Verb)
                .HasForeignKey<Photo>(fk => fk.VerbId);

            modelBuilder.Entity<Noun>()
                .HasOne(ph => ph.Photo)
                .WithOne(non => non.Noun)
                .HasForeignKey<Photo>(fk => fk.NounId);

        }

    }
}

