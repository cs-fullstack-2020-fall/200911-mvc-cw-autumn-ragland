﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Starter.DAO;

namespace Starter.Migrations
{
    [DbContext(typeof(StarterDbContext))]
    partial class StarterDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("Starter.Models.AlbumModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BandModelid")
                        .HasColumnType("INTEGER");

                    b.Property<int>("bandID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int>("yearReleased")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("BandModelid");

                    b.ToTable("albums");
                });

            modelBuilder.Entity("Starter.Models.BandModel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("bandName")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("contactEmail")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isActive")
                        .HasColumnType("INTEGER");

                    b.Property<int>("yearFormed")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("bands");
                });

            modelBuilder.Entity("Starter.Models.AlbumModel", b =>
                {
                    b.HasOne("Starter.Models.BandModel", null)
                        .WithMany("albums")
                        .HasForeignKey("BandModelid");
                });
#pragma warning restore 612, 618
        }
    }
}
