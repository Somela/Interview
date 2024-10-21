//using Interview.DesignPatterns.DependencyInjection;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Practices.Unity;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interview.DesignPatterns.Repository
//{
//    public class DatabaseContext : DbContext
//    {
//        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
//        {
//        }
//        public DbSet<Student> tbl_Student { get; set; }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Data Source=PW0CAYKR; Database=activitytracker; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"); // Replace with your actual connection string
//        }
//    }
//    // In this case Generic Repository will be used for all the entities
//    // Non-Generic Repository will be used for specific entities
//    public interface IStudentRepository
//    {
//        IEnumerable<Student> GetEmployeeWithGender(string gender);
//        IEnumerable<Student> GetEmployeeWithMobileNumber(int mobile);
//    }

//    public class Student
//    {
//        [Key]
//        public int Id { get; set; }
//        public string StudentName { get; set; }
//        public string Gender { get; set; }
//        public int Age { get; set; }
//        public int MobileNo { get; set; }
//    }

//    public interface IGenericRepository<T> where T : class
//    {
//        IEnumerable<T> GetAll();
//        T GetById(object id);
//        void Insert(T entity);
//        void Update(T entity);
//        void Delete(object id);
//    }

//    public class StudentRepository : IGenericRepository<Student>, IStudentRepository
//    {
//        private DatabaseContext _context;
//        public StudentRepository(DatabaseContext context)
//        {
//            _context = context;
//        }
//        public void Delete(object id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Student> GetAll()
//        {
//            throw new NotImplementedException();
//        }

//        public Student GetById(object id)
//        {
//            throw new NotImplementedException();
//        }

//        public IEnumerable<Student> GetEmployeeWithGender(string gender)
//        {
//            return _context.tbl_Student.ToList().Where(x => x.Gender.ToLower() == gender.ToLower());
//        }

//        public IEnumerable<Student> GetEmployeeWithMobileNumber(int mobile)
//        {
//            return _context.tbl_Student.ToList().Where(x => x.MobileNo == mobile);
//        }

//        public void Insert(Student entity)
//        {
//            throw new NotImplementedException();
//        }

//        public void Update(Student entity)
//        {
//            throw new NotImplementedException();
//        }
//    }

//    public class GenericRepository<T> : IGenericRepository<T> where T : class
//    {
//        private readonly DatabaseContext _context;
//        private DbSet<T> table = null;
//        public GenericRepository(DatabaseContext context)
//        {
//            _context = context;
//            table = _context.Set<T>();
//        }
//        public void Delete(object id)
//        {
//            table.Remove(table.Find(id));
//        }

//        public IEnumerable<T> GetAll()
//        {
//            return table.ToList();
//        }

//        public T GetById(object id)
//        {
//            return table.Find(id);
//        }

//        public void Insert(T entity)
//        {
//            table.Add(entity);
//        }

//        public void Update(T entity)
//        {
//            table.Attach(entity);
//            table.Entry(entity).State = EntityState.Modified;
//        }
//    }

//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
//            optionsBuilder.UseSqlServer("Data Source=PW0CAYKR; Database=activitytracker; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"); // Replace with your actual connection string

//            DatabaseContext databaseContext = new DatabaseContext(optionsBuilder.Options);
//            //IStudentRepository studentRepository = new StudentRepository(databaseContext);
//            //var students = studentRepository.GetEmployeeWithGender("Female");
//            //students.ToList().ForEach(student => Console.WriteLine("Id: " + student.Id + " Name: " + student.StudentName + " Mobile: " + student.MobileNo + " Gender: " + student.Gender));

//            //var studentsWithMobile = studentRepository.GetEmployeeWithMobileNumber(123456789);
//            //studentsWithMobile.ToList().ForEach(student => Console.WriteLine("Id: " + student.Id + " Name: " + student.StudentName + " Mobile: " + student.MobileNo + " Gender: " + student.Gender));

//            var container = new UnityContainer();
//            container.RegisterType(typeof(IGenericRepository<Student>), typeof(GenericRepository<Student>));
//            Student student = container.Resolve<Student>();
//        }
//    }
//}
