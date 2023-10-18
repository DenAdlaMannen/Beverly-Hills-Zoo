using BHZ.Models;
using BHZ.Models.AirAnimals;
using BHZ.Models.Habitats;
using BHZ.Models.LandAnimals;
using BHZ.Models.WaterAnimals;
using Microsoft.EntityFrameworkCore;

namespace BHZ.Data
{
    public class BhzDbContext : DbContext
    {
        public BhzDbContext(DbContextOptions<BhzDbContext> options) : base (options)
        {
           
        }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Ant> Ants { get; set; }
        public DbSet<Hedgehog> Hedgehogs { get; set; }
        public DbSet<Dragon> Dragons { get; set; }
        public DbSet<Gargoyle> Gargoyles { get; set; }
        public DbSet<Snake> Snakes { get; set; }
        public DbSet<Crab> Crabs { get; set; }
        public DbSet<Cucumber> Cucumbers { get; set; }
        public DbSet<Plankton> Planktons { get; set; }
        //public DbSet<Air> Air { get; set; }
        //public DbSet<Land> Land { get; set; }
        //public DbSet<Water> Water { get; set; }

    }
}
