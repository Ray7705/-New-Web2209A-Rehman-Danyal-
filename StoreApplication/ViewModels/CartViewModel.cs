using Chevalier.Utility.Commands;
using Chevalier.Utility.ViewModels;
using StoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApplication.ViewModels
{
    public class CartViewModel : ViewModel, INotifyPropertyChanged
    {
        public DelegateCommand PayCommand { get; }
        public Cart Cart { get; private set; }

        public CartViewModel(Cart cart)
        {

            Cart = cart;
            NotifyPropertyChanged(nameof(cart));
        }
      
    }
}

