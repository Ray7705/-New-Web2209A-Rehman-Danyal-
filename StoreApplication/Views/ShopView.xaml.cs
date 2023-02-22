﻿using StoreApplication.Models;
using StoreApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StoreApplication.Views
{
    /// <summary>
    /// Interaction logic for ShopView.xaml
    /// </summary>
    public partial class ShopView : UserControl
    {

        private Cart cart;
        private CartViewModel cartViewModel;
        private StoreViewModel storeViewModel;
        private StoreView storeView;
        private CartView cartView;
        public ShopView()
        {
            InitializeComponent();
            cart = new Cart();
            cartViewModel = new CartViewModel(cart);
            storeViewModel = new StoreViewModel(cart);

            storeView.DataContext = storeViewModel;
            cartView.DataContext = storeView;

        }
    
}
}