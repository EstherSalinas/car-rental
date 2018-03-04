using System.Collections.Generic;

namespace CsIntro.HelperClasses
{
    class Month
    {
        public string Name { get; }

        public string Season { get; }

        public int Days { get; }

        public Month(string name, string season, int days)
        {
            this.Name = name;
            this.Season = season;
            this.Days = days;
        }

        public static List<Month> GetMonthsList()
        {
            var months = new List<Month>();
            months.Add(new Month("January", "Winter", 31));
            months.Add(new Month("February", "Winter", 28));
            months.Add(new Month("March", "Spring", 31));
            months.Add(new Month("April", "Spring", 30));
            months.Add(new Month("May", "Spring", 31));
            months.Add(new Month("June", "Summer", 30));
            months.Add(new Month("July", "Summer", 31));
            months.Add(new Month("August", "Summer", 31));
            months.Add(new Month("September", "Fall", 30));
            months.Add(new Month("October", "Fall", 31));
            months.Add(new Month("November", "Fall", 30));
            months.Add(new Month("December", "Winter", 31));
            return months;
        }
    }
}
