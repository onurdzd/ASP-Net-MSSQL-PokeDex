﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PokeReviewApp.Data;

#nullable disable

namespace PokeReviewApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PokeReviewApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Country", b =>
                {
                    b.Property<int>("CountryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CountryId"));

                    b.Property<string>("CountryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryId");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Owner", b =>
                {
                    b.Property<int>("OwnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OwnerId"));

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("OwnerGym")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OwnerId");

                    b.HasIndex("CountryId");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Poke", b =>
                {
                    b.Property<int>("PokeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PokeId"));

                    b.Property<DateTime>("PokeBDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("PokeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PokeId");

                    b.ToTable("Pokes");
                });

            modelBuilder.Entity("PokeReviewApp.Models.PokeCategory", b =>
                {
                    b.Property<int>("PokeId")
                        .HasColumnType("int");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("PokeId", "CategoryId");

                    b.HasIndex("CategoryId");

                    b.ToTable("PokeCategories");
                });

            modelBuilder.Entity("PokeReviewApp.Models.PokeOwner", b =>
                {
                    b.Property<int>("PokeId")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("PokeId", "OwnerId");

                    b.HasIndex("OwnerId");

                    b.ToTable("PokeOwners");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Review", b =>
                {
                    b.Property<int>("ReviewId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewId"));

                    b.Property<int>("PokeId")
                        .HasColumnType("int");

                    b.Property<int>("ReviewRate")
                        .HasColumnType("int");

                    b.Property<string>("ReviewText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ReviewerId")
                        .HasColumnType("int");

                    b.HasKey("ReviewId");

                    b.HasIndex("PokeId");

                    b.HasIndex("ReviewerId");

                    b.ToTable("Reviews");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Reviewer", b =>
                {
                    b.Property<int>("ReviewerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReviewerId"));

                    b.Property<string>("ReviewerLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReviewerId");

                    b.ToTable("Reviewers");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Owner", b =>
                {
                    b.HasOne("PokeReviewApp.Models.Country", "Country")
                        .WithMany("Owners")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("PokeReviewApp.Models.PokeCategory", b =>
                {
                    b.HasOne("PokeReviewApp.Models.Category", "Category")
                        .WithMany("PokeCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeReviewApp.Models.Poke", "Poke")
                        .WithMany("PokeCategories")
                        .HasForeignKey("PokeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Poke");
                });

            modelBuilder.Entity("PokeReviewApp.Models.PokeOwner", b =>
                {
                    b.HasOne("PokeReviewApp.Models.Owner", "Owner")
                        .WithMany("PokeOwners")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeReviewApp.Models.Poke", "Poke")
                        .WithMany("PokeOwners")
                        .HasForeignKey("PokeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Poke");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Review", b =>
                {
                    b.HasOne("PokeReviewApp.Models.Poke", "Poke")
                        .WithMany("Reviews")
                        .HasForeignKey("PokeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PokeReviewApp.Models.Reviewer", "Reviewer")
                        .WithMany("Reviews")
                        .HasForeignKey("ReviewerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Poke");

                    b.Navigation("Reviewer");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Category", b =>
                {
                    b.Navigation("PokeCategories");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Country", b =>
                {
                    b.Navigation("Owners");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Owner", b =>
                {
                    b.Navigation("PokeOwners");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Poke", b =>
                {
                    b.Navigation("PokeCategories");

                    b.Navigation("PokeOwners");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PokeReviewApp.Models.Reviewer", b =>
                {
                    b.Navigation("Reviews");
                });
#pragma warning restore 612, 618
        }
    }
}