using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOPS
{
    public class StaticClassExample
    {
        public static double convertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        public static double convertToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Enter the temperature in Fahrenheit: ");
    //        double fahrenheit = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Temperature in Celsius: " + StaticClassExample.convertToCelsius(fahrenheit));

    //        Console.WriteLine("Enter the temperature in Celsius: ");
    //        double celsius = Convert.ToDouble(Console.ReadLine());
    //        Console.WriteLine("Temperature in Fahrenheit: " + StaticClassExample.convertToFahrenheit(celsius));

    //        Console.ReadKey();
    //    }
    //}
}
