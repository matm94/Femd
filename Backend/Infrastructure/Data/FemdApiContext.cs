using FemdAPI.Core.Domains;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FemdAPI.Core.Data
{
    public class FemdApiContext : DbContext
    {
        public DbSet<Adjective> AdjectiveDbSet { get; set; }
        public DbSet<Adverb> AdverbDbSet { get; set; }
        public DbSet<Lecture> LectureDbSet { get; set; }
        public DbSet<Noun> NounDbSet { get; set; }
        public DbSet<PartsOfSpeechBase> PartsOfSpeechBasesDbSet { get; set; }
        public DbSet<PersonalPronoun> PersonalPronounDbSet { get; set; }
        public DbSet<Sentence> SentenceDbSet { get; set; }
        public DbSet<User> UserDbSet { get; set; }
        public DbSet<Verb> VerbDbSet { get; set; }
        public DbSet<WordsDictionary> WordsDictionaryDbSet { get; set; }


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
               .HasForeignKey<WordsDictionary>(fk => fk.LectureId)
               .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PartsOfSpeechBase>()
               .ToTable("PartsOfSpeechDbSet")
               .HasDiscriminator<string>("Parts")
               .HasValue<Adjective>("Adjectives")
               .HasValue<Adverb>("Adverbs")
               .HasValue<Noun>("Nouns")
               .HasValue<Sentence>("Sentences");

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(ad => ad.Adjectives)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(adv => adv.Adverbs)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(non => non.Nouns)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(pp => pp.PersonalPronouns)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(sn => sn.Sentences)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<WordsDictionary>()
                .HasMany(vr => vr.Verbs)
                .WithOne(wd => wd.WordsDictionary)
                .HasForeignKey(fk => fk.WordsDictonaryId)
                .OnDelete(DeleteBehavior.Cascade);



        }

    }
}

