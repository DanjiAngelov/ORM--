using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ex88.BaseModels;

namespace ex88.cars
{
    public class cars:BaseModel
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public cars(string brand, string model, int year, double price)
        {
            Brand = brand ?? throw new ArgumentNullException(nameof(brand));
            Model = model;
            Year = year;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} ({Year}) - {Price} USD";
        }
    }

    class Program
    {
        static List<Car> carsList = new List<Car>();

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Add a car");
                Console.WriteLine("2. Show all cars");
                Console.WriteLine("3. Search car by brand");
                Console.WriteLine("4. Delete a car");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddCar();
                        break;
                    case "2":
                        ShowCars();
                        break;
                    case "3":
                        SearchCarByBrand();
                        break;
                    case "4":
                        DeleteCar();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddCar()
        {
            Console.Write("Enter brand: ");
            string brand = Console.ReadLine();
            Console.Write("Enter model: ");
            string model = Console.ReadLine();
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Enter price: ");
            double price = double.Parse(Console.ReadLine());

            Console.WriteLine("Car added successfully!");
        }

        static void ShowCars()
        {
            if (carsList.Count == 0)
            {
                Console.WriteLine("No cars available.");
                return;
            }
            Console.WriteLine("Car list:");
            for (int i = 0; i < carsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {carsList[i]}");
            }
        }

        static void SearchCarByBrand()
        {
            Console.Write("Enter brand to search: ");
            string brand = Console.ReadLine();
            var results = carsList.Where(car => car.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();

            if (results.Count == 0)
            {
                Console.WriteLine("No cars found for this brand.");
            }
            else
            {
                Console.WriteLine("Search results:");
                foreach (var car in results)
                {
                    Console.WriteLine(car);
                }
            }
        }

        static void DeleteCar()
        {
            ShowCars();
            Console.Write("Enter the number of the car to delete: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < carsList.Count)
            {
                carsList.RemoveAt(index);
                Console.WriteLine("Car deleted successfully!");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
}   }
