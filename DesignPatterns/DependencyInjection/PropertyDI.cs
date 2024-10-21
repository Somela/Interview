using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.DependencyInjection
{
    public interface IStudentPropertyService
    {
        List<Student> GetStudentsDAL();
    }

    public class StudentPropertyService : IStudentPropertyService
    {
        public List<Student> GetStudentsDAL()
        {
            return new List<Student>
         {
             new Student { Id = 1, Name = "John" },
             new Student { Id = 2, Name = "Steve" },
             new Student { Id = 3, Name = "Bill" }
         };
        }
    }

    public class ProperyDI
    {
        private IStudentPropertyService _studentPropertyService;
        public IStudentPropertyService StudentPropertyService
        {
            set
            {
                _studentPropertyService = value;
            }
        }
        public List<Student> GetStudents()
        {
            return _studentPropertyService.GetStudentsDAL();
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        ProperyDI studentDAL = new ProperyDI();
    //        studentDAL.StudentPropertyService = new StudentPropertyService();
    //        List<Student> students = studentDAL.GetStudents();
    //        foreach (var student in students)
    //        {
    //            Console.WriteLine("Id: " + student.Id + " Name: " + student.Name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
