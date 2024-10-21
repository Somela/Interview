using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOPS
{
    public partial class PartialClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
    }

    public partial class PartialClass
    {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        PartialClass p = new PartialClass();
    //        p.Method1();
    //        p.Method2();
    //        Console.ReadKey();
    //    }
    //}
}
