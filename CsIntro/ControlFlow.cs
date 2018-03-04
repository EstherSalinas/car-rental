using System;

namespace CsIntro
{
    class ControlFlow
    {
        public void IfStatement()
        {
            int adultAge = 18;
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < adultAge)
            {
                Console.WriteLine("Sorry, you are not allowed to use this app. Bye!");
            }
        }

        public void IfElseStatement()
        {
            int adultAge = 18;
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < adultAge)
            {
                Console.WriteLine("Sorry, you are not allowed to use this app. Bye!");
            }
            else
            {
                Console.WriteLine("Please enter, we hope you enjoy our app!");
            }
        }

        public void NestedIf()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            if (b % 2 == 0) // It is the first time we see the % (modulus) operator. Checks the remainder of an integer division. 
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("Both A and B are even numbers");
                }
            }
        }

        public void IfElseIf()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            if (b % 2 != 0)
            {

            }
            else if (a % 2 == 0)
            {
                Console.WriteLine("Both A and B are even numbers");
            }
        }

        public void LogicalOperators()
        {
            Random random = new Random();
            int a = random.Next(0, 100);
            int b = random.Next(0, 100);
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            if (b % 2 == 0 && a % 2 == 0)
            {
                Console.WriteLine("Both A and B are even numbers");
            }
        }

        public void Ternary()
        {
            bool isAdult;
            int adultAge = 18;
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            isAdult = age >= adultAge ? true : false;

            Console.WriteLine("Is the user adult?");
            Console.WriteLine(isAdult);
        }

        public void Switch()
        {
            Console.WriteLine("Enter a number from 1 to 5");
            int value = Convert.ToInt32(Console.ReadLine());

            switch (value)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("Value is 3 or lower");
                    break;
                case 4:
                    Console.WriteLine("Value is 4");
                    break;
                case 5:
                    Console.WriteLine("Value is 5");
                    break;
                default:
                    Console.WriteLine("The value you entered was not recognized.");
                    break;
            }
        }

        public void ForLoop()
        {
            Console.WriteLine("These are the even numbers between 0 and 50");
            for (int i = 2; i <= 50; i += 2)
            {
                Console.WriteLine(i);
            }
        }

        public void WhileLoop()
        {
            var random = new Random();
            bool isEven = false;
            int number;

            Console.WriteLine("Pick numbers until you get an even one.");
            while (!isEven)
            {
                number = random.Next(0, 100);
                Console.WriteLine("Number found: " + number);

                isEven = number % 2 == 0;
            }
            Console.WriteLine("Finally found an even number ^^");
        }
    }
}
