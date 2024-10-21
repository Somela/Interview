//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interview.DesignPatterns
//{
//    public class SingletonDesignPattern
//    {
//        private SingletonDesignPattern() { }
//        private static SingletonDesignPattern instance = null;
//        public static SingletonDesignPattern GetInstance()
//        {
//            if (instance == null)
//            {
//                instance = new SingletonDesignPattern();
//            }
//            return instance;
//        }
//        public static void PrintMessage()
//        {
//            Console.WriteLine("SingletonDesignPattern PrintMessage called");
//        }
//        public void PrintMessage(string message) {
//            Console.WriteLine("SingletonDesignPattern PrintMessage called with message: " + message);
//        }
//        public void PrintMessage(Exception exception) { }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            SingletonDesignPattern singletonDesignPattern = SingletonDesignPattern.GetInstance();
//            singletonDesignPattern.PrintMessage("Hello World");
//            SingletonDesignPattern.PrintMessage();
//            Console.ReadLine();
//        }
//    }
//}
