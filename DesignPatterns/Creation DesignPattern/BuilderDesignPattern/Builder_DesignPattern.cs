using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.BuilderDesignPattern
{
    // Builder Design Pattern
    // The Builder Design Pattern is a creational design pattern that lets you construct complex objects step by step.
    // The pattern allows you to produce different types and representations of an object using the same construction code.
    // The Builder Design Pattern is a good choice when designing classes whose constructors or static factories would have more than a handful of parameters.
    public interface IBuilder
    {
        void StartingOperations();
        string BuildBody();
        string InsertWheels();
        string AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }

    public class Car : IBuilder
    {
        private string _vehicleType;
        private Product _product = new Product();
        public Car(string vehicleType)
        {
            _vehicleType = vehicleType;
        }
        public void StartingOperations()
        {
            _product.Add(string.Format("Product: {0}", _vehicleType));
        }
        public string BuildBody()
        {
            return "Body of the car is built";
        }
        public string InsertWheels()
        {
            return "4 Wheels are added";
        }
        public string AddHeadlights()
        {
            return "Headlights are added";
        }
        public void EndOperations()
        {
            _product.Add("Car model is assembled");
        }
        public Product GetVehicle()
        {
            return _product;
        }
    }

    public class Bike : IBuilder
    {
        private string _vehicleType;
        private Product _product = new Product();
        public Bike(string vehicleType)
        {
            _vehicleType = vehicleType;
        }
        public void StartingOperations()
        {
            _product.Add(string.Format("Product: {0}", _vehicleType));
        }
        public string BuildBody()
        {
            return "Body of the bike is built";
        }
        public string InsertWheels()
        {
            return "2 Wheels are added";
        }
        public string AddHeadlights()
        {
            return "Headlights are added";
        }
        public void EndOperations()
        {
            _product.Add("Bike model is assembled");
        }
        public Product GetVehicle()
        {
            return _product;
        }
    }

    public class Director
    {
        private IBuilder? _builder;
        public void Construct(IBuilder builder)
        {
            _builder = builder;
            _builder.StartingOperations();
            _builder.BuildBody();
            _builder.InsertWheels();
            _builder.AddHeadlights();
            _builder.EndOperations();
            _builder.GetVehicle();
        }
    }

    public class Product
    {
        private List<object> _parts = new List<object>();
        public void Add(string part)
        {
            _parts.Add(part);
        }
        public string Show()
        {
            string str = "";
            foreach (var part in _parts)
            {
                str += part + "\n";
            }
            return str;
        }
    }

    public class BuilderDS
    {
        //public static void Main(string[] args)
        //{
        //    Director director = new Director();
        //    IBuilder car = new Car("Car");
        //    IBuilder bike = new Bike("Bike");
        //    director.Construct(car);
        //    Product p1 = car.GetVehicle();
        //    Console.WriteLine("Car parts are:");
        //    Console.WriteLine(p1.Show());
        //    director.Construct(bike);
        //    Product p2 = bike.GetVehicle();
        //    Console.WriteLine("Bike parts are:");
        //    Console.WriteLine(p2.Show());
        //}
    }
}
