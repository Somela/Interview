using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.DependencyInjection
{
    public interface IStudentService
    {
        List<Student> GetStudentsDAL();
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class StudentService : IStudentService
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

    public class ConstructorDI
    {
        private IStudentService _studentService;
        public ConstructorDI(IStudentService studentService)
        {
            _studentService = studentService;
        }
        public List<Student> GetStudents()
        {
            return _studentService.GetStudentsDAL();
        }
    }

    //public class Program
    //{
    //    public static void Main(string[] args)
    //    {
    //        ConstructorDI studentDAL = new ConstructorDI(new StudentService());
    //        List<Student> students = studentDAL.GetStudents();
    //        foreach (var student in students)
    //        {
    //            Console.WriteLine("Id: " + student.Id + " Name: " + student.Name);
    //        }
    //        Console.ReadLine();
    //    }
    //}
}
