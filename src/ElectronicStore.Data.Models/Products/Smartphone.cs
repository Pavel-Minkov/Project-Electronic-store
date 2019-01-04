using System;
using System.Collections.Generic;
using System.Text;
using ElectronicStore.Data.Models.Products.Enums;

namespace ElectronicStore.Data.Models.Products
{
    public class Smartphone: Product
    {
        public int ScreenSize { get; set; }

        public string Resolution { get; set; }

        public string ScreenType { get; set; }

        public OSType OS { get; set; }

        public double OSVersion { get; set; }

        public string Processor { get; set; }

        public int InternalMemory { get; set; }

        public string MainCamera { get; set; }

        public string SecondaryCamera { get; set; }

        public string Battery { get; set; }
    }
}
