using CarRentalAgency.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalAgency.Logic
{
    class RentalsManager
    {
        CustomersManager customersManager;
        CarsManager carsManager;

        List<Rental> rentals;

        public RentalsManager()
        {
            this.customersManager = new CustomersManager();
            this.carsManager = new CarsManager();
            this.rentals = new List<Rental>();
        }

        public void AddRental()
        {
            Console.Clear();
            Console.WriteLine("Please enter the following information:");
            var customer = this.SelectCustomer();
            var car = this.SelectCar();
            var startDate = this.SelectDate("Select the start date for the rental");
            var endDate = this.SelectDate("Select the start date for the rental");
            var cardNumber = this.AskForCreditCardNumber();

            var rental = new Rental(car, customer.Id, startDate, endDate, cardNumber);
            this.rentals.Add(rental);
            this.carsManager.BlockCar(car.Id);
            this.ShowAddedRentalInformation(rental, customer, car);

        }

        public void ShowAddedRentalInformation(Rental rental, Customer customer, Car car)
        {
            Console.Clear();
            Console.WriteLine("The rental has been registered correctly. Here is the rental information:");
            Console.WriteLine("Customer: {0}", customer.FullName);
            Console.WriteLine("Start date: {0}", rental.StartDate);
            Console.WriteLine("End date: {0}", rental.EndDate);
            Console.WriteLine("Car: {0} {1} {2}", car.Maker, car.Model, car.EnergyType);
            Console.WriteLine("Expected Fee: {0}", rental.Fee);
            Console.WriteLine("Deposit: {0}", rental.DepositFee);
        }

        private Customer SelectCustomer()
        {
            Customer selectedCustomer = null;
            int selectedCustomerIndex;
            bool validOption = false;

            while (validOption == false)
            {
                var customers = this.customersManager.Customers;
                this.customersManager.ShowCustomers();
                Console.WriteLine("Select the customer for the rental");

                try
                {
                   
                        selectedCustomerIndex = Convert.ToInt32(Console.ReadLine());
                        selectedCustomerIndex--;
                        if (selectedCustomerIndex < customers.Count)
                        {
                            validOption = true;
                            selectedCustomer = customers[selectedCustomerIndex];

                        }
                    

                }
                catch(FormatException)
                {
                    Console.WriteLine("Please enter a valid option");
                }
            }

            return selectedCustomer;

        }

        private Car SelectCar()
        {
            Car selectedCar = null;
            int selectedCarIndex;
            bool validOption = false;

            while (validOption == false)
            {
                var cars = this.carsManager.Cars;
                this.carsManager.ShowAvailableCars();         
                Console.WriteLine("Select the car for the rental");

                try
                {
                    selectedCarIndex = Convert.ToInt32(Console.ReadLine());
                    selectedCarIndex--;
                    if (selectedCarIndex < cars.Count)
                    {
                        validOption = true;
                        selectedCar = cars[selectedCarIndex];

                    }
                    
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please select a valid option");
                }
            }

            return selectedCar;

        }

        private DateTime SelectDate(string message)
        {
            string selectedDate = string.Empty;
            bool validInput = false;

            Console.WriteLine(message);

            while (validInput == false)
            {
                try
                {
                    selectedDate = Console.ReadLine();
                    Convert.ToDateTime(selectedDate);
                    validInput = true;

                }
                catch(FormatException)
                {
                    Console.WriteLine("Please, enter a valid date");
                }
            }

            return Convert.ToDateTime(selectedDate);

        }

        private int AskForCreditCardNumber()
        {
            bool validInput = false;
            Console.WriteLine("Enter the credit card number:");
            int creditCardNumber = 0;

            while (validInput == false)
            {
                try
                {
                    validInput = true;
                    creditCardNumber = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid credit card number");
                }
            }

            return creditCardNumber;

        }
    }
}
