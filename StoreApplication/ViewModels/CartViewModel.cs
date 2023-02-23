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
        //public ObservableCollection<Cart> Carts { get; }
        public DelegateCommand PayCommand { get; }

        public CartViewModel(Cart cart)
        {
            //Carts = new ObservableCollection<Cart> { cart };

            
        }

    }
}
