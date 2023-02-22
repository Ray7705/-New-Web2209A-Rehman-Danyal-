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
        public decimal Total { get; }


        private int quantity;
        private const double taxes = .15;

        public Cart()
        {

        }




    }
}
