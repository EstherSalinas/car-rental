using System;

namespace CsIntro
{
    class ArraysExercises
    {
        public void Months()
        {
            var months = new string[]
            {
                "January", "February", "March", "April" , "May" , "June" , "July" , "August" , "September", "October", "November", "December"
            };

            Console.WriteLine("There are {0} months in a year", months.Length);

            Console.WriteLine("These are the months that contain an 'o':");
            var foundMonths = Array.FindAll(months, element => element.ToString().ToUpper().Contains("O"));
            foreach (string month in foundMonths)
            {
                Console.WriteLine("- {0}", month);
            }
        }

        public void Students()
        {
            int studentId = 0;
            var students = new int[][]
            {
                new int[5] { 2, 4, 2, 4, 2},
                new int[5] { 4, 6, 4, 6, 4},
                new int[5] { 6, 8, 6, 8, 6},
                new int[5] { 8, 10, 8, 10, 8},
                new int[5] { 10, 9, 10, 9, 10},
            };

            Console.WriteLine("These are the greads of each student:");
            foreach (var grades in students)
            {
                studentId++;
                Console.WriteLine("- Student {0}:", studentId);

                foreach (var grade in grades)
                {
                    Console.WriteLine(grade);
                }
            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("These are each student's grades in desc order:");
            studentId = 0;

            foreach (var grades in students)
            {
                studentId++;
                Console.WriteLine("- Student {0}:", studentId);

                Array.Sort(grades);
                Array.Reverse(grades);
                foreach (var grade in grades)
                {
                    Console.WriteLine(grade);
                }
            }

            Console.WriteLine("------------------------------");
            int bestStudent = 0;
            double bestAverage = 0;
            int worstStudent = 0;
            double worstAverage = 10;

            studentId = 0;

            foreach (var grades in students)
            {
                studentId++;
                double sum = 0.0;


                foreach (var grade in grades)
                {
                    sum += grade;
                }

                double average = sum / 5;

                // check if student's average is better than the best so far
                if (average > bestAverage)
                {
                    bestStudent = studentId;
                    bestAverage = sum / 5.0;
                }

                // check if student's average is worse that the worst so far
                if (average < worstAverage)
                {
                    worstStudent = studentId;
                    worstAverage = average;
                }
            }

            Console.WriteLine("Student {0} has the BEST average with a grade of {1}", bestStudent, bestAverage);
            Console.WriteLine("Student {0} has the WORST average with a grade of {1}", worstStudent, worstAverage);
        }
    }
}
