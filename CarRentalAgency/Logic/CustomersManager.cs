using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRentalAgency.Model;

namespace CarRentalAgency.Logic
{
    public class CustomersManager
    {
        CustomerService customerService;
        public List<Customer> Customers =>this.customerService.GetCustomers();

        public CustomersManager()
        {
            this.customerService = new CustomerService();
        }

        public void ShowCustomers()
        {
            this.DisplayCustomersOnScreen(this.Customers);
        }

        public void AddCustomer()
        {
            Console.WriteLine("This option is not available yet");
        }

        private void DisplayCustomersOnScreen(List<Customer> customers)
        {
            Console.Clear();
            Console.WriteLine("These are the customers:");

            int counter = 0;
            foreach (var customer in customers)
            {
                counter++;
                Console.WriteLine("{0}. {1}", counter, customer.FullName);
            }
        }
    }
}
