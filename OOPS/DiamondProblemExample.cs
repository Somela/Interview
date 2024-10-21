using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOPS.DiamondProblemExample
{
    public class A
    {
        public virtual void Print()
        {
            Console.WriteLine("Print method of class A.");
        }
    }
    public class B : A
    {
        public override void Print()
        {
            Console.WriteLine("Print method of class B");
        }
    }
    public class C : A
    {
        public override void Print()
        {
            Console.WriteLine("Print method of class C");
        }
    }

    //Error: D class can not have multiple base classes.
    //public class D : C, B
    //{

    //}

    public class DiamondProblemExample
    {
        //public static void Main(string[] args)
        //{
        //    D d = new D();
        //    d.Print();
        //    Console.ReadKey();
        //}
    }
}
