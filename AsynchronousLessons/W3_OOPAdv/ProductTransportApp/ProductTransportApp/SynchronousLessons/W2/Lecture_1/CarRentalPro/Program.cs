using CarRentalPro;

namespace Lecture_1.Part_2.CarRentalPro;
public class Program
{

    static void Main(string[] args)
    {

        
        RentalService rentalService = new RentalService();

        Console.WriteLine("Welcome to the Car Rental System");
        bool exit = false;


        while (!exit)
        {
            Console.WriteLine("\n1. Rent a car");
            Console.WriteLine("2. Return a car");
            Console.WriteLine("3. List available cars");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    rentalService.RentCar();
                    break;
                case "2":
                    rentalService.ReturnCar();
                    break;
                case "3":
                    rentalService.ListAvailableCars();
                    break;
                case "4":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

}