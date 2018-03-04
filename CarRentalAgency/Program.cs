using CarRentalAgency.Logic;
using System;

namespace CarRentalAgency
{
    class Program
    {
        static CarsManager carsManager;
        static CustomersManager customersManager;
        static RentalsManager rentalsManager;

        static void Main(string[] args)
        {
            carsManager = new CarsManager();
            customersManager = new CustomersManager();
            rentalsManager = new RentalsManager();

            MainMenu();
        }

        static void MainMenu()
        {
            int option = 0;

            while (option != 4)
            {
                Console.Clear();
                Console.WriteLine("RENTAL PROGRAM MAIN MENU");
                Console.WriteLine("1. Manage Cars");
                Console.WriteLine("2. Manage Customer");
                Console.WriteLine("3. Manage Rentals (Add rental)");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Write the number of the actinon you want to take:");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            CarsMenu();
                            WaitForUserInput();
                            break;
                        case 2:
                            CustomersMenu();
                            WaitForUserInput();
                            break;
                        case 3:
                            rentalsManager.AddRental();
                            WaitForUserInput();
                            break;
                        case 4:

                            break;
                        default:
                            option = 0;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid option (a number from 1 to 4.");
                    option = 0;
                }
            }
        }

        static void CarsMenu()
        {
            int option = 0;

            while (option != 4)
            {
                Console.Clear();
                Console.WriteLine("CARS MENU");
                Console.WriteLine("1. List All Cars");
                Console.WriteLine("2. Add a Car");
                Console.WriteLine("3. Remove a Car");
                Console.WriteLine("4. Back to main menu");
                Console.WriteLine("Write the number of the actinon you want to take:");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            carsManager.ShowCars();
                            WaitForUserInput();
                            break;
                        case 2:
                            carsManager.AddCar();
                            WaitForUserInput();
                            break;
                        case 3:
                            carsManager.RemoveCar();
                            WaitForUserInput();
                            break;
                        case 4:
                            break;
                        default:
                            option = 0;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid option (a number from 1 to 4.");
                    option = 0;
                }
            }
        }

        static void CustomersMenu()
        {
            int option = 0;

            while (option != 3)
            {
                Console.Clear();
                Console.WriteLine("CUSTOMERS MENU");
                Console.WriteLine("1. List All Customers");
                Console.WriteLine("2. Add a Customer");
                Console.WriteLine("3. Back to main menu");
                Console.WriteLine("Write the number of the actinon you want to take:");

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            customersManager.ShowCustomers();
                            WaitForUserInput();
                            break;
                        case 2:
                            customersManager.AddCustomer();
                            WaitForUserInput();
                            break;
                        case 3:
                            break;
                        default:
                            option = 0;
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid option (a number from 1 to 4.");
                    option = 0;
                }
            }
        }

        static void WaitForUserInput()
        {
            Console.WriteLine("Please, press any key to continue...");
            Console.ReadKey();
        }
    }
}
