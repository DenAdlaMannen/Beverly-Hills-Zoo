﻿using BHZ.Models.Habitats;

namespace BHZ.Models.LandAnimals
{
    public class Hedgehog : Land
    {
        public string Name { get; set; } = "Hedgehog";
        public string Description { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
    }
}
