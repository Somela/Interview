using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns
{
    public interface ITarget
    {
        string GetRequest();
    }

    class Adaptee
    {
        public string SpecificRequest()
        {
           return "Specific Request";
        }
    }

    class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;
        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public string GetRequest()
        {
           return $"This is '{_adaptee.SpecificRequest()}'";
        }
    }

    //class Program
    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    Adaptee adaptee = new Adaptee();
        //    ITarget target = new Adapter(adaptee);
        //    Console.WriteLine("Adaptee interface is incompatible with the client.");
        //    Console.WriteLine("But with adapter client can call it's method.");

        //    Console.WriteLine(target.GetRequest());
        //    Console.ReadLine();
        //}
    }   
}
