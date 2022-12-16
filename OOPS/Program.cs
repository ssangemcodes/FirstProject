using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Car honda = new Car(); //instance creation, object creation
            //Car toyota = new Car();
            //var hyundai = new Car();

            ////honda.ModelName = "Honda"; //dot notation
            ////honda.ModelYear = "2022";

            ////toyota.ModelName = "Toyota";

            //Car gmc = new Car("GMC", "2022", "blue", 60000.00f, "luxury"); // use new keyword to create an object

            //Console.WriteLine(gmc.ModelName);
            //Console.WriteLine(gmc.ModelYear);
            //Console.WriteLine(gmc.Color);
            //Console.WriteLine(gmc.Price);
        
            //Car gmc1 = new Car("GMC", "2021", "Green", 50000.00f, "sedan");

            
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine(gmc1.ModelName);
            //Console.WriteLine(gmc1.ModelYear);
            //Console.WriteLine(gmc1.Color);
            //Console.WriteLine(gmc1.Price);

            var dVehicle = new DisplayProperties();

            var vehicle = new Vehicle("GMC", "2022", "blue", 60000.00f);
            dVehicle.DisplayVehicle(vehicle);

            Car car = new Car("GMC", "2021", "Green", 50000.00f, "sedan");
            dVehicle.DisplayVehicle(car); //this is an example of polymorphism

            Console.ReadLine();

        }
    }

    public class DisplayProperties
    {
        public void DisplayVehicle(Vehicle vehicle)
        {
            Console.WriteLine("Model Name: " + vehicle.ModelName);
            Console.WriteLine("Model Year: " + vehicle.ModelYear);
            Console.WriteLine("Color: " + vehicle.Color);
            Console.WriteLine("Price: " + vehicle.Price);
        }

    }

    //Inheritance

    public class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(string modelName, string modelYear, string color, float price)
        {
            ModelName = modelName;
            ModelYear = modelYear;
            Color = color;
            Price = price;
        }

        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public string Color { get; set; }
        public float Price { get; set; }
    }

    public class Truck : Vehicle //syntax for inheritance
    {
       public string TruckType { get; set; }
    }

    public class Car : Vehicle // class definition of Car
    {
        public string CarClass { get; set; }
        public Car()
        {

        }

        public Car(string modelName, string modelYear, string color, float price, string carClass) : base(modelName, modelYear, color, price)
        {
            CarClass = carClass;
        }
    }

    public class Student //Encapsulation - grouping related data together
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSSN { get; set; }
        public Address StudentAddress { get; set; }
    }

    public class Address
    {
        public int AddressId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
    }
}

//value types, int, char, float, decimal, structure

//reference types, string, classes/objects refernce types

//value types are stored in stack (faster access, think of it as wallet)

//reference types are stored on Heap (can store more data, think of it as bank)


//base classes, super classes
//derived classes, sub class
