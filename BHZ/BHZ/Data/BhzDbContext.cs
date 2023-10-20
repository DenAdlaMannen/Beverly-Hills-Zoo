using BHZ.Models;
using BHZ.Models.AirAnimals;
using BHZ.Models.Habitats;
using BHZ.Models.LandAnimals;
using BHZ.Models.WaterAnimals;
using BHZ.Models.VisitVisitor;
using Microsoft.EntityFrameworkCore;

namespace BHZ.Data
{
    public class BhzDbContext : DbContext
    {
        public BhzDbContext(DbContextOptions<BhzDbContext> options) : base (options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasDiscriminator<string>("HabitatType")
                .HasValue<Land>("Land")
                .HasValue<Air>("Air")
                .HasValue<Sea>("Water");

            modelBuilder.Entity<Land>()
                .HasDiscriminator<string>("LandAnimalSpecie")
                .HasValue<Ant>("Ant")
                .HasValue<Hedgehog>("Hedgehog")
                .HasValue<Snake>("Snake");

            modelBuilder.Entity<Sea>()
             .HasDiscriminator<string>("WaterAnimalSpecie")
             .HasValue<Crab>("Crab")
             .HasValue<Cucumber>("Cucumber")
             .HasValue<Plankton>("Plankton");

            modelBuilder.Entity<Air>()
                .HasDiscriminator<string>("AirAnimalSpecie")
                .HasValue<Dragon>("Dragon")
                .HasValue<Gargoyle>("Gargoyle")
                .HasValue<Penguin>("Penguin");

            //base.OnModelCreating(modelBuilder);
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Animal>()
        //        .HasDiscriminator<int>("HabitatId")
        //        .HasValue<Water>(1);
        //    modelBuilder.Entity<Water>()
        //        .HasDiscriminator<string>("WaterAnimal")
        //        .HasValue<Crab>("Crab");
        //}

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Ant> Ants { get; set; }
        public DbSet<Hedgehog> Hedgehogs { get; set; }
        public DbSet<Dragon> Dragons { get; set; }
        public DbSet<Gargoyle> Gargoyles { get; set; }
        public DbSet<Snake> Snakes { get; set; }
        public DbSet<Crab> Crabs { get; set; }
        public DbSet<Cucumber> Cucumbers { get; set; }
        public DbSet<Plankton> Planktons { get; set; }
        public DbSet<Air> Air { get; set; }
        public DbSet<Land> Land { get; set; }
        public DbSet<Sea> Sea { get; set; }
        public DbSet<Visitor> Visitors { get; set; }
        //public DbSet<Water> Water { get; set; }


    }
}
