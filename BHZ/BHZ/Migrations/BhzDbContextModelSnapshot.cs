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

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Animals");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Animal");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("BHZ.Models.AirAnimals.Dragon", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAltitude")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Dragon_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Dragon_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Dragon_Extinct");

                            t.Property("MaxAltitude")
                                .HasColumnName("Dragon_MaxAltitude");

                            t.Property("WeightMax")
                                .HasColumnName("Dragon_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Dragon_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Dragon");
                });

            modelBuilder.Entity("BHZ.Models.AirAnimals.Gargoyle", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("MaxAltitude")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Gargoyle");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Ant", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Ant_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Ant_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Ant_Extinct");

                            t.Property("WeightMax")
                                .HasColumnName("Ant_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Ant_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Ant");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Hedgehog", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Hedgehog_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Hedgehog_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Hedgehog_Extinct");

                            t.Property("Speed")
                                .HasColumnName("Hedgehog_Speed");

                            t.Property("WeightMax")
                                .HasColumnName("Hedgehog_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Hedgehog_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Hedgehog");
                });

            modelBuilder.Entity("BHZ.Models.LandAnimals.Snake", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Snake_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Snake_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Snake_Extinct");

                            t.Property("Speed")
                                .HasColumnName("Snake_Speed");

                            t.Property("WeightMax")
                                .HasColumnName("Snake_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Snake_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Snake");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Crab", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("MaxDepth")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Crab_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Crab_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Crab_Extinct");

                            t.Property("WeightMax")
                                .HasColumnName("Crab_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Crab_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Crab");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Cucumber", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("MaxDepth")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Cucumber_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Cucumber_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Cucumber_Extinct");

                            t.Property("MaxDepth")
                                .HasColumnName("Cucumber_MaxDepth");

                            t.Property("WeightMax")
                                .HasColumnName("Cucumber_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Cucumber_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Cucumber");
                });

            modelBuilder.Entity("BHZ.Models.WaterAnimals.Plankton", b =>
                {
                    b.HasBaseType("BHZ.Models.Animal");

                    b.Property<string>("AnimalDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnimalName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Extinct")
                        .HasColumnType("bit");

                    b.Property<int>("MaxDepth")
                        .HasColumnType("int");

                    b.Property<int>("WeightMax")
                        .HasColumnType("int");

                    b.Property<int>("WeightMin")
                        .HasColumnType("int");

                    b.ToTable("Animals", t =>
                        {
                            t.Property("AnimalDescription")
                                .HasColumnName("Plankton_AnimalDescription");

                            t.Property("AnimalName")
                                .HasColumnName("Plankton_AnimalName");

                            t.Property("Extinct")
                                .HasColumnName("Plankton_Extinct");

                            t.Property("MaxDepth")
                                .HasColumnName("Plankton_MaxDepth");

                            t.Property("WeightMax")
                                .HasColumnName("Plankton_WeightMax");

                            t.Property("WeightMin")
                                .HasColumnName("Plankton_WeightMin");
                        });

                    b.HasDiscriminator().HasValue("Plankton");
                });
#pragma warning restore 612, 618
        }
    }
}
