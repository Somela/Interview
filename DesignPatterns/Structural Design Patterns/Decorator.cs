using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    // Decorator Pattern
    // The decorator pattern is used to extend or alter the functionality of objects at runtime by wrapping them in an object of a decorator class.
    // This provides a flexible alternative to using inheritance to modify behaviour.
    // The decorator pattern is a structural pattern that allows adding new behaviours to objects dynamically by placing them inside special wrapper objects that contain these behaviours.
    public interface IPizzaInterfaceType
    {
        string GetPizzaType();
    }

    public class PizzaClass : IPizzaInterfaceType
    {
        public string GetPizzaType()
        {
            return "Pizza";
        }
    }
    public class PizzaDecorator : IPizzaInterfaceType  
    {
        private readonly IPizzaInterfaceType _pizza;
        public PizzaDecorator(IPizzaInterfaceType pizza)
        {
            _pizza = pizza;
        }
        public virtual string GetPizzaType()
        {
            return _pizza.GetPizzaType();
        }
    }

    public class VegPizza : PizzaDecorator
    {
        public VegPizza(IPizzaInterfaceType pizza) : base(pizza)
        {
        }
        public override string GetPizzaType()
        {
            return base.GetPizzaType() + " Veg";
        }
    }

    public class NonVegPizza : PizzaDecorator
    {
        public NonVegPizza(IPizzaInterfaceType pizza) : base(pizza)
        {
        }
        public override string GetPizzaType()
        {
            return base.GetPizzaType() + " Non Veg";
        }
    }

    public class Decorator
    {
        //public static void Main()
        //{
        //    IPizzaInterfaceType pizza = new PizzaClass();
        //    Console.WriteLine(pizza.GetPizzaType());

        //    IPizzaInterfaceType vegPizza = new VegPizza(pizza);
        //    Console.WriteLine(vegPizza.GetPizzaType());

        //    IPizzaInterfaceType nonVegPizza = new NonVegPizza(pizza);
        //    Console.WriteLine(nonVegPizza.GetPizzaType());
        //}
    }
}
