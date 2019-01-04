using System;
using System.Collections.Generic;
using System.Text;

namespace ElectronicStore.Data.Models.Products
{
    public class TV: Product
    {
        public int ScreenSize { get; set; }

        public string Resolution { get; set; }

        public bool IsSmart { get; set; }
    }
}
