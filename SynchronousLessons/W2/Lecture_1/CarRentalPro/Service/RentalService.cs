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
            Car string carToRent = Console.ReadLine();

            if (availableCars.Contains(carToRent))
            {
                availableCars.Remove(carToRent);
                rentedCars.Add(carToRent);
                Console.WriteLine("You have rented a " + carToRent);
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

            if (rentedCars.Contains(carToReturn)!)
            {
                rentedCars.Remove(carToReturn);
                availableCars.Add(carToReturn);
                Console.WriteLine("You have returned a " + carToReturn);
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
                Console.WriteLine(car);
            }
        }
    }
}
