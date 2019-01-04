using System;
using System.Collections.Generic;
using System.Text;
using ElectronicStore.Data.Models.Products.Enums;

namespace ElectronicStore.Data.Models.Products
{
    public class Fridge: Product
    {
        public string Dimensions { get; set; }

        public EnergyEfficiencyRating EnergyEfficiencyRating { get; set; }

        public double Capacity { get; set; }
    }
}
