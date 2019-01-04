using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ElectronicStore.Data.Models
{
    public abstract class Product
    {
        public int Id { get; set; }

        public string Manufacturer { get; set; }

        public string ProductModel { get; set; }

        public string ImageName { get; set; }

        public decimal Price { get; set; }
    }
}
