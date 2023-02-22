using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public  class Product
    {
        public Product(string name, int id, decimal price, string imgPath, double discount, string description)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Name must not be null");
            if (string.IsNullOrEmpty(imgPath))
                throw new ArgumentNullException("ImagePath must not be emthy");
            if(id<0)
                throw new ArgumentOutOfRangeException(nameof(id));
            if(price<0)
                throw new ArgumentOutOfRangeException(nameof(price));



            Name = name;
            Id = id;
            Price = price;
            ImgPath = imgPath;
            Discount = discount;
            Description = description;
        }

        public string Name { get;private set; }
        public int Id { get; }
        public decimal Price { get;private set; }

        public string ImgPath { get; private set; }

        public double Discount { get; private set; } = 0;


        public string Description { get; private set; }


    }
}
