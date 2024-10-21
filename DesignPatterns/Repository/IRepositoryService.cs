//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

//namespace Interview.DesignPatterns.Repository
//{
    //public class DatabaseContext : DbContext
    //{
    //    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    //    {
    //    }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Data Source=PW0CAYKR; Database=activitytracker; Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;"); // Replace with your actual connection string
    //    }
        //    public class DescriptionDTO
        //    {
        //        [Key]
        //        public Guid DescriptionId { get; set; }
        //        public string? Description { get; set; }
        //        public string? Comment { get; set; }
        //        public int CreatedBy { get; set; }
        //        public DateTime? CreatedDate { get; set; }
        //        public DateTime? ModifiedDate { get; set; }
        //        public int? UserId { get; set; }
        //    }
        //    public interface IRepositoryService
        //    {
        //        List<DescriptionDTO> GetDescriptionDTOs();
        //        DescriptionDTO GetDescriptionDTO(int id);
        //        void AddDescriptionDTO(DescriptionDTO descriptionDTO);
        //        void UpdateDescriptionDTO(DescriptionDTO descriptionDTO);
        //        void DeleteDescriptionDTO(int id);
        //    }

        //    public class RepositoryService : IRepositoryService
        //    {
        //        private readonly DatabaseContext _databaseContext;
        //        public RepositoryService(DatabaseContext databaseContext)
        //        {
        //            _databaseContext = databaseContext;
        //        }

        //        public void AddDescriptionDTO(DescriptionDTO descriptionDTO)
        //        {
        //            _databaseContext.tbl_Description.Add(descriptionDTO);
        //            _databaseContext.SaveChanges();
        //        }

        //        public void DeleteDescriptionDTO(int id)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public DescriptionDTO GetDescriptionDTO(int id)
        //        {
        //            throw new NotImplementedException();
        //        }

        //        public List<DescriptionDTO> GetDescriptionDTOs()
        //        {
        //            return _databaseContext.tbl_Description.ToList();
        //        }

        //        public void UpdateDescriptionDTO(DescriptionDTO descriptionDTO)
        //        {
        //            throw new NotImplementedException();
        //        }
        //    }
//    }
//}
