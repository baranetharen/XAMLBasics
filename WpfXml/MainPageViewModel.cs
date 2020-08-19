using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfXml.Model;
using WpfXml.Repository;

namespace WpfXml
{
    public class MainPageViewModel : ObjectChangedNotification
    {
        private readonly CustomerRepository customerRepository = null;

        public MainPageViewModel()
        {
            Customers = new ObservableCollection<Customer>();
            customerRepository = new CustomerRepository();
        }

        public ObservableCollection<Customer> Customers { get; set; }

        private Customer _selectedCustomer;
        public Customer SelectedCustomer
        {
            get
            {
                return _selectedCustomer;
            }
            set
            {
                if(_selectedCustomer != value)
                {
                    _selectedCustomer = value;
                    OnPropertyChange();
                }
            }
        }

        public async Task LoadCustomer()
        {
            var customers = await customerRepository.GetCustomers();
            foreach (var cust in customers)
            {
                Customers.Add(cust);
            }
        }

        public async Task SaveCustomers(IEnumerable<Customer> customer)
        {
            await customerRepository.SaveCustomers(customer);
        }

        public void DeleteCustomer(Customer customer)
        {
            Customers.Remove(customer);
        }

        public Customer AddCustomer()
        {
            var Customer = new Customer() { FirstName = "New" };
            Customers.Add(Customer);
            return Customer;
        }
    }
}