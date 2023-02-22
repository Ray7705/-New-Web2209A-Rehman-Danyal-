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
    internal class StoreViewModel
    {

        public string VolleyballImg => "https://upload.wikimedia.org/wikipedia/commons/5/5a/Volleyball_ball.jpg";

        public ObservableCollection<Product> Products { get; }
        public DelegateCommand DisplayProductCommand { get; }

        public StoreViewModel()
        {
            Products = new ObservableCollection<Product>();
            {

            }
            Products.Add(new Product("voll", 100, 22.30m, VolleyballImg, 0, "akwnfawf"));
            Products.Add(new Product("voll", 100, 22.30m, VolleyballImg, 0, "akwnfawf"));
            DisplayProductCommand = new DelegateCommand(DisplayProduct, CanDisplay);

        }
        private void DisplayProduct(object _)
        {
           
            
        }
        
        public Product product;
        public Product SelectedProduct
        {
            get
            {
                return product;
            }
            set
            {
                product = value;
                DisplayProductCommand.NotifyCanExecuteChanged();

            }
        }
        private bool CanDisplay(object _)
        {
            return product != null;
        }

        public string SelectedProductName { get { return SelectedProduct.Name; } }
        public string SelectedProductDescription { get { return SelectedProduct.Description; } }
        public string SelectedProductImgPath { get { return SelectedProduct.ImgPath; } }
       
        public decimal SelectedProductPrice { get { return SelectedProduct.Price; } }
        public double SelectedProductDiscount { get { return SelectedProduct.Discount; } }
    }
}
