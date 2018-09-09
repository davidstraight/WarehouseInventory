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
using WarehouseInventory.Models;
using System.Data.Entity;

namespace WarehouseInventory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        WarehouseDB context = new WarehouseDB();
        CollectionViewSource warehouseItemViewSource;


        public MainWindow()
        {
            InitializeComponent();
            //warehouseViewSource = ((CollectionViewSource)(FindResource("warehouseViewSource")));
            DataContext = this;
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource warehouseItemViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("warehouseItemViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            context.WarehouseItems.Load();
            warehouseItemViewSource.Source = context.WarehouseItems.Local;
            System.Windows.Data.CollectionViewSource locationViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("locationViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // locationViewSource.Source = [generic data source]
        }
    }
}
