using System;

namespace CarRentalAgency.Model
{
    public class Customer : BaseModel
    {
        private string name;
        private string lastName;
        private DateTime birthdate;
        private string drivingLicense;
        // TODO: List of rentals to have customer's history

        public string Name => this.name;
        public string LastName => this.lastName;
        public string FullName => string.Format("{0} {1}", this.name, this.lastName);
        public DateTime Birthdate => this.birthdate;
        public string DrivingLicense => this.drivingLicense;

        private Customer(string id = null) : base(id) { }

        public Customer(string name, string lastName, DateTime birthdate, string drivingLicense, string id = null)
            : this(id)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthdate = birthdate;
            this.drivingLicense = drivingLicense;
        }
    }
}
