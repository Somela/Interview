using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns
{
    public class SingletonDesignPatternWithThreads
    {
        private SingletonDesignPatternWithThreads() {
            Console.WriteLine("SingletonDesignPatternWithThreads constructor called");
        }
        private static SingletonDesignPatternWithThreads instance = null;
        private static readonly object lockObject = new object();
        public static SingletonDesignPatternWithThreads GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new SingletonDesignPatternWithThreads();
                    }
                }
            }
            return instance;
        }

        public static void PrintMessage()
        {
            Console.WriteLine("SingletonDesignPatternWithThreads PrintMessage called");
        }

        public void PrintMessage(string message) {
            Console.WriteLine("SingletonDesignPatternWithThreads PrintMessage called with message: " + message);
        }

        public void PrintMessage(Exception exception) { }
    }
    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        SingletonDesignPatternWithThreads singletonDesignPattern = SingletonDesignPatternWithThreads.GetInstance();
    //        singletonDesignPattern.PrintMessage("Hello World");
    //        SingletonDesignPatternWithThreads.PrintMessage();
    //        Console.ReadLine();
    //    }
    //}
}
