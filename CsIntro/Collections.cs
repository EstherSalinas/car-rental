using System;
using System.Collections.Generic;

namespace CsIntro
{
    class Collections
    {
        public void Instantiation()
        {
            var cars = new List<string>();
        }

        public void AddingElements()
        {
            var cars = new List<string>();
            cars.Add("Toyota CHR");
            cars.Add("Mercedes S Coupe");

            Console.WriteLine("There are {0} cars in the list.", cars.Count);
            Console.WriteLine("This is the latests car: " + cars[1]);
        }

        public void IteratingCollections()
        {
            var cars = new List<string>();
            cars.Add("Citroen C1");
            cars.Add("Toyota CHR");
            cars.Add("Mercedes S Coupe");

            Console.WriteLine("These are the cars in the garage:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void RemoveElement()
        {
            var cars = new List<string>();
            cars.Add("Citroen C1");
            cars.Add("Toyota CHR");
            cars.Add("Mercedes S Coupe");

            Console.WriteLine("There are {0} cars in the garage", cars.Count);

            cars.Remove("Toyota CHR");
            Console.WriteLine("The Toyota was sold, now there are {0} cars in the garage:", cars.Count);
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void ListInsert()
        {
            var cars = new List<string>();
            cars.Add("Citroen C1");
            cars.Add("Toyota CHR");
            cars.Add("Mercedes S Coupe");

            Console.WriteLine("These are the cars before inserting a new one:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }

            cars.Insert(2, "Volvo XC60");
            Console.WriteLine("These are the cars after inserting a new one after the Toyota:");
            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }

        public void ListCapacity()
        {
            var cars = new List<string>();
            cars.Add("Citroen C1");
            cars.Add("Toyota CHR");
            cars.Add("Volvo XC60");
            cars.Add("Audi A6");
            cars.Add("Mercedes S Coupe");

            Console.WriteLine("Adding 3 cars, the garage contains {0} cars and has capacity for {1}", cars.Count, cars.Capacity);

            cars.Remove("Toyota CHR");
            Console.WriteLine("After selling the Toyota, the garage contains {0} cars and has capacity for {1}", cars.Count, cars.Capacity);

            cars.Insert(1, "Toyota Prius");
            Console.WriteLine("After inserting a new car, the garage contains {0} cars and has capacity for {1}", cars.Count, cars.Capacity);

            cars.TrimExcess();
            Console.WriteLine("There was an excess of capacity, now the garage contains {0} cars and has capacity for {1} after trimming the excess", cars.Count, cars.Capacity);
        }

        public void Dictionary()
        {
            var openWith = new Dictionary<string, string>();

            openWith.Add(".txt", "Notepad");
            openWith.Add(".cs", "Visual Studio");
            openWith.Add(".jpg", "Photoshop");
            openWith.Add(".docx", "Open Office");

            Console.WriteLine("Is there an application for 'txt' files? " + openWith.ContainsKey(".txt"));

            try
            {
                openWith.Add(".txt", "Word");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("You tried to add an item with a key that already exists in the Dictionary.");
            }

            Console.WriteLine("'cs' files are opened with {0}", openWith[".cs"]);
            openWith[".docx"] = "Word";
            Console.WriteLine("'docx' files are opened with {0}", openWith[".docx"]);

            string jpg;
            if (openWith.TryGetValue(".jpg", out jpg))
            {
                Console.WriteLine("'jpg' files are opened with {0}", jpg);
            }
            else
            {
                Console.WriteLine("There is no entry for 'jpg' files.");
            }
        }

        public void Queue()
        {
            var numbers = new Queue<int>();
            numbers.Enqueue(1);
            numbers.Enqueue(2);
            numbers.Enqueue(3);
            numbers.Enqueue(4);
            numbers.Enqueue(5);

            Console.WriteLine("These are the numbers in the Queue:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("We are removing the element at the beginning of the Queue, which was {0}", numbers.Dequeue());
            Console.WriteLine("Now the element at the beginning of the Queue is {0}", numbers.Peek());
        }

        public void Stack()
        {
            var numbers = new Stack<int>();
            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            Console.WriteLine("These are the numbers in the Stack:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("We are removing the element at the top of the Stack, which was {0}", numbers.Pop());
            Console.WriteLine("Now the element at the top of the Stack is {0}", numbers.Peek());
        }
    }
}
