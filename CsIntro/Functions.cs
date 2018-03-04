using System;

namespace CsIntro
{
    class Functions
    {
        public void Greet(string name)
        {
            Console.WriteLine("Hello {0}", name);
        }

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int ShortcutAdd(int a, int b) => a + b;

        public void CallFunctionWithOptionalParameters()
        {
            // Pay attention to the intellisense when invoking the ShowUserProfile() method and notice how the optional parameters are between brackets []
            ShowUserProfile("Nereo", 31);
        }

        private void ShowUserProfile(string name, int age, bool isAlive = true)
        {
            Console.WriteLine("The user is {0}, is {1}yo and is alive: {2}", name, age, isAlive);
        }

        public void NamedParameters()
        {
            // When it is not so clear what the value we pass is and we have to check the invoked method's signature, then it is a good idea to use named parameters
            ShowUserProfile("Nereo", age: 31, isAlive: true);

            // Also when you want to skip optional parameters, like this
            MethodWithMultipleOptionalParameters("Nereo", isAlive: true);
        }

        private void MethodWithMultipleOptionalParameters(string name, string lastname = null, bool isAlive = true)
        {
            Console.WriteLine("{0} {1} is still alive: {2}", name, lastname, isAlive);
        }

        // Array defined to show the Methods overloading
        private int[] numbers = new int[5];

        public void MethodOverloading()
        {
            AddToNumbers(1);
            AddToNumbers(2, 3);
            AddToNumbers("4", "5");

            Console.WriteLine("These are the numbers assigned using Overloading: ");
            foreach (var number in numbers)
            {
                Console.WriteLine("- {0}", number);
            }
        }

        private void AddToNumbers(int n1)
        {
            numbers[0] = n1;
        }

        private void AddToNumbers(int n2, int n3)
        {
            numbers[1] = n2;
            numbers[2] = n3;
        }

        private void AddToNumbers(string n4, string n5)
        {
            numbers[3] = Convert.ToInt32(n4);
            numbers[4] = Convert.ToInt32(n5);
        }

        public void LocalFunction()
        {
            PrintOnScreen("Bob");

            void PrintOnScreen(string name)
            {
                Console.WriteLine(name);
            }
        }
    }
}
