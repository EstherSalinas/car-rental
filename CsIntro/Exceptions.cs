using System;

namespace CsIntro
{
    class Exceptions
    {
        public void WithoutTry()
        {
            // This code will break. Take the time to check the Autos window, the Call Stack window and to View Details on the Exception to check its properties. 
            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers[8]);
        }

        public void TryCatch()
        {
            var numbers = new int[5] { 1, 2, 3, 4, 5 };

            // we will try to access an index not existing in the array to force an exception
            try
            {
                Console.WriteLine(numbers[8]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Error Source: " + ex.Source);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        public void TryCatchCatch()
        {
            var numbers = new int[5] { 1, 2, 3, 4, 5 };

            // we will try to access an index not existing in the array to force an exception
            try
            {
                Console.WriteLine(numbers[8]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Notice that this exception will never be fired as the Exception Filter will never match!");
            }
        }

        public void Finally()
        {
            var numbers = new int[5] { 1, 2, 3, 4, 5 };
            int sum = 0;

            try
            {
                // The loop will reach an index that does not exist in the array to force an exception
                for (int i = 0; i <= 5; i++)
                {
                    sum += numbers[i];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("The sum of all the numbers is {0}", sum);
            }
        }

        public void ThrowException()
        {
            try
            {
                WriteMessageThrowingException(null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Inner Exception: " + ex.InnerException);
                Console.WriteLine("Error Message: " + ex.Message);
                Console.WriteLine("Error Source: " + ex.Source);
                Console.WriteLine("Stack Trace: " + ex.StackTrace);
            }
        }

        private void WriteMessageThrowingException(string message)
        {
            if (message == null)
            {
                throw new ArgumentException("Parameter cannot be null", "message");
            }
        }
    }
}
