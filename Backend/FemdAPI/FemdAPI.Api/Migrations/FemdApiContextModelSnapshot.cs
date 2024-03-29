﻿// <auto-generated />
using System;
using FemdAPI.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FemdAPI.Api.Migrations
{
    [DbContext(typeof(FemdApiContext))]
    partial class FemdApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FemdAPI.Core.Domains.Lecture", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PhotoPath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LectureDbSet");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.PartsOfSpeechBase", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Parts")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WordsDictonaryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PartsOfSpeechDbSet");

                    b.HasDiscriminator<string>("Parts").HasValue("PartsOfSpeechBase");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.PersonalPronoun", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FirstPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPerson")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThirdPersonPlural")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WordsDictonaryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WordsDictonaryId");

                    b.ToTable("PersonalPronounDbSet");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UserDbSet");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Verb", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConjugationDu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationEr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationIch")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationIhr")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationSie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationTense")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConjugationWir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Conjugation_sie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Infinitive")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Translation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("WordsDictonaryId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("WordsDictonaryId");

                    b.ToTable("VerbDbSet");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.WordsDictionary", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("LectureId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("LectureId")
                        .IsUnique();

                    b.ToTable("WordsDictionaryDbSet");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Adjective", b =>
                {
                    b.HasBaseType("FemdAPI.Core.Domains.PartsOfSpeechBase");

                    b.HasIndex("WordsDictonaryId");

                    b.HasDiscriminator().HasValue("Adjectives");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Adverb", b =>
                {
                    b.HasBaseType("FemdAPI.Core.Domains.PartsOfSpeechBase");

                    b.HasIndex("WordsDictonaryId")
                        .HasName("IX_PartsOfSpeechDbSet_WordsDictonaryId1");

                    b.HasDiscriminator().HasValue("Adverbs");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Noun", b =>
                {
                    b.HasBaseType("FemdAPI.Core.Domains.PartsOfSpeechBase");

                    b.HasIndex("WordsDictonaryId")
                        .HasName("IX_PartsOfSpeechDbSet_WordsDictonaryId2");

                    b.HasDiscriminator().HasValue("Nouns");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Sentence", b =>
                {
                    b.HasBaseType("FemdAPI.Core.Domains.PartsOfSpeechBase");

                    b.HasIndex("WordsDictonaryId")
                        .HasName("IX_PartsOfSpeechDbSet_WordsDictonaryId3");

                    b.HasDiscriminator().HasValue("Sentences");
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.PersonalPronoun", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("PersonalPronouns")
                        .HasForeignKey("WordsDictonaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Verb", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("Verbs")
                        .HasForeignKey("WordsDictonaryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.WordsDictionary", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.Lecture", "Lecture")
                        .WithOne("WordsDictionary")
                        .HasForeignKey("FemdAPI.Core.Domains.WordsDictionary", "LectureId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Adjective", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("Adjectives")
                        .HasForeignKey("WordsDictonaryId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Adverb", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("Adverbs")
                        .HasForeignKey("WordsDictonaryId")
                        .HasConstraintName("FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId1")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Noun", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("Nouns")
                        .HasForeignKey("WordsDictonaryId")
                        .HasConstraintName("FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId2")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("FemdAPI.Core.Domains.Sentence", b =>
                {
                    b.HasOne("FemdAPI.Core.Domains.WordsDictionary", "WordsDictionary")
                        .WithMany("Sentences")
                        .HasForeignKey("WordsDictonaryId")
                        .HasConstraintName("FK_PartsOfSpeechDbSet_WordsDictionaryDbSet_WordsDictonaryId3")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
