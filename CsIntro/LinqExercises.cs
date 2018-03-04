using CsIntro.HelperClasses;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CsIntro
{
    class LinqExercises
    {
        public void MonthsWithO()
        {
            List<Month> months = Month.GetMonthsList();

            var monthsWithO = from month in months
                              where month.Name.ToUpper().Contains("O")
                              select month;

            Console.WriteLine("======================");
            Console.WriteLine("These are the months that contain an 'O':");
            foreach (var month in monthsWithO)
            {
                Console.WriteLine(month.Name);
            }
        }

        public void MonthsBySeason()
        {
            List<Month> months = Month.GetMonthsList();

            var groupedBySeasonQuery = from month in months
                                       group month by month.Season;

            Console.WriteLine("======================");
            Console.WriteLine("These are the months grouped by season:");

            foreach (var season in groupedBySeasonQuery)
            {
                Console.WriteLine("{0} months", season.Key.ToUpper());
                foreach (var month in season)
                {
                    Console.WriteLine("- {0}", month.Name);
                }
            }
        }

        public void SkipMonthsWithOddDays()
        {
            List<Month> months = Month.GetMonthsList();

            var evenDaysMonths = months.OrderByDescending(month => month.Days).SkipWhile(month => month.Days % 2 != 0);
            // Keep in mind that SkipWhile yields the rest of the values once an element does not match the predicate, that is why we sort it first,
            // to have all those months with odd number of days together in the list.

            Console.WriteLine("======================");
            Console.WriteLine("These are the months with even days numbers:");
            foreach (var month in evenDaysMonths)
            {
                Console.WriteLine("{0} has {1} days", month.Name, month.Days);
            }
        }

        public void StudentsAverage()
        {
            int studentId = 0;
            var averages = new List<double>();
            var students = new int[][]
            {
                new int[5] { 2, 4, 2, 4, 2},
                new int[5] { 4, 6, 4, 6, 4},
                new int[5] { 6, 8, 6, 8, 6},
                new int[5] { 8, 10, 8, 10, 8},
                new int[5] { 10, 9, 10, 9, 10},
            };

            Console.WriteLine("=========================");
            foreach (var student in students)
            {
                studentId++;
                double average = student.Average();
                Console.WriteLine("Student {0} average is {1}", studentId, average);

                averages.Add(average);
            }

            Console.WriteLine("=========================");
            Console.WriteLine("{0} is the HIGHEST average and {1} is the LOWEST average", averages.Max(), averages.Min());
        }
    }
}
