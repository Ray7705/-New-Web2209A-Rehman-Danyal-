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
    public delegate void DisplayProductDelegate();
    public class StoreViewModel : ViewModel, INotifyPropertyChanged
    {

        public DelegateCommand AddToCartCommand { get; }
        public Cart Cart { get; }

        private Product selectedProduct;
        public Product SelectedProduct
        {
            get
            {
                return selectedProduct;
            }
            set
            {
                selectedProduct = value;
                NotifyPropertyChanged(nameof(SelectedProduct));
                

            }
        }
        private void AddToCart(object _)
        {
            if (SelectedProduct != null && Quantity > 0)
                Cart.AddProductToCart(SelectedProduct, Quantity);

        }
        public int Quantity { get; private set; }
        public string QuantityStr
        {
            get
            {
                return Quantity.ToString();
            }
            
            set
            {
                if(int.TryParse(value,out int result))
                {
                    Quantity = result;
                    NotifyPropertyChanged(nameof(Quantity));
                    NotifyPropertyChanged(nameof(QuantityStr));
                }
            }
        }

        public DelegateCommand PayCommand { get; }

        public StoreViewModel(Cart cart)
        {
            Cart = cart;
            AddToCartCommand = new DelegateCommand(AddToCart);
            PayCommand = new DelegateCommand(Pay);
        }

        private void Pay(object _)
        {
            //TODO

        }

        
        //public string SelectedProductName { get { return SelectedProduct.Name; } }
        //public string SelectedProductDescription { get { return SelectedProduct.Description; } }
        ////public string SelectedProductImgPath { get { return SelectedProduct.ImgPath; } }

        //public decimal SelectedProductPrice { get { return SelectedProduct.Price; } }
        //public double SelectedProductDiscount { get { return SelectedProduct.Discount; } }
    }
}
