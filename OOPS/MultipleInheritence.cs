using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.OOPS
{
    public interface intf1
    {
        void message();
    }
    public interface intf2
    {
        void message();
    }
    public class child : intf1, intf2
    {
        public void message()
        {
            Console.WriteLine("multiple inheritance using interface");
        }
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        child c = new child();
    //        c.message();
    //        Console.ReadKey();

    //    }
    //}
}
