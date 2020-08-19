using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfXml.Model;

namespace WpfXml.Repository
{
    public class CustomerRepository
    {
        private static readonly string FileName = "Customer.json";
        private static readonly string BaseFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            try
            {
                List<Customer> customerList;
                var basePath = Path.Combine(BaseFile, FileName);
                if (!File.Exists(basePath))
                {
                    customerList = new List<Customer>
                {
          new Customer{FirstName="Thomas",LastName="Huber",IsDeveloper=true},
          new Customer{FirstName="Anna",LastName="Rockstar",IsDeveloper=true},
          new Customer{FirstName="Julia",LastName="Master"},
          new Customer{FirstName="Urs",LastName="Meier",IsDeveloper=true},
          new Customer{FirstName="Sara",LastName="Ramone"},
          new Customer{FirstName="Elsa",LastName="Queen"},
          new Customer{FirstName="Alex",LastName="Baier", IsDeveloper=true},
                  };
                }
                else
                {
                    var stream = File.Open(basePath, FileMode.OpenOrCreate);
                    using (var dat = new StreamReader(stream))
                    {
                        var data = await dat.ReadToEndAsync();
                        customerList = JsonConvert.DeserializeObject<List<Customer>>(data);
                    }
                }
                return customerList;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public async Task SaveCustomers(IEnumerable<Customer> customers)
        {
            try
            {
                var basePath = Path.Combine(BaseFile, FileName);
                using (FileStream str = File.Open(basePath, FileMode.OpenOrCreate))
                {
                    using (StreamWriter writter = new StreamWriter(str))
                    {
                        var customersstr = JsonConvert.SerializeObject(customers, Formatting.Indented);
                        await writter.WriteAsync(customersstr);
                    }
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
