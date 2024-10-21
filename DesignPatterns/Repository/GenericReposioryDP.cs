//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Interview.DesignPatterns.Repository
//{
//    public interface IGenericReposioryDP<T> where T : class
//    {
//        IEnumerable<T> GetAll();
//        T GetById(object id);
//        void Insert(T entity);
//        void Update(T entity);
//        void Delete(object id);
//    }

//    public class GenericReposioryDP<T> : IGenericReposioryDP<T> where T : class
//    {
//        private readonly DatabaseContext _context;
//        private DbSet<T> table = null;
//        public GenericReposioryDP(DatabaseContext context)
//        {
//            _context = context;
//            table = _context.Set<T>();
//        }
//        public void Delete(object id)
//        {
//            T t = table.Find(id);
//            table.Remove(t);
//        }

//        public IEnumerable<T> GetAll()
//        {
//            return table.ToList();
//        }

//        public T GetById(object id)
//        {
//           return table.Find(id);
//        }

//        public void Insert(T entity)
//        {
//            table.Add(entity);
//        }

//        public void Update(T entity)
//        {
//            table.Attach(entity);
//            _context.Entry(entity).State = EntityState.Modified;
//        }

//        public class Program()
//        {
//            public void Main(string[] args)
//            {
//                var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
//                optionsBuilder.UseSqlServer("Data Source=PW0CAYKR; Database=activitytracker; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"); // Replace with your actual connection string

//                DatabaseContext databaseContext = new DatabaseContext(optionsBuilder.Options);
//                IGenericReposioryDP<DescriptionDTO> genericReposioryDP = new GenericReposioryDP<DescriptionDTO>(databaseContext);
//                genericReposioryDP.GetAll().ToList().ForEach(descriptionDTO => Console.WriteLine("Id: " + descriptionDTO.DescriptionId + " Description: " + descriptionDTO.Description));

//            }
//        }
//    }
//}
