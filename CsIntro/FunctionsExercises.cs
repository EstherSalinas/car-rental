using System;

namespace CsIntro
{
    class FunctionsExercises
    {
        Random random = new Random();

        public void Functions()
        {
            var numbers = new int[5];
            // 1. Fill the array with random numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = GetRandomNumber();
            }

            // 2. Display Array
            DisplayArray(numbers);

            // 3. Get Average
            Console.WriteLine("Array Average is: " + GetArrayAverage(numbers));
        }

        private int GetRandomNumber() => this.random.Next(0, 100);

        private void DisplayArray(int[] numbers)
        {
            int position = 0;
            foreach (var number in numbers)
            {
                Console.WriteLine("Position {0} has number {1}", ++position, number);
            }
        }

        private double GetArrayAverage(int[] numbers)
        {
            double avg = 0.0;
            double sum = 0.0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            avg = sum / numbers.Length;

            return avg;
        }

        public void UserProfile()
        {
            Console.WriteLine("Do you want your profile to be public? (y/n)");
            bool publicProfile = Console.ReadLine().ToUpper() == "Y";

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your last name?");
            string lastname = Console.ReadLine();

            Console.WriteLine("Want your name visible? (y/n)");
            bool displayName = Console.ReadLine().ToUpper() == "Y";

            Console.WriteLine("Want your last name visible? (y/n)");
            bool displayLastName = Console.ReadLine().ToUpper() == "Y";

            if (displayName || displayLastName)
            {
                if (displayName && displayLastName)
                {
                    DisplayProfile(publicProfile, name, lastname);
                }
                else if (displayName)
                {
                    DisplayProfile(publicProfile, name);
                }
                else
                {
                    DisplayProfile(publicProfile, lastName: lastname);
                }
            }
            else
            {
                DisplayProfile(publicProfile);
            }

        }

        private void DisplayProfile(bool isProfilePublic, string name = null, string lastName = null)
        {
            Console.WriteLine("Profile is public? {0}, Name: {1}, LastName: {2}", isProfilePublic, name, lastName);
        }

        public void CarSearchBuilder()
        {
            // play invoking any of the private methods overload below.
            Console.WriteLine("Search a car matching these criterias:");
        }

        private void CarSearch(string brand)
        {
            Console.WriteLine("Brand {0}", brand);
        }

        private void CarSearch(string brand, string model)
        {
            Console.WriteLine("Brand {0}", brand);
            Console.WriteLine("Model {0}", model);
        }

        private void CarSearch(string brand, string model, bool isDiesel)
        {
            Console.WriteLine("Brand {0}", brand);
            Console.WriteLine("Model {0}", model);
            Console.WriteLine("Diesel {0}", isDiesel);
        }

        private void CarSearch(string brand, bool isDiesel)
        {
            Console.WriteLine("Brand {0}", brand);
            Console.WriteLine("Diesel {0}", isDiesel);
        }

        private void CarSearch(string brand, bool isDiesel, int year)
        {
            Console.WriteLine("Brand {0}", brand);
            Console.WriteLine("Diesel {0}", isDiesel);
            Console.WriteLine("Year {0}", year);
        }

        private void CarSearch(string brand, int maxKms)
        {
            Console.WriteLine("Brand {0}", brand);
            Console.WriteLine("Max Kms {0}", maxKms);
        }
    }
}
