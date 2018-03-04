using System.Collections.Generic;

namespace CsIntro.HelperClasses
{
    class User
    {
        public string Name { get; }
        public int Age { get; }
        public string Country { get; }

        public User(string name, int age, string country)
        {
            this.Name = name;
            this.Age = age;
            this.Country = country;
        }

        public static List<User> GetUsersList()
        {
            var users = new List<User>();
            users.Add(new User("Bob", 30, "US"));
            users.Add(new User("Cheryl", 35, "Canada"));
            users.Add(new User("Martin", 22, "US"));
            users.Add(new User("Lorraine", 40, "Canada"));
            users.Add(new User("Sandra", 32, "Spain"));
            return users;
        }
    }
}
