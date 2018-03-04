using CarRentalAgency.Model;
using System;
using System.Collections.Generic;

namespace CarRentalAgency.Logic
{
    public class CustomerService
    {
        List<Customer> customers;

        public CustomerService()
        {
            this.customers = new List<Customer>();
            this.CreateHardcodedCustomers();
        }

        public List<Customer> GetCustomers()
        {
            return this.customers;
        }

        private void CreateHardcodedCustomers()
        {
            this.customers.Add(new Customer("Esther", "Salinas", new DateTime(1984, 7, 20), "Car"));
            this.customers.Add(new Customer("Antonio", "Sanchez", new DateTime(1989, 6, 25), "Car"));
            this.customers.Add(new Customer("Isabel", "Paneque", new DateTime(1976, 2, 2), "Car"));
            this.customers.Add(new Customer("Manuel", "Fuentes", new DateTime(1982, 3, 8), "Car"));
       
        }

       
    }
}