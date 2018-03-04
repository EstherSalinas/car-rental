using CarRentalAgency.Model;
using System.Collections.Generic;

namespace CarRentalAgency.Services
{
    public class CarService
    {
        List<Car> cars;

        public CarService()
        {
            this.cars = new List<Car>();
            this.CreateHardcodedCars();
        }

        public List<Car> GetCars()
        {
            return this.cars;
        }

        public void BlockCar(string carId)
        {
            var index = this.cars.FindIndex(car => car.Id == carId);
            this.cars[index].Block();
        }

        private void CreateHardcodedCars()
        {
            this.cars.Add(new Car("Seat", "Ibiza", EnergyType.Gas, 50, 300, 0.006m, 200));
            this.cars.Add(new Car("VW", "Golf", EnergyType.Electric, 70, 300, 0.006m, 250));
            this.cars.Add(new Car("Peugeot", "3008", EnergyType.Diesel, 90, 300, 0.006m, 300));
            this.cars.Add(new Car("Audi", "A4", EnergyType.Diesel, 120, 300, 0.006m, 400));
            this.cars.Add(new Car("Mercedes", "GLE Coupe", EnergyType.Hybrid, 160, 300, 0.006m, 600));
        }
    }
}
