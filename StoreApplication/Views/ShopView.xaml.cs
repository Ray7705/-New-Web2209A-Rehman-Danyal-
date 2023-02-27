﻿using Chevalier.Utility.Commands;
using StoreApplication.Models;
using StoreApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public ShopView()
        {
            InitializeComponent();
            cart = new Cart();
            cartViewModel = new CartViewModel(cart);
            storeViewModel = new StoreViewModel(cart);

            storeView.DataContext = storeViewModel;
            cartView.DataContext = cartViewModel;
        }
        public void AddToCart()
        {

        }

        private void cartView_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
