using System;

namespace CsIntro
{
    class ControlFlowExercises
    {
        private enum seniority
        {
            Junior,

            Pro,

            Senior,

            Manager,

            Undefined
        }

        public void BuildUserProfile()
        {
            // Variables declaration
            bool isCorrect = false;

            string name;
            string lastName;
            string fullName = String.Empty;
            DateTime birthdate;
            char gender;
            string profession;
            int yearsOfExperience;
            string userSeniority;
            decimal grossYearlySalary;

            // Getting input from the user
            while (!isCorrect)
            {
                Console.Clear();

                Console.WriteLine("Please, enter your name");
                name = Console.ReadLine();

                Console.WriteLine("Please, enter your last name");
                lastName = Console.ReadLine();

                fullName = lastName.ToUpper() + ", " + name;

                Console.WriteLine("Please, enter your birthdate");
                birthdate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Please, enter your gender('f' for female or 'm' for male)");
                gender = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("Please, enter your profession");
                profession = Console.ReadLine();

                Console.WriteLine("Please, enter the number of years of experience you have");
                yearsOfExperience = Convert.ToInt32(Console.ReadLine());

                switch (yearsOfExperience)
                {
                    case int n when (n <= 2):
                        userSeniority = seniority.Junior.ToString();
                        break;
                    case int n when (n > 2 && n < 5):
                        userSeniority = seniority.Pro.ToString();
                        break;
                    case int n when (n >= 5 && n < 10):
                        userSeniority = seniority.Senior.ToString();
                        break;
                    case int n when (n > 10):
                        userSeniority = seniority.Manager.ToString();
                        break;
                    default:
                        userSeniority = seniority.Undefined.ToString();
                        break;
                }

                Console.WriteLine("Please, enter your yearly gross salary");
                grossYearlySalary = Convert.ToDecimal(Console.ReadLine());

                // Showing the full profile to the user
                Console.WriteLine();
                Console.WriteLine("Thanks, here is the information we got from you:");
                Console.WriteLine("Name: " + name);
                Console.WriteLine("Last Name: " + lastName);
                Console.WriteLine("Full Name: " + fullName);
                Console.WriteLine("Birthdate: " + birthdate);
                Console.WriteLine("Age: " + (DateTime.Now.Year - birthdate.Year));
                Console.WriteLine("Gender: " + gender.ToString().ToUpper() == "F" ? "female" : "male");
                Console.WriteLine("Profession: " + profession.Replace(' ', '_'));
                Console.WriteLine("Years of Experience: " + yearsOfExperience);
                Console.WriteLine("Seniority Level: " + userSeniority);
                Console.WriteLine("Monthly Gross Salary: " + grossYearlySalary / 12);

                // Check if data is correct
                Console.WriteLine();
                Console.WriteLine("Is data correct? (yes/no)");
                isCorrect = Console.ReadLine().ToUpper() == "YES";
            }

            Console.WriteLine("Thanks " + fullName + ". Registration was done correctly");
        }

        public void ForLoop()
        {
            Random random = new Random();
            int even = 0;
            int odd = 0;

            for (int i = 0; i < 100; i++)
            {
                if (random.Next(0, 100) % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }

            Console.WriteLine(string.Format("There were {0} even numbers found", even));
            Console.WriteLine(string.Format("There were {0} odd numbers found", odd));
        }

        public void WhileLoop()
        {
            Random random = new Random();
            int sum = 0;
            int number;

            while (sum < 100)
            {
                number = random.Next(0, 10);
                sum += number;
                Console.WriteLine("Number found: " + number);
            }

            Console.WriteLine("Sum of all numbers: " + sum);
        }
    }
}
