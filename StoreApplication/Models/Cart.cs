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

        public decimal Subtotal { get; }
        public decimal Total
        {
            get
            {
                return (1+taxes) * Subtotal;
            }
            private set
            {
                total= value;
            }
        }


        private int quantity;
        private const decimal taxes = 0.15m;
        private decimal total;

        public Cart(int quantity , decimal subTotal, decimal total)
        {
            Quantity = quantity;
            Subtotal = subTotal;
            Total = total;
        }




    }
}
