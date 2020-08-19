using System;
using System.Windows;
using System.Windows.Controls;
using WpfXml.Model;

namespace WpfXml.Controls
{
    /// <summary>
    /// Interaction logic for CustomerUserControl.xaml
    /// </summary>
    public partial class CustomerUserControl : UserControl
    {

        public Customer Customer
        {
            get { return (Customer)GetValue(CustomerProperty); }        
            set { SetValue(CustomerProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Customer.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CustomerProperty =
            DependencyProperty.Register("Customer", typeof(Customer), typeof(CustomerUserControl), new PropertyMetadata(null));

        public CustomerUserControl()
        {
            InitializeComponent();
        }
    }
}