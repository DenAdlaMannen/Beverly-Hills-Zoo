﻿// <auto-generated />
using BHZ.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BHZ.Migrations
{
    [DbContext(typeof(BhzDbContext))]
    partial class BhzDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BHZ.Models.Animal", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("AirAnimalSpecie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Endangered")
                        .HasColumnType("bit");

                    b.Property<string>("HabitatType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LandAnimalSpecie")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecieDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpecieName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SpecieWeightMax")
                        .HasColumnType("int");

                    b.Property<int>("SpecieWeightMin")
                        .HasColumnType("int");

                    b.Property<string>("WaterAnimalSpecie")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("AirAnimalSpecie").HasValue("Animal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BHZ.Models.VisitVisitor.Visitor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Visitors");
                });

            modelBuilder.Entity("BHZ.Models.Habitats.Air", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<int>("MaxAltitude")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Air");
                });

            modelBuilder.Entity("BHZ.Models.Habitats.Land", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Land");
                });

            modelBuilder.Entity("BHZ.Models.Habitats.Sea", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<int>("DivingDepth")
                        .HasColumnType("int");

                    b.Property<string>("SeaAnimalSpecie")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Water");
                });

            modelBuilder.Entity("BHZ.Models.AirAnimals.Dragon", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Air");

                    b.HasDiscriminator().HasValue("Dragon");
                });

            modelBuilder.Entity("BHZ.Models.AirAnimals.Gargoyle", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Air");

                    b.HasDiscriminator().HasValue("Gargoyle");
                });

            modelBuilder.Entity("BHZ.Models.AirAnimals.Penguin", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Air");

                    b.HasDiscriminator().HasValue("Penguin");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Ant", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Land");

                    b.HasDiscriminator().HasValue("Ant");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Hedgehog", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Land");

                    b.HasDiscriminator().HasValue("Hedgehog");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Snake", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Land");

                    b.HasDiscriminator().HasValue("Snake");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Crab", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Sea");

                    b.HasDiscriminator().HasValue("Crab");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Cucumber", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Sea");

                    b.HasDiscriminator().HasValue("Cucumber");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Plankton", b =>
                {
                    b.HasBaseType("BHZ.Models.Habitats.Sea");

                    b.HasDiscriminator().HasValue("Plankton");
                });
#pragma warning restore 612, 618
        }
    }
}
