﻿using BHZ.Models.Habitats;

namespace BHZ.Models.WaterAnimals
{
    public class Plankton : Water
    {
        public string AnimalName { get; set; } = "Plankton";
        public string AnimalDescription { get; set; }
        public int WeightMin { get; set; }
        public int WeightMax { get; set; }
        public bool Extinct { get; set; }
        public override int MaxDepth { get; set; }
    }
}
