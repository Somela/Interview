using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Creation_DesignPattern.FactoryDesignPattern
{
    public interface IACCompany
    {
        string GetACName();
        int ACPrice();
        int ACWarranty();
        string ACType();
    }
    public class LG : IACCompany
    {
        public string GetACName()
        {
            return "LG";
        }
        public int ACPrice()
        {
            return 30000;
        }
        public int ACWarranty()
        {
            return 2;
        }
        public string ACType()
        {
            return "Split";
        }
    }
    public class Samsung : IACCompany
    {
        public string GetACName()
        {
            return "Samsung";
        }
        public int ACPrice()
        {
            return 35000;
        }
        public int ACWarranty()
        {
            return 3;
        }
        public string ACType()
        {
            return "Window";
        }
    }
    public class ACFactory
    {
        public IACCompany GetACCompany(string ACCompany)
        {
            if (ACCompany == null)
            {
                return null;
            }
            if (ACCompany.Equals("LG"))
            {
                return new LG();
            }
            else if (ACCompany.Equals("Samsung"))
            {
                return new Samsung();
            }
            return null;
        }
    }

    public class FactoryDesignPattern
    {
        //public static void Main(string[] args)
        //{
        //    string ACCompany = "LG";
        //    IACCompany acFactory = null;

        //    if(ACCompany == "LG")
        //    {
        //        acFactory = new LG();
        //    }
        //    else if (ACCompany == "Samsung")
        //    {
        //        acFactory = new Samsung();
        //    }

        //    Console.WriteLine("AC Name: " + acFactory.GetACName());
        //    Console.WriteLine("AC Price: " + acFactory.ACPrice());
        //    Console.WriteLine("AC Warranty: " + acFactory.ACWarranty());
        //    Console.WriteLine("AC Type: " + acFactory.ACType());
        //    Console.ReadLine();
        //}
    }
}
