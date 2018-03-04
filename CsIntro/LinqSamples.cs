using CsIntro.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsIntro
{
    class LinqSamples
    {
        public void FirstLinqSample()
        {
            // The Data Source
            int[] numbers = { 1, 2, 3, 4, 5 };

            // The Query
            var query = from number in numbers
                        where (number % 2 == 0)
                        select number;

            // The Execution
            Console.WriteLine("These are the even numbers found using LINQ:");
            foreach (var number in query)
            {
                Console.WriteLine(number);
            }
        }

        public void ForcingQueryExecution()
        {
            // The Data Source
            int[] numbers = { 1, 2, 3, 4, 5 };

            // The Query forced to be Executed with the ToList()
            var evenNumbers = (from number in numbers
                               where (number % 2 == 0)
                               select number).ToList();

            Console.WriteLine("These are the even numbers found using LINQ:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
        }

        public void Ordering()
        {
            List<User> users = User.GetUsersList();

            var query = from user in users
                        orderby user.Name ascending
                        select user;

            Console.WriteLine("These are the users ordered by name:");
            foreach (var user in query)
            {
                Console.WriteLine("{0}, {1}, {2}", user.Name, user.Age, user.Country);
            }
        }

        public void Grouping()
        {
            List<User> users = User.GetUsersList();

            var usersByCountry = from user in users
                                 group user by user.Country;

            // Remember that grouping creates kind of a list of lists, where each nested list represents a group.
            // These nested lists contain a Key (which is the key we used in the group clause (Country in our sample) 
            // and the elements resulting from the grouping itself.

            Console.WriteLine("================================");
            Console.WriteLine("Let's see the users per Country.");
            foreach (var country in usersByCountry)
            {
                Console.WriteLine("These are the users from {0}", country.Key);
                foreach (var person in country)
                {
                    Console.WriteLine("- {0}, {1}, {2}", person.Name, person.Age, person.Country);
                }

            }
        }

        public void Joining()
        {
            List<User> users = User.GetUsersList();
            List<TrainingCenter> centers = TrainingCenter.GetTrainingCentersList();

            var userTrainingCenterQuery = from user in users
                                          join center in centers on user.Country equals center.Country
                                          select new { UserName = user.Name, TrainingCenterName = center.Name };

            Console.WriteLine("================================");
            Console.WriteLine("These are the users with their local centers:");
            foreach (var userCenter in userTrainingCenterQuery)
            {
                Console.WriteLine("User: {0}, Local Training Center: {1}", userCenter.UserName, userCenter.TrainingCenterName);
            }
        }

        public void OperatorMethods()
        {
            List<User> users = User.GetUsersList();

            users.OrderBy(user => user.Name).ThenBy(user => user.Country);

            Console.WriteLine("================================");
            Console.WriteLine("These are the users with their local centers gotten with Query Operator ordered by Name and Countrys:");
            foreach (var user in users)
            {
                Console.WriteLine("- {0}, {1}, {2}", user.Name, user.Age, user.Country);
            }

        }
    }
}
