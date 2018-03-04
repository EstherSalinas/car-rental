using System;

namespace CsIntro
{
    class ClassesExercises
    {
        public void BuildUserProfile()
        {
            bool isDataCorrect = false;
            var profile = new UserProfile();

            while (isDataCorrect == false)
            {
                this.FillUserProfile(profile);
                this.ShowUserProfile(profile);
                isDataCorrect = this.IsDataCorrect();
            }

            Console.WriteLine("Thank you, the user profile was registered correctly");
        }

        private void FillUserProfile(UserProfile profile)
        {
            Console.Clear();

            Console.WriteLine("Please, enter your name");
            profile.SetName(Console.ReadLine());

            Console.WriteLine("Please, enter your last name");
            profile.SetLastName(Console.ReadLine());

            Console.WriteLine("Please, enter your birthdate");
            profile.SetBirthdate(DateTime.Parse(Console.ReadLine()));

            Console.WriteLine("Please, enter your gender('f' for female or 'm' for male)");
            profile.SetGender(Convert.ToChar(Console.ReadLine()));

            Console.WriteLine("Please, enter your profession");
            profile.SetProfession(Console.ReadLine());

            Console.WriteLine("Please, enter the number of years of experience you have");
            profile.SetYearsOfExperience(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Please, enter your yearly gross salary");
            profile.SetGrossYearlySalary(Convert.ToDecimal(Console.ReadLine()));
        }

        private void ShowUserProfile(UserProfile profile)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the information of the user:");
            Console.WriteLine("Name: " + profile.Name);
            Console.WriteLine("Last Name: " + profile.LastName);
            Console.WriteLine("Full Name: " + profile.FullName);
            Console.WriteLine("Birthdate: " + profile.Birthdate);
            Console.WriteLine("Age: " + profile.Age);
            Console.WriteLine("Gender: " + profile.Gender);
            Console.WriteLine("Profession: " + profile.Profession);
            Console.WriteLine("Years of Experience: " + profile.YearsOfExperience);
            Console.WriteLine("Seniority Level: " + profile.Seniority);
            Console.WriteLine("Monthly Gross Salary: " + profile.GrossMonthlySalary);
        }

        private bool IsDataCorrect()
        {
            Console.WriteLine();
            Console.WriteLine("Is data correct? (yes/no)");
            return Console.ReadLine().ToUpper() == "YES";
        }

    }

    class UserProfile
    {

        private const string female = "Female";
        private const string male = "Male";

        private string name;
        private string lastName;
        private DateTime birthdate;
        private char gender;
        private string profession;
        private int yearsOfExperience;
        private decimal grossYearlySalary;

        public string Name => this.name;
        public string LastName => this.lastName;
        public string FullName => string.Format("{0}, {1}", this.lastName.ToUpper(), this.name);
        public DateTime Birthdate => this.birthdate;
        public int Age => (DateTime.Now.Year - this.birthdate.Year);
        public string Gender => this.gender.ToString().ToUpper() == "F" ? female : male;
        public string Profession => this.profession.Replace(" ", "_");
        public int YearsOfExperience => this.yearsOfExperience;
        public string Seniority
        {
            get
            {
                string userSeniority;
                switch (yearsOfExperience)
                {
                    case int n when (n <= 2):
                        userSeniority = SeniorityList.Junior.ToString();
                        break;
                    case int n when (n > 2 && n < 5):
                        userSeniority = SeniorityList.Pro.ToString();
                        break;
                    case int n when (n >= 5 && n < 10):
                        userSeniority = SeniorityList.Senior.ToString();
                        break;
                    case int n when (n > 10):
                        userSeniority = SeniorityList.Manager.ToString();
                        break;
                    default:
                        userSeniority = SeniorityList.Undefined.ToString();
                        break;
                }

                return userSeniority;
            }
        }
        public decimal GrossYearlySalary => this.grossYearlySalary;
        public decimal GrossMonthlySalary => this.grossYearlySalary / 12;

        public UserProfile() { }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public void SetBirthdate(DateTime birthdate)
        {
            this.birthdate = birthdate;
        }

        public void SetGender(char gender)
        {
            this.gender = gender;
        }

        public void SetProfession(string profession)
        {
            this.profession = profession;
        }

        public void SetYearsOfExperience(int yearsOfExperience)
        {
            this.yearsOfExperience = yearsOfExperience;
        }

        public void SetGrossYearlySalary(decimal grossYearlySalary)
        {
            this.grossYearlySalary = grossYearlySalary;
        }
    }

    public enum SeniorityList
    {
        Junior,

        Pro,

        Senior,

        Manager,

        Undefined
    }
}
