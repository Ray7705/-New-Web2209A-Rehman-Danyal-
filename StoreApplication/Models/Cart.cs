using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class Cart
    {
        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                if (quantity >= 0)
                {
                    quantity = value;
                }
            }
        }
        public List<Product> Products;
        private decimal sum;
        public decimal SubTotal
        {
            get
            {
                foreach (var product in Products)
                {
                    sum += product.Price;
                }

                return sum;
            }
        }
        public decimal Total
        {
            get
            {
                return (1 + taxes) * SubTotal;
            }
            private set
            {
                total = value;
            }
        }


        private int quantity;
        private const decimal taxes = 0.15m;
        private decimal total;

        public Cart()
        {
            Quantity = 0;
            Total = 0m;
            Products = new List<Product>()
            {

            };
        }


        public void AddProductToCart(Product inputProduct, String QuantityStr)
        {
            if (int.TryParse(QuantityStr, out quantity))
            {
                for (int i = 0; i < Quantity; i++)
                {
                    Products.Add(inputProduct);
                }
            }


        }

    }
}
