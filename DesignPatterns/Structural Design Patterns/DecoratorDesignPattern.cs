using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    public interface ICar
    {
        string GetDescription();
        double GetCost();
    }

    public class BasicCar : ICar
    {
        public string GetDescription()
        {
            return "Basic Car";
        }
        public double GetCost() {
            return 10000.0;
        }
    }
    public class LuxuryCar : ICar 
    {
        public string GetDescription()
        {
            return "Luxury Car";
        }
        public double GetCost()
        {
            return 20000.0;
        }
    }

    public class DeluxeCar : ICar
    {
        public double GetCost()
        {
            return 30000.0;
        }

        public string GetDescription()
        {
            return "Deluxe Car";
        }
    }

    public abstract class CarDecorator : ICar
    {
        private ICar _car;
        public CarDecorator(ICar car)
        {
            _car = car;
        }
        public virtual string GetDescription()
        {
            return _car.GetDescription();
        }
        public virtual double GetCost()
        {
            return _car.GetCost();
        }
    }

    public class BasicAccessories : CarDecorator
    {
        public BasicAccessories(ICar car) : base(car) { }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Basic Accessories Package";
        }
        public override double GetCost()
        {
            return base.GetCost() + 5000.0;
        }
    }

    public class LuxuryAccessories : CarDecorator
    {
        public LuxuryAccessories(ICar car) : base(car) { }
        public override string GetDescription()
        {
            return base.GetDescription() + ", Luxury Accessories Package";
        }
        public override double GetCost()
        {
            return base.GetCost() + 10000.0;
        }
    }

    public class DecoratorDesignPattern
    {
        //public static void Main(string[] args)
        //{
        //    ICar car = new LuxuryCar();
        //    CarDecorator decorator = new BasicAccessories(car);
        //    decorator = new LuxuryAccessories(decorator);
        //    Console.Write("Car Detials: " + decorator.GetDescription());
        //    Console.WriteLine("\n\n");
        //    Console.Write("Total Price: " + decorator.GetCost());

        //    Console.Read();
        //}
    }
}
