using System;

namespace CsIntro
{
    class Classes
    {
        public void UseClasses()
        {
            // Access a static property without instantiating the class
            Console.WriteLine("{0} is the MIN and {1} is the MAX TimePeriod can handle", TimePeriod.Min, TimePeriod.Max);

            // Instantiate the class with the parameterless constructor
            var defaultTimePeriod = new TimePeriod();
            Console.WriteLine("====================");
            Console.WriteLine("Parameterless Constructor Initialized");
            Console.WriteLine("Initial Date was set to {0}", defaultTimePeriod.InitialDate);
            Console.WriteLine("Hours at start is: ", defaultTimePeriod.Hours);
            Console.WriteLine("Adding five hours");
            defaultTimePeriod.Hours = 5;
            Console.WriteLine("Now hours are {0}", defaultTimePeriod.Hours);
            Console.WriteLine("Expected End Date is {0}", defaultTimePeriod.GetFinalDate());
            Console.WriteLine("Resetting the Time Period");
            defaultTimePeriod.Reset();
            Console.WriteLine("Hours was reset to {0}", defaultTimePeriod.Hours);

            // defaultTimePeriod.seconds; This statement breaks as the field is private, thus, it can only be called from insde its class.
        }
    }

    // Class to demonstrate the Theory on classes
    class TimePeriod
    {
        private const int min = 0;
        private const int max = 24;

        private int seconds;

        private readonly DateTime initialDate;

        public static double Min
        {
            get => min;
        }

        public static double Max
        {
            get => max;
        }

        public DateTime InitialDate
        {
            get => this.initialDate;
        }

        public double Hours
        {
            get => this.seconds / 3600;
            set
            {
                if (value < min || value > max) throw new ArgumentException(string.Format("Value has to be between {0} and {1}", min, max));
                this.seconds = Convert.ToInt32(value * 3600);
            }
        }

        /// <summary>
        /// Instantiates a TimePeriod with the InitialDate to DateTime.Now.
        /// </summary>
        public TimePeriod()
        {
            // Notice that when calling this constructor, the intellisense will show you the comment above of it :)
            this.initialDate = DateTime.Now;
        }

        /// <summary>
        /// Instantiates a TimePeriod with the InitialDate to the passed argument.
        /// </summary>
        /// <param name="initialDate"></param>
        public TimePeriod(DateTime initialDate)
        {
            this.initialDate = initialDate; // readonly members can be initialized only either on declaration or in the constructor. 
        }

        public DateTime GetFinalDate()
        {
            return this.initialDate.AddHours(this.Hours);
        }

        public void Reset()
        {
            this.seconds = 0;
        }
    }
}
