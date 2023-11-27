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

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                            Genre = "Fantasy",
                            Price = 120,
                            Runtime = "2h32m",
                            Title = "Lord of the Rings"
                        },
                        new
                        {
                            MovieID = 2,
                            Description = "A family in 1630s New England is torn apart by the forces of witchcraft, black magic and possession.",
                            Genre = "Horror",
                            Price = 120,
                            Runtime = "1h32m",
                            Title = "The Witch"
                        });
                });

            modelBuilder.Entity("ATMovie.Models.Row", b =>
                {
                    b.Property<int>("RowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RowId"));

                    b.Property<int>("RowNumber")
                        .HasColumnType("int");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.HasKey("RowId");

                    b.HasIndex("SalonId");

                    b.ToTable("Row");

                    b.HasData(
                        new
                        {
                            RowId = 1,
                            RowNumber = 1,
                            SalonId = 1
                        });
                });

            modelBuilder.Entity("ATMovie.Models.Salon", b =>
                {
                    b.Property<int>("SalonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalonID"));

                    b.Property<int>("NumberOfChairs")
                        .HasColumnType("int");

                    b.Property<int?>("RowId")
                        .HasColumnType("int");

                    b.Property<string>("SalonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalonID");

                    b.ToTable("Salon");

                    b.HasData(
                        new
                        {
                            SalonID = 1,
                            NumberOfChairs = 300,
                            SalonName = "Tobias Hembio"
                        });
                });

            modelBuilder.Entity("ATMovie.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatId"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("RowId")
                        .HasColumnType("int");

                    b.Property<int>("SalonId")
                        .HasColumnType("int");

                    b.Property<int>("SeatNumber")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatId");

                    b.HasIndex("RowId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("ATMovie.Models.Show", b =>
                {
                    b.Property<string>("ShowID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MovieID")
                        .HasColumnType("int");

                    b.Property<int>("MyProperty")
                        .HasColumnType("int");

                    b.Property<int?>("SalonID")
                        .HasColumnType("int");

                    b.Property<DateTime>("ShowDateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ShowID");

                    b.HasIndex("MovieID");

                    b.HasIndex("SalonID");

                    b.ToTable("Show");

                    b.HasData(
                        new
                        {
                            ShowID = "S1",
                            MovieID = 1,
                            MyProperty = 0,
                            SalonID = 1,
                            ShowDateTime = new DateTime(2023, 11, 26, 22, 56, 19, 405, DateTimeKind.Local).AddTicks(8882)
                        });
                });

            modelBuilder.Entity("ATMovie.Models.Row", b =>
                {
                    b.HasOne("ATMovie.Models.Salon", null)
                        .WithMany("Rows")
                        .HasForeignKey("SalonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ATMovie.Models.Seat", b =>
                {
                    b.HasOne("ATMovie.Models.Row", null)
                        .WithMany("Seats")
                        .HasForeignKey("RowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
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
                    b.Navigation("Rows");
                });
#pragma warning restore 612, 618
        }
    }
}
