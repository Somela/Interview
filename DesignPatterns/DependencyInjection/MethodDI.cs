using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.DependencyInjection
{
    public interface IStudentMethodService
    {
        List<Student> GetStudentsDAL();
    }

    public class StudentMethodService : IStudentMethodService
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

    public class StudentMethodDI
    {
        private IStudentMethodService _studentMethodService;
        public void SetStudentMethodService(IStudentMethodService studentMethodService)
        {
            _studentMethodService = studentMethodService;
        }
        public List<Student> GetStudents()
        {
            return _studentMethodService.GetStudentsDAL();
        }
    }

    public class Program
    {
        //public static void Main(string[] args)
        //{
        //    StudentMethodDI studentMethodDI = new StudentMethodDI();
        //    studentMethodDI.SetStudentMethodService(new StudentMethodService());
        //    studentMethodDI.GetStudents().ForEach(student => Console.WriteLine("Id: " + student.Id + " Name: " + student.Name));
        //}
    }
}
