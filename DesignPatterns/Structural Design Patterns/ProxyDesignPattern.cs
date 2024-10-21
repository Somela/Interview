using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    public interface IEmployeeInterface
    {
        double getSalary(int employeeId);
        double getTax(int employeeId);
    }

    public class Employee : IEmployeeInterface
    {
        public double getSalary(int employeeId)
        {
            return 10000;
        }

        public double getTax(int employeeId)
        {
            return 1000;
        }
    }

    public class ProxyEmployee : IEmployeeInterface
    {
        private Employee _employee = new Employee();
        public double getSalary(int employeeId)
        {
            return _employee.getSalary(employeeId);
        }

        public double getTax(int employeeId)
        {
            return _employee.getTax(employeeId);
        }
    }

    public class ProxyDesignPattern
    {
        public static void Main(string[] args)
        {
            IEmployeeInterface employee = new ProxyEmployee();
            Console.WriteLine(employee.getSalary(1));
            Console.WriteLine(employee.getTax(1));
        }
    }
}
