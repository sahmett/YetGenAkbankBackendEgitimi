using CarRentalPro.Entitiy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalPro.Service
{
    public class RentalService
    {
        public static List<Car> availableCars = new List<Car>()
        {
        new Car("Toyota Corolla"),
        new Car("Honda Civic"),
        new Car("Ford Focus"),
        new Car("Fiat Egea")
        };

        public static List<Car> rentedCars = new List<Car>();



        public static void RentCar()
        {
            Console.WriteLine("Enter the car you want to rent: ");
            string carToRent = Console.ReadLine();

            // if (availableCars.Brand.Contains(carToRent))
            Car selectedCar = availableCars.FirstOrDefault(car => car.Brand == carToRent);
            bool has = availableCars.Any(car => car.Brand == carToRent);

            if (selectedCar != null)
            {
                availableCars.Remove(selectedCar);
                rentedCars.Add(selectedCar);
                Console.WriteLine("You have rented a " + selectedCar.Brand);
            }
            else
            {
                Console.WriteLine("Sorry, the selected car is not available.");
            }
        }

        public static void ReturnCar()
        {
            Console.WriteLine("Enter the car you want to return: ");
            string carToReturn = Console.ReadLine();

            //if (rentedCars.Contains(carToReturn)!)
            Car selectedCar = availableCars.FirstOrDefault(car => car.Brand == carToReturn);
            if (selectedCar != null)
            {
                rentedCars.Remove(selectedCar);
                availableCars.Add(selectedCar);
                Console.WriteLine("You have returned a " + selectedCar.Brand);
            }
            else
            {
                Console.WriteLine("Sorry, you did not rent this car from us.");
            }
        }

        public static void ListAvailableCars()
        {
            Console.WriteLine("Available cars:");
            foreach (var car in availableCars)
            {
                Console.WriteLine(car.Brand);
            }
        }
    }
}
