using Chevalier.Utility.Commands;
using StoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.ViewModels
{
    public class CartViewModel
    {
        public ObservableCollection<Product> ProductsInCart { get; }
        public DelegateCommand PayCommand { get; }
        public Cart SelectedProduct { get; set; }

        public CartViewModel(Cart cart)
        {
            //Carts = new ObservableCollection<Cart> { cart };
            PayCommand = new DelegateCommand(Pay);

        }

        private void Pay(object _)
        {

        }

        public void AddProductsToCart()
        {

        }

        private void DisplayProduct(object _)
        {
            if( SelectedProduct != null)
            {

            }
        }

    }
}
