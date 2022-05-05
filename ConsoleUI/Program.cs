using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            var vehicles = new List<Vehicle>();

            var car1 = new Car()
            {
                Year = "2013",
                Make = "Toyota",
                Model = "4Runner TRD",
                hasDoors = true,
                HasTrunk = true
            };

            var motorcycle1 = new Motorcycle()
            {
                Year = "2022",
                Make = "Ducati",
                Model = "DesertX",
                HasSideCart = true
            };

            Vehicle car2 = new Car()
            {
                Year = "2020",
                Make = "Honda",
                Model = "Civic",
                hasDoors = true,
                HasTrunk = true
            };

            Vehicle motorcycle2 = new Motorcycle()
            {
                Year = "2019",
                Make = "Can-Am",
                Model = "Spyder",
                HasSideCart = false
            };

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}, Vehicle Has Doors: {item.hasDoors}\n");
            }
        
            Console.WriteLine($"Motion : {car1.DriveAbstract()}");
            Console.WriteLine($"Motion : {motorcycle1.DriveAbstract()}");
            Console.WriteLine();
            Console.WriteLine($"Cars drive {car1.DriveVirtual()}");
            Console.WriteLine($"Motorcycles do {motorcycle1.DriveVirtual()}");
        }
    }
}
