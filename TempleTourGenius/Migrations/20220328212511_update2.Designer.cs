﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TempleTourGenius.Models;

namespace TempleTourGenius.Migrations
{
    [DbContext(typeof(SignupDBContext))]
    [Migration("20220328212511_update2")]
    partial class update2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.23");

            modelBuilder.Entity("TempleTourGenius.Models.Timeslots", b =>
                {
                    b.Property<int>("TimeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Available")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Time")
                        .HasColumnType("TEXT");

                    b.HasKey("TimeId");

                    b.ToTable("Timeslots");

                    b.HasData(
                        new
                        {
                            TimeId = 1,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 2,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 3,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 4,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 5,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 6,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 7,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 8,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 9,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 10,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 11,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 12,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 13,
                            Available = true,
                            Time = new DateTime(2022, 3, 28, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 14,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 15,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 16,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 17,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 18,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 19,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 20,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 21,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 22,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 23,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 24,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 25,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 26,
                            Available = true,
                            Time = new DateTime(2022, 3, 29, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 27,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 28,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 29,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 30,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 31,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 32,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 33,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 34,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 35,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 36,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 37,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 38,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 39,
                            Available = true,
                            Time = new DateTime(2022, 3, 30, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 40,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 41,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 42,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 43,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 44,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 45,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 46,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 47,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 48,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 49,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 50,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 51,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 52,
                            Available = true,
                            Time = new DateTime(2022, 3, 31, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 53,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 54,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 55,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 56,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 57,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 58,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 59,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 60,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 61,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 62,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 63,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 64,
                            Available = true,
                            Time = new DateTime(2022, 4, 1, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 65,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 66,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 67,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 68,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 69,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 70,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 71,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 72,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 73,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 74,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 75,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 76,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 77,
                            Available = true,
                            Time = new DateTime(2022, 4, 2, 20, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 78,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 8, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 79,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 9, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 80,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 10, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 81,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 11, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 82,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 12, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 83,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 13, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 84,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 14, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 85,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 15, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 86,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 16, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 87,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 17, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 88,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 18, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 89,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 19, 0, 0, 0, DateTimeKind.Local)
                        },
                        new
                        {
                            TimeId = 90,
                            Available = true,
                            Time = new DateTime(2022, 4, 3, 20, 0, 0, 0, DateTimeKind.Local)
                        });
                });

            modelBuilder.Entity("TempleTourGenius.Models.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Phone")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TimeId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("TimeSlotTimeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TourId");

                    b.HasIndex("TimeSlotTimeId");

                    b.ToTable("TourInfo");

                    b.HasData(
                        new
                        {
                            TourId = 1,
                            Email = "testnderson@test.com",
                            GroupName = "Andersons",
                            GroupSize = 5,
                            Phone = 8015551234L,
                            TimeId = 1
                        });
                });

            modelBuilder.Entity("TempleTourGenius.Models.Tour", b =>
                {
                    b.HasOne("TempleTourGenius.Models.Timeslots", "TimeSlot")
                        .WithMany()
                        .HasForeignKey("TimeSlotTimeId");
                });
#pragma warning restore 612, 618
        }
    }
}
