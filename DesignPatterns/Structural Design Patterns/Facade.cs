using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    public interface IPizzaInterface
    {
        void NonVegPizza();
        void VegPizza();
    }
    public interface IBreadInterface
    {
        void GarlicBread();
        void CheeseBread();
    }

    public interface IBurgerInterface
    {
        void VegBurger();
        void NonVegBurger();
        void GarlicBurger();
        void CheeseBurger();
    }

    public class Pizza : IPizzaInterface
    {
        public void NonVegPizza()
        {
            Console.WriteLine("Non Veg Pizza");
        }

        public void VegPizza()
        {
            Console.WriteLine("Veg Pizza");
        }
    }

    public class Bread : IBreadInterface
    {
        public void CheeseBread()
        {
            Console.WriteLine("Cheese Bread");
        }

        public void GarlicBread()
        {
            Console.WriteLine("Garlic Bread");
        }
    }

    public class Burger : IBurgerInterface
    {
        public void CheeseBurger()
        {
            Console.WriteLine("Cheese Burger");
        }

        public void GarlicBurger()
        {
            Console.WriteLine("Garlic Burger");
        }

        public void NonVegBurger()
        {
            Console.WriteLine("Non Veg Burger");
        }

        public void VegBurger()
        {
            Console.WriteLine("Veg Burger");
        }
    }

    public class FoodRestaurentFacade
    {
        private IPizzaInterface _pizza;
        private IBreadInterface _bread;
        private IBurgerInterface _burger;

        public FoodRestaurentFacade()
        {
            _pizza = new Pizza();
            _bread = new Bread();
            _burger = new Burger();
        }

        public void GetNonVegPizza()
        {
            _pizza.NonVegPizza();
        }

        public void GetVegPizza()
        {
            _pizza.VegPizza();
        }

        public void GetCheeseBread()
        {
            _bread.CheeseBread();
        }

        public void GetGarlicBread()
        {
            _bread.GarlicBread();
        }

        public void GetCheeseBurger()
        {
            _burger.CheeseBurger();
        }

        public void GetGarlicBurger()
        {
            _burger.GarlicBurger();
        }

        public void GetNonVegBurger()
        {
            _burger.NonVegBurger();
        }

        public void GetVegBurger()
        {
            _burger.VegBurger();
        }
    }

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    FoodRestaurentFacade foodFacade = new FoodRestaurentFacade();
        //    foodFacade.GetNonVegPizza();
        //    foodFacade.GetVegPizza();
        //    foodFacade.GetCheeseBread();
        //    foodFacade.GetGarlicBread();
        //    foodFacade.GetCheeseBurger();
        //    foodFacade.GetGarlicBurger();
        //    foodFacade.GetVegBurger();
        //    foodFacade.GetNonVegBurger();
        //}
    }
}
