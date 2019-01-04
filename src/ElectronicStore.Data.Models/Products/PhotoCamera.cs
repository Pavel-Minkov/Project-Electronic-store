using System;
using System.Collections.Generic;
using System.Text;
using ElectronicStore.Data.Models.Products.Enums;

namespace ElectronicStore.Data.Models.Products
{
    public class PhotoCamera: Product
    {
        public PhotoType PhotoType { get; set; }

        public string SensorDescription { get; set; }
    }
}
