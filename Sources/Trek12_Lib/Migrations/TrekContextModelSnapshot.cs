﻿// <auto-generated />
using EntityFrameWorkLib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameWorkLib.Migrations
{
    [DbContext(typeof(TrekContext))]
    partial class TrekContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.2");

            modelBuilder.Entity("EntityFrameWorkLib.PlayerEntity", b =>
                {
                    b.Property<int>("PlayerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxZone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NbPlayed")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NbPoints")
                        .HasColumnType("INTEGER");

                    b.Property<int>("NbWin")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Pseudo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PlayerId");

                    b.ToTable("Players");
                });
#pragma warning restore 612, 618
        }
    }
}
