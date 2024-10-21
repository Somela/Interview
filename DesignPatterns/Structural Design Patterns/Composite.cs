using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    //Creating IComponent Interface
    public interface IComponent
    {
        void GetPrice();
    }

    //Creating Leaf Class

    public class Leaf : IComponent
    {
        public int Price { get; set; }
        public string Name { get; set; }
        public void GetPrice()
        {
            Console.WriteLine($"\tComponent Name: {Name} and Price: {Price}");
        }
    }

    //Creating Composite Class
    public class Composite : IComponent
    {
        public string Name { get; set; }
        public Composite(string name)
        {
            Name = name;
        }
        List<IComponent> components = new List<IComponent>();
        public void AddComponent(IComponent component)
        {
            components.Add(component);
        }
        public void GetPrice()
        {
            foreach (var component in components)
            {
                component.GetPrice();
            }
        }
    }

    //Client Program
    public class CompositeDesignPattern
    {
        //public static void Main(string[] args)
        //{
        //    Leaf leaf1 = new Leaf { Name = "Leaf1", Price = 100 };
        //    Leaf leaf2 = new Leaf { Name = "Leaf2", Price = 200 };
        //    Leaf leaf3 = new Leaf { Name = "Leaf3", Price = 300 };
        //    Leaf leaf4 = new Leaf { Name = "Leaf4", Price = 400 };
        //    Leaf leaf5 = new Leaf { Name = "Leaf5", Price = 500 };
        //    Leaf leaf6 = new Leaf { Name = "Leaf6", Price = 600 };
        //    Leaf leaf7 = new Leaf { Name = "Leaf7", Price = 700 };
        //    Leaf leaf8 = new Leaf { Name = "Leaf8", Price = 800 };
        //    Leaf leaf9 = new Leaf { Name = "Leaf9", Price = 900 };
        //    Leaf leaf10 = new Leaf { Name = "Leaf10", Price = 1000 };

        //    Composite composite1 = new Composite("Composite1");
        //    composite1.AddComponent(leaf1);
        //    composite1.AddComponent(leaf2);
        //    composite1.AddComponent(leaf3);

        //    Composite composite2 = new Composite("Composite2");
        //    composite2.AddComponent(leaf4);
        //    composite2.AddComponent(leaf5);
        //    composite2.AddComponent(leaf6);

        //    Composite composite3 = new Composite("Composite3");
        //    composite3.AddComponent(leaf7);
        //    composite3.AddComponent(leaf8);
        //    composite3.AddComponent(leaf9);
        //    composite3.AddComponent(leaf10);

        //    Composite composite4 = new Composite("Composite4");
        //    composite4.AddComponent(composite1);
        //    composite4.AddComponent(composite2);
        //    composite4.AddComponent(composite3);

        //    composite4.GetPrice();
        //    Console.ReadLine();
        //}
    }
}
