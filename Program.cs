////using Interview.OOPS;

////Console.WriteLine("Enter the temperature in Fahrenheit: ");
////double fahrenheit = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Temperature in Celsius: " + StaticClassExample.convertToCelsius(fahrenheit));

////Console.WriteLine("Enter the temperature in Celsius: ");
////double celsius = Convert.ToDouble(Console.ReadLine());
////Console.WriteLine("Temperature in Fahrenheit: " + StaticClassExample.convertToFahrenheit(celsius));

////Console.ReadKey();

////using Interview.DesignPatterns;

////SingletonDesignPatternWithThreads s1 = SingletonDesignPatternWithThreads.GetInstance();
////s1.PrintMessage("Hello");
////SingletonDesignPatternWithThreads s2 = SingletonDesignPatternWithThreads.GetInstance();
////s2.PrintMessage("Testing");
////Console.ReadKey();

//using Interview.DesignPatterns.DependencyInjection;
//using Interview.DesignPatterns.Repository;
//using Microsoft.EntityFrameworkCore;

////public class Program
////{
////    public static void Main(string[] args)
////    {
////        //IStudentService studentService = new StudentService();
////        ConstructorDI studentDAL = new ConstructorDI(new StudentService());
////        List<Student> students = studentDAL.GetStudents();
////        foreach (var student in students)
////        {
////            Console.WriteLine("Id: " + student.Id + " Name: " + student.Name);
////        }
////        Console.ReadLine();
////    }
////}

////public class Program
////{
////    public static void Main(string[] args)
////    {
////        ProperyDI studentDAL = new ProperyDI();
////        studentDAL.StudentPropertyService = new StudentPropertyService();
////        List<Student> students = studentDAL.GetStudents();
////        foreach (var student in students)
////        {
////            Console.WriteLine("Id: " + student.Id + " Name: " + student.Name);
////        }
////        Console.ReadLine();
////    }
////}
//public class Program
//{
//    public static void Main(string[] args)
//    {
//        // Assuming DatabaseContext is already defined and properly configured elsewhere in your application
//        var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
//        optionsBuilder.UseSqlServer("Data Source=PW0CAYKR; Database=activitytracker; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"); // Replace with your actual connection string

//        DatabaseContext databaseContext = new DatabaseContext(optionsBuilder.Options);
//        IGenericReposioryDP<DescriptionDTO> genericReposioryDP = new GenericReposioryDP<DescriptionDTO>(databaseContext);
//        genericReposioryDP.GetAll().ToList().ForEach(descriptionDTO => Console.WriteLine("Id: " + descriptionDTO.DescriptionId + " Description: " + descriptionDTO.Description));

//        //IRepositoryService repositoryService = new RepositoryService(databaseContext);
//        //repositoryService.GetDescriptionDTOs().ForEach(descriptionDTO => Console.WriteLine("Id: " + descriptionDTO.DescriptionId + " Description: " + descriptionDTO.Description));
//    }
//}
