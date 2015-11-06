using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiPark.CarHierarchy.CarClasses.Business.Models;
using TaxiPark.CarHierarchy.CarClasses.Comfort.Models;
using TaxiPark.CarHierarchy.CarClasses.Econom.Models;

namespace TaxiPark
{
    public class TaxiParkCars
    {
        private List<Car> CarList = new List<Car>()
        {
            new BMW("750","Black","Sedan",30000,11, 25,0001),
            new BMW("X5","White","SUV",37000,13, 27, 0002),
            new BMW("530d","Black","Sedan",25000,10, 25, 0003),
            new Mercedes("S500","Black","Sedan",40000,14, 30, 0004),
            new Mercedes("E300","Blue","Sedan",25000,12,25,0005),
            new Audi("A6","Grey","Wagon",20000,12,20,0006),
            new Audi("A4","Grey","Sedan",19000,11,19,0007),
            new VW("Passat","Black","Wagon",18000,9,20,0008),
            new Ford("Focus","Yellow","Hatchback",12000,9,15,0009),
            new Hyundai("Solaris","Yellow","Sedan",10000,8,13,0010)
        };

        public void ParkTotalprice()
        {
            int carCount = CarList.Count();
            int totalprice = CarList.Sum(car => car.carPrice);
            Console.WriteLine("Taxi Park consists of {0} cars", carCount);
            Console.WriteLine("Total price of all the cars: {0} $", totalprice);
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void OrderCarsByfuelConsumption()
        {
            Console.WriteLine("\nCars from TaxiPark ordered by Fuel Consumption: \n");
            var orderedCars = CarList.OrderBy(car => car.carFuelConsumption);
            foreach (var car in orderedCars)
            {
                Console.WriteLine("Car int. number: {0}, Fuel Consumption {1} litres/100km", car.carNumber, car.carFuelConsumption);
            }
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }

        public void FindCarByParameters()
        {
            //TODO: find by subclasses params & show result with this params
            Console.WriteLine("\nPlease enter car color or press [Enter] to skip this step");
            string color = Console.ReadLine();
            Console.WriteLine("Please enter car type or press [Enter] to skip this step");
            string carType = Console.ReadLine();
            Console.WriteLine("Please enter car price or press [Enter] to skip this step");
            int price;
            var x = Int32.TryParse(Console.ReadLine(), out price);
            Console.WriteLine("Please enter car fuel consumption or press [Enter] to skip this step");
            int fuelConsumption;
            var y = Int32.TryParse(Console.ReadLine(), out fuelConsumption); ;
            Console.WriteLine("Please enter car rate or press [Enter] to skip this step");
            int carRate;
            var z = Int32.TryParse(Console.ReadLine(), out carRate);
            Console.WriteLine("Please enter car number or press [Enter] to skip this step");
            int number;
            var q = Int32.TryParse(Console.ReadLine(), out number);
            List<Car> results = CarList.FindAll(c =>
            (c.carColor == color || color == "") 
            && (c.carType == carType || carType == "")
            && (c.carPrice == price || price == 0) 
            && (c.carFuelConsumption == fuelConsumption || fuelConsumption == 0)
            && (c.carRate == carRate || carRate == 0) 
            && (c.carNumber == number || number == 0));
            if (results.Count != 0)
            {
                DisplayResults(results, "The following cars match your parameters: "+"\n(color, type, price, consumption, rate, number");
            }
            else
            {
                Console.WriteLine("\nNo cars found.");
            }
            Console.ReadLine();
        }

        private static void DisplayResults(List<Car> results, string title)
        {
            Console.WriteLine("\n"+title);
            foreach (Car c in results)
            {
                Console.Write("\n{0}\t{1}\t{2}\t{3}\t{4}\t{5}", 
                    c.carColor, c.carType, c.carPrice, c.carFuelConsumption, c.carRate, c.carNumber);
            }
            Console.WriteLine();
        }
    }
}
