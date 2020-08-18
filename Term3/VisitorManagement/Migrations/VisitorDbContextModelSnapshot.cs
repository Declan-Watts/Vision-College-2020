﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using VisitorManagement.Data;

namespace VisitorManagement.Migrations
{
    [DbContext(typeof(VisitorDbContext))]
    partial class VisitorDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("VisitorManagement.Models.StaffNames", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("department")
                        .HasColumnType("TEXT");

                    b.Property<string>("name")
                        .HasColumnType("TEXT");

                    b.Property<int>("visitorCount")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.ToTable("StaffNames");
                });

            modelBuilder.Entity("VisitorManagement.Models.Visitors", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StaffNamesid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("business")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateIn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("dateOut")
                        .HasColumnType("TEXT");

                    b.Property<string>("firstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("lastName")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("StaffNamesid");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("VisitorManagement.Models.Visitors", b =>
                {
                    b.HasOne("VisitorManagement.Models.StaffNames", "StaffNames")
                        .WithMany()
                        .HasForeignKey("StaffNamesid");
                });
#pragma warning restore 612, 618
        }
    }
}