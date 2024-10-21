using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Creation_DesignPattern
{
    // Abstract Factory Design Pattern
    // Abstract Factory Design Pattern is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
    // Abstract Factory Design Pattern is a super-factory which creates other factories.
    // Abstract Factory Design Pattern is also known as Factory of Factories.
    public interface IDevice
    {
        string GetDeviceName();
    }

    public class HPLaptop : IDevice
    {
        public string GetDeviceName()
        {
            return "HP Laptop";
        }
    }
    public class HPMobile : IDevice
    {
        public string GetDeviceName()
        {
            return "HP Mobile";
        }
    }

    public class HPDesktop : IDevice
    {
        public string GetDeviceName()
        {
            return "HP Desktop";
        }
    }

    public class LenovoLaptop : IDevice
    {
        public string GetDeviceName()
        {
            return "Lenovo Laptop";
        }
    }
    public class LenovoMobile : IDevice
    {
        public string GetDeviceName()
        {
            return "Lenovo Mobile";
        }
    }

    public class LenovoDesktop : IDevice
    {
        public string GetDeviceName()
        {
            return "Lenovo Desktop";
        }
    }

    public interface IDeviceFactory
    {
        IDevice CreateMobile();
        IDevice CreateLaptop();
        IDevice CreateDesktop();
    }

    public class HPDeviceFactory : IDeviceFactory
    {
        public IDevice CreateDesktop()
        {
            return new HPDesktop();
        }

        public IDevice CreateLaptop()
        {
            return new HPLaptop();
        }

        public IDevice CreateMobile()
        {
            return new HPMobile();
        }
    }

    public class LenovoDeviceFactory : IDeviceFactory
    {
        public IDevice CreateDesktop()
        {
            return new LenovoDesktop();
        }

        public IDevice CreateLaptop()
        {
            return new LenovoLaptop();
        }

        public IDevice CreateMobile()
        {
            return new LenovoMobile();
        }
    }

    public class AbstractFactory
    {
        //public static void Main(string[] args)
        //{
        //    IDeviceFactory deviceFactory = new HPDeviceFactory();
        //    IDevice hpLaptop = deviceFactory.CreateLaptop();
        //    IDevice hpMobile = deviceFactory.CreateMobile();
        //    IDevice hpDesktop = deviceFactory.CreateDesktop();

        //    Console.WriteLine(hpLaptop.GetDeviceName());
        //    Console.WriteLine(hpMobile.GetDeviceName());
        //    Console.WriteLine(hpDesktop.GetDeviceName());

        //    deviceFactory = new LenovoDeviceFactory();
        //    IDevice lenovoLaptop = deviceFactory.CreateLaptop();
        //    IDevice lenovoMobile = deviceFactory.CreateMobile();
        //    IDevice lenovoDesktop = deviceFactory.CreateDesktop();

        //    Console.WriteLine(lenovoLaptop.GetDeviceName());
        //    Console.WriteLine(lenovoMobile.GetDeviceName());
        //    Console.WriteLine(lenovoDesktop.GetDeviceName());

        //    Console.ReadKey();
        //}
    }
}