using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    internal class Product
    {
        public string? Name { get;private set; }
        public int Id { get; }
        public decimal Price { get;private set; }

        public string? ImgPath { get; private set; }

        public double Discount { get; private set; } = 0;





    }
}
