using System;
using System.Text;

namespace CsIntro
{
    class Types
    {
        public void BoolVariables()
        {
            bool isRaining = false;
            Console.WriteLine("Is it raining? " + isRaining);
        }

        public void CharVariables()
        {
            char character = 'c';
            Console.WriteLine("Initial Value of the character: " + character);

            Console.WriteLine("Please enter a new character.");
            character = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("This is the character you entered: " + character);

            Console.WriteLine("Is entered character a puntuation symbol? " + Char.IsPunctuation(character));
        }

        public void IntVariables()
        {
            int temperature = 25;
            Console.WriteLine("Integer temperature is " + temperature);

            temperature = Convert.ToInt32("25");
            Console.WriteLine("String converted temperature is " + temperature);

            temperature = (int)25.5;
            Console.WriteLine("Loosing decimals temperature is " + temperature);
        }

        public void StringVariables()
        {
            string howToTriggerPeople = "Pineapple pizza is the best!";
            Console.WriteLine(howToTriggerPeople);

            string a = "hello";
            string b = "Hello";
            Console.WriteLine("Are hello and Hello the same?");
            Console.WriteLine(a == b);

            Console.WriteLine("This" + " " + "is" + " " + "concatenated");

            string concatenated = "This";
            concatenated += " is concatenated TOO"; // pay attention to the +=. It is the same as doing concatenated = concatenated + ....
            Console.WriteLine(concatenated);

            Console.WriteLine("The second character in 'hello' is '" + a[1] + "'"); // pay attention to single quoating to quate inside a string

            Console.WriteLine("Concatenated sentence's length is " + concatenated.Length);
        }

        public void UsingStringBuilder()
        {
            StringBuilder sentence = new StringBuilder();
            sentence.Append("Hello");
            sentence.Append(" World");
            Console.WriteLine("The StringBuilder sentence has " + sentence.Length + " as length");
            Console.WriteLine("This is the StringBuilder sentence: " + sentence.ToString());
        }

        public void DateTimeVariables()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Now is " + now);

            DateTime birthdate = new DateTime(1986, 11, 2);
            Console.WriteLine("Is birthdate less than now?");
            Console.WriteLine(birthdate < now);
        }
    }
}
