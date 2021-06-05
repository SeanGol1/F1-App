﻿// <auto-generated />
using F1_App.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace F1_App.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210605184232_Drivers")]
    partial class Drivers
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("F1_App.Models.Driver", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FamilyName");

                    b.Property<string>("GivenName");

                    b.Property<int>("Points");

                    b.Property<int>("StandingsPosition");

                    b.Property<string>("TeamName");

                    b.HasKey("Id");

                    b.ToTable("Driver");
                });

            modelBuilder.Entity("F1_App.Models.UserPredictions", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DriverId");

                    b.Property<int>("Position");

                    b.Property<int>("Round");

                    b.Property<int>("Season");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserPredictions");
                });
#pragma warning restore 612, 618
        }
    }
}
