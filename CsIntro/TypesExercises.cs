using System;

namespace CsIntro
{
    class TypesExercises
    {
        public void BuildUserProfile()
        {
            // Variables declaration
            string name;
            string lastName;
            DateTime birthdate;
            char gender;
            string profession;
            int yearsOfExperience;
            decimal grossYearlySalary;

            // Getting input from the user
            Console.WriteLine("Please, enter your name");
            name = Console.ReadLine();

            Console.WriteLine("Please, enter your last name");
            lastName = Console.ReadLine();

            Console.WriteLine("Please, enter your birthdate");
            birthdate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Please, enter your gender('f' for female or 'm' for male)");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Please, enter your profession");
            profession = Console.ReadLine();

            Console.WriteLine("Please, enter the number of years of experience you have");
            yearsOfExperience = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please, enter your yearly gross salary");
            grossYearlySalary = Convert.ToDecimal(Console.ReadLine());

            // Showing the full profile to the user
            Console.WriteLine();
            Console.WriteLine("Thanks, here is the information we got from you:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Full Name: " + lastName.ToUpper() + ", " + name);
            Console.WriteLine("Birthdate: " + birthdate);
            Console.WriteLine("Age: " + (DateTime.Now.Year - birthdate.Year));
            Console.WriteLine("Gender: " + gender.ToString().ToUpper());
            Console.WriteLine("Profession: " + profession.Replace(' ', '_'));
            Console.WriteLine("Years of Experience: " + yearsOfExperience);
            Console.WriteLine("Monthly Gross Salary: " + grossYearlySalary / 12);
        }
    }
}
