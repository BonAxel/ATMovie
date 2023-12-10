﻿// <auto-generated />
using System;
using ATMovie.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ATMovie.Migrations
{
    [DbContext(typeof(ATMovieContext))]
    partial class ATMovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ATMovie.Models.Booking", b =>
                {
                    b.Property<int>("BookingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookingID"));

                    b.Property<string>("Epost")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kundnamn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<int?>("SeatId")
                        .HasColumnType("int");

                    b.Property<int?>("ShowID")
                        .HasColumnType("int");

                    b.HasKey("BookingID");

                    b.HasIndex("SalonID");

                    b.HasIndex("SeatId");

                    b.HasIndex("ShowID");

                    b.ToTable("Booking");
                });

            modelBuilder.Entity("ATMovie.Models.Movie", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MovieID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MovieImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<string>("Runtime")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MovieID");

                    b.ToTable("Movie");
                });

            modelBuilder.Entity("ATMovie.Models.Row", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Row");
                });

            modelBuilder.Entity("ATMovie.Models.RowSeat", b =>
                {
                    b.Property<int>("RowSeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RowSeatId"));

                    b.Property<int>("RowID")
                        .HasColumnType("int");

                    b.Property<int>("SeatID")
                        .HasColumnType("int");

                    b.HasKey("RowSeatId");

                    b.HasIndex("RowID");

                    b.HasIndex("SeatID");

                    b.ToTable("Junctions");
                });

            modelBuilder.Entity("ATMovie.Models.Salon", b =>
                {
                    b.Property<int>("SalonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalonID"));

                    b.Property<int>("NumberOfChairs")
                        .HasColumnType("int");

                    b.Property<string>("SalonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalonID");

                    b.ToTable("Salon");
                });

            modelBuilder.Entity("ATMovie.Models.SalonRows", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RowID")
                        .HasColumnType("int");

                    b.Property<int>("SalonID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RowID");

                    b.HasIndex("SalonID");

                    b.ToTable("SalonRows");
                });

            modelBuilder.Entity("ATMovie.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<bool>("IsBooked")
                        .HasColumnType("bit");

                    b.HasKey("SeatId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("ATMovie.Models.Show", b =>
                {
                    b.Property<int>("ShowID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ShowID"));

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShowID");

                    b.HasIndex("MovieID");

                    b.HasIndex("SalonID");

                    b.ToTable("Show");
                });

            modelBuilder.Entity("ATMovie.Models.Booking", b =>
                {
                    b.HasOne("ATMovie.Models.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonID");

                    b.HasOne("ATMovie.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId");

                    b.HasOne("ATMovie.Models.Show", "Show")
                        .WithMany()
                        .HasForeignKey("ShowID");

                    b.Navigation("Salon");

                    b.Navigation("Seat");

                    b.Navigation("Show");
                });

            modelBuilder.Entity("ATMovie.Models.RowSeat", b =>
                {
                    b.HasOne("ATMovie.Models.Row", "Row")
                        .WithMany("Seats")
                        .HasForeignKey("RowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATMovie.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Row");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("ATMovie.Models.SalonRows", b =>
                {
                    b.HasOne("ATMovie.Models.Row", "Row")
                        .WithMany()
                        .HasForeignKey("RowID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ATMovie.Models.Salon", "Salon")
                        .WithMany("SalonRows")
                        .HasForeignKey("SalonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Row");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("ATMovie.Models.Show", b =>
                {
                    b.HasOne("ATMovie.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieID");

                    b.HasOne("ATMovie.Models.Salon", "Salon")
                        .WithMany()
                        .HasForeignKey("SalonID");

                    b.Navigation("Movie");

                    b.Navigation("Salon");
                });

            modelBuilder.Entity("ATMovie.Models.Row", b =>
                {
                    b.Navigation("Seats");
                });

            modelBuilder.Entity("ATMovie.Models.Salon", b =>
                {
                    b.Navigation("SalonRows");
                });
#pragma warning restore 612, 618
        }
    }
}
