using System;

namespace CsIntro
{
    class Arrays
    {
        public void ArrayDeclaration()
        {
            int[] numbers = new int[10];
            Console.WriteLine("Array numbers declared: " + numbers);
        }

        public void ArrayInitialization()
        {
            string[] students = new string[]
            {
                "Nico",
                "Marco",
                "Esther",
                "Sebas",
                "Kevin",
                "Carlota",
                "Nico",
                "Adriá",
                "Xavi",
                "Ángel",
                "Mercedes"
            };

            string[] seasons = { "Summer", "Fall", "Winter", "Spring" };

            Console.WriteLine("Students Initialized: " + students);
            Console.WriteLine("Seasons Initialized: " + seasons);
        }

        public void ImplicitlyTyped()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Implicitly typed arra is " + numbers);
        }

        public void DelayedInitialization()
        {
            int[] numbers;
            numbers = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Delayed Initialization: " + numbers);
        }

        public void SettingGettingValues()
        {
            var days = new string[7];
            days[0] = "Monday";
            Console.WriteLine("First day of the week is " + days[0]);
        }

        public void Properties()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Is Fixed? " + numbers.IsFixedSize);
            Console.WriteLine("How many numbers? " + numbers.Length);
        }

        public void Methods()
        {
            var numbers = new[] { 1, 2, 3, 4, 5 };
            var numbersClone = (int[])numbers.Clone();

            Console.WriteLine("This is the clone: " + numbersClone);
            Console.WriteLine("This is the first element: " + numbersClone[0]);

            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            var daysClone = (string[])days.Clone();

            Console.WriteLine("Is there a day starting with W? " + Array.Exists(days, element => element.StartsWith("W")));
            Console.WriteLine("First even number is " + Array.Find(numbers, element => element % 2 == 0));
            Console.WriteLine("First even number's index is " + Array.FindIndex(numbers, element => element % 2 == 0));
            Console.WriteLine("Wednesday is in the position " + Array.IndexOf(days, "Wednesday"));

            Array.Reverse(numbersClone);
            Console.WriteLine("First number on reverse order is " + numbersClone[0]);

            Array.Sort(daysClone);
            Console.WriteLine("First day alphabetically is " + daysClone[0]);
        }

        public void Loop()
        {
            string[] days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            Console.WriteLine("These are the days of the week:");

            foreach (string day in days)
            {
                Console.WriteLine("- {0}", day); // Notice the placeholder {0}. Gets replace by the first element after the , that follows the literal. This is called "Template String"
            }
        }

        public void Multidimensional()
        {
            var numbers = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            Console.WriteLine("In position 2, 1 is number " + numbers[2, 1]);
        }

        public void JaggedArrays()
        {
            var monthsBySeason = new string[][]
            {
                new string[] { "December, January, February" },
                new string[] { "March", "April" , "May" },
                new string[] { "June" , "July" , "August" },
                new string[] { "September", "October", "November" }
            };

            Console.WriteLine("Let's see what month position 2, 1 returns: " + monthsBySeason[2][1]);
        }
    }
}
