using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.Models
{
    public class Cart
    {
        public ObservableCollection<Product> Products { get; }
        private decimal sum;
        public decimal SubTotal
        {
            get
            {
                foreach (var product in ProductsInCard)
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

        }
        public ObservableCollection<Product> ProductsInCard { get; }

        private const decimal taxes = 0.15m;
        public string VolleyballImg => "https://upload.wikimedia.org/wikipedia/commons/5/5a/Volleyball_ball.jpg";

        public Cart()
        {
            Products = new ObservableCollection<Product>();
            ProductsInCard = new ObservableCollection<Product>();


            //to do :delete
            ProductsInCard.Add(new Product("vollavlmaev", 100, 22.30m, VolleyballImg, 0, "akwnfawf"));
            Products.Add(new Product("vollavlmaev", 100, 22.30m, VolleyballImg, 0, "akwnfawf"));
        }


        public void AddProductToCart(Product inputProduct, int quantity)
        {
           for(int i = 0; i < quantity; i++)
            ProductsInCard.Add(inputProduct);

        }

    }
}
