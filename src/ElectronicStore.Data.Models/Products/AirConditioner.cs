using System;
using System.Collections.Generic;
using System.Text;
using ElectronicStore.Data.Models.Products.Enums;

namespace ElectronicStore.Data.Models.Products
{
    public class AirConditioner: Product
    {
        public EnergyEfficiencyRating EnergyEfficiencyRating { get; set; }

        public double PowerConsumptionHeating { get; set; }

        public double PowerConsumptionCooling { get; set; }

        public string TemperatureAmplitude { get; set; }

        public string Dimensions { get; set; }
    }
}
