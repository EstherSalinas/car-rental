using System;
using System.Collections.Generic;
using System.Linq;

namespace CsIntro
{
    class CollectionsExercises
    {
        Random random = new Random();

        public void ListExercise()
        {
            var numbers = new List<int>();

            // Fill the list with random numbers
            for (int i = 0; i < 25; i++)
            {
                int number = random.Next(1, 50);

                // 1. Avoid adding duplicated numbers
                if (numbers.Exists(element => element == number) == false)
                {
                    numbers.Add(number);
                }
            }

            DisplayList(numbers);

            // 2. Sort List
            Console.WriteLine("=============================================");
            Console.WriteLine("Sorting the List");
            numbers.Sort();
            DisplayList(numbers);

            // 3.Insert Missing Numbers
            Console.WriteLine("=============================================");
            Console.WriteLine("Filling the Gap");
            const int MaxOfElements = 50;
            int lowestRandomlyGenerated = numbers.First();
            bool lowestReached = false;
            bool highestReached = false;

            for (int i = 0; i < MaxOfElements; i++)
            {
                // Before doing anything, we make sure we are not at the last position
                if (numbers.Count == MaxOfElements) break;

                // Maybe the random generator did not give us a 1. This means that before starting to compare the current position with the next one to see if they are
                // correlative or if we need to insert numbers in the middle, we need to check if we need to add numbers at the beginning of the list until reaching the 
                // lowest that was randomly generated
                if (lowestReached == false)
                {
                    lowestReached = i + 1 == lowestRandomlyGenerated;
                    // opposite as with highest we cannot check it on the fly against numbers.First(), as once we add a new number the first one 
                    // would be the just inserted number and not the lowest randomly generated.
                }

                // There will be a moment when i + 1 could be out of range, for instance, if the highest random number was 42 and we still need to fill up to 50
                // then when i = 41 (position for number 42) i + 1 will be already out of range.  We need to check that
                if (highestReached == false)
                {
                    highestReached = numbers[i] == numbers.Last();

                }

                if (lowestReached == false)
                {
                    numbers.Insert(i, i + 1);
                }
                else if (highestReached)
                {
                    numbers.Add(numbers[i] + 1);
                }
                else if (numbers[i] + 1 != numbers[i + 1])
                {
                    numbers.Insert(i + 1, numbers[i] + 1);
                }
            }
            DisplayList(numbers);

            // 4. Remove items not multiple of 3.
            Console.WriteLine("=============================================");
            Console.WriteLine("Removing items not multiples of 3");

            // When removing items within a loop, if we do it forward then the size changes and the loop is no more valid as the limit has changed
            // For that reason in this case we do it backwards, as if we remove the current item it does not affect the end of the loop which is the first position.
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                if ((numbers[i] % 3 == 0) == false)
                {
                    numbers.RemoveAt(i);
                }
            }

            DisplayList(numbers);

            void DisplayList(List<int> list)
            {
                Console.WriteLine("These are the random generated numbers. {0} in total:", list.Count);
                foreach (var item in list)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public void FavouriteSites()
        {
            bool exit = false;
            var sites = new Dictionary<string, string>();

            while (exit == false)
            {
                Console.Clear();
                Console.WriteLine("Welcome to your Site manager. Please press the number of the option you want.");
                Console.WriteLine("1. Add a Site.");
                Console.WriteLine("2. View your Sites.");
                Console.WriteLine("3. Remove a Site.");
                Console.WriteLine("4. Close the application.");

                int option;

                try
                {
                    option = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    option = 4;
                }

                switch (option)
                {
                    case 1:
                        AddSite();
                        WaitForUserKey();
                        break;
                    case 2:
                        ShowSites();
                        WaitForUserKey();
                        break;
                    case 3:
                        RemoveSite();
                        WaitForUserKey();
                        break;
                    default:
                        exit = true;
                        break;
                }

                Console.WriteLine("Thanks for using the app. Bye!");
            }

            void AddSite()
            {
                bool backToMenu = false;

                while (backToMenu == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please write the name of the site:");

                    string name = Console.ReadLine().ToLower();

                    if (sites.ContainsKey(name) == false)
                    {
                        Console.WriteLine("Please Write the URL of the site:");
                        string url = Console.ReadLine().ToLower();

                        sites.Add(name, url);
                        Console.WriteLine("Site added correctly");

                        backToMenu = true;
                    }
                    else
                    {
                        Console.WriteLine("The site entered already exists. Press 'R' to retry or anything else to go back to the Menu.");
                        backToMenu = Console.ReadLine().ToUpper() != "R";
                    }
                }

            }

            void ShowSites()
            {
                Console.Clear();
                Console.WriteLine("This is the list of your sites collection:");
                foreach (var site in sites)
                {
                    Console.WriteLine("{0} - {1}", site.Key, site.Value);
                }
            }

            void RemoveSite()
            {
                bool backToMenu = false;

                while (backToMenu == false)
                {
                    ShowSites();
                    Console.WriteLine("Please enter the name of the site shown above you want to remove:");

                    string site = Console.ReadLine().ToLower();
                    if (sites.ContainsKey(site))
                    {
                        sites.Remove(site);
                        Console.WriteLine("{0} was removed successfully.", site);
                        backToMenu = true;
                    }
                    else
                    {
                        Console.WriteLine("The site entered cannot be removed because it does not exist. Press 'R' to retry or anything else to go back to the Menu.");
                        backToMenu = Console.ReadLine().ToUpper() != "R";
                    }
                }
            }

            void WaitForUserKey()
            {
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
