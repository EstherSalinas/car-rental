using System.Collections.Generic;

namespace CsIntro.HelperClasses
{
    class TrainingCenter
    {
        public string Name { get; }
        public string Country { get; }

        public TrainingCenter(string name, string country)
        {
            this.Name = name;
            this.Country = country;
        }

        public static List<TrainingCenter> GetTrainingCentersList()
        {
            var centers = new List<TrainingCenter>();
            centers.Add(new TrainingCenter("Knowtech", "Spain"));
            centers.Add(new TrainingCenter("Udacity", "US"));
            centers.Add(new TrainingCenter("Code School", "US"));
            return centers;
        }
    }
}
