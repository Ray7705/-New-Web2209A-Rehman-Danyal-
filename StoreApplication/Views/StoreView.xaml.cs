using StoreApplication.Models;
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
    /// Interaction logic for StoreView.xaml
    /// </summary>
    public partial class StoreView : UserControl
    {
        public StoreView(Cart cart)
        {
            InitializeComponent();
            StoreViewModel storeViewModel = new StoreViewModel();
            //     storeViewModel. += OnDisplay_Click;
            DataContext = storeViewModel; // do it outside
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void OnDisplay_Click(object sender, RoutedEventArgs e)
        {

            SelectedProductDisplay.Visibility = Visibility.Visible;

            //  SelectedItemGrid.Visibility=Visibility.Visible;
        }

        private void DataGrid_Click(object sender, MouseButtonEventArgs e)
        {
            SelectedProductDisplay.Visibility = Visibility.Visible;

        }
    }
}
