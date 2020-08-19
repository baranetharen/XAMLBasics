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
using WpfXml.Model;
using WpfXml.Repository;

namespace WpfXml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainPageViewModel MainPageViewModel;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;
            MainPageViewModel = new MainPageViewModel();
            this.DataContext = MainPageViewModel;
        }

        private async void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Closing", "Do You Want to Close", MessageBoxButton.OKCancel, MessageBoxImage.Information);
            if (result == MessageBoxResult.Cancel)
            {
                e.Cancel = true;
            }
            else
            {
                var customer = cust_list.Items.Cast<Customer>();
                await MainPageViewModel.SaveCustomers(customer);
                e.Cancel = false;
            }
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            await MainPageViewModel.LoadCustomer();
        }

        private void Nav_Button(object sender, RoutedEventArgs e)
        {
            var colum = (int)Control_pannel.GetValue(Grid.ColumnProperty);
            var newcolumn = colum == 0 ? 2 : 0;
            Control_pannel.SetValue(Grid.ColumnProperty, newcolumn);
        }

        private void Delete_Button(object sender, RoutedEventArgs e)
        {
            if (cust_list.SelectedItem is Customer customer)
            {
                MainPageViewModel.DeleteCustomer(customer);
            }
        }

        private void Add_Button(object sender, RoutedEventArgs e)
        {
           var customer =  MainPageViewModel.AddCustomer();
            cust_list.SelectedItem = customer;
        }
    }
}
