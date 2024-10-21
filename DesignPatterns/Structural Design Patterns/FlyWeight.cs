using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.DesignPatterns.Structural_Design_Patterns
{
    public interface IFlyWeightManager
    {
        List<StaticItem> GetStaticItems();
    }

    public class StaticItem
    {
        public int id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class CountryFlyWeightManager : IFlyWeightManager
    {
        private List<StaticItem> staticItems = null;
        public CountryFlyWeightManager()
        {
            staticItems = new List<StaticItem>();
        }

        public List<StaticItem> GetStaticItems()
        {

            staticItems.Add(new StaticItem { id = 1, Code = "IN", Description = "India" });
            staticItems.Add(new StaticItem { id = 2, Code = "US", Description = "United States" });
            staticItems.Add(new StaticItem { id = 3, Code = "UK", Description = "United Kingdom" });
            staticItems.Add(new StaticItem { id = 4, Code = "AU", Description = "Australia" });
            return staticItems;
        }
    }
    public class ProductTypeStaticListManager : IFlyWeightManager
    {
        private List<StaticItem> staticItems = null;
        public ProductTypeStaticListManager()
        {
            staticItems = new List<StaticItem>();
        }
        public List<StaticItem> GetStaticItems()
        {
            staticItems.Add(new StaticItem { id = 1, Code = "1", Description = "Electronics" });
            staticItems.Add(new StaticItem { id = 2, Code = "2", Description = "Furniture" });
            staticItems.Add(new StaticItem { id = 3, Code = "3", Description = "Clothing" });
            staticItems.Add(new StaticItem { id = 4, Code = "4", Description = "Books" });
            return staticItems;
        }
    }

    public class StaticDataListFlyWeightFactory
    {
        public static IFlyWeightManager GetFlyWeightManager(string managerType)
        {
            if (managerType == "Country")
            {
                return new CountryFlyWeightManager();
            }
            else if (managerType == "ProductType")
            {
                return new ProductTypeStaticListManager();
            }
            else
            {
                throw new ArgumentException("Invalid manager type");
            }
        }
    }

    public class FlyWeightDesignPattern
    {
        //public static void Main(string[] args)
        //{
        //    IFlyWeightManager flyWeightManager = StaticDataListFlyWeightFactory.GetFlyWeightManager("Country");
        //    List<StaticItem> staticItems = flyWeightManager.GetStaticItems();
        //    foreach (var item in staticItems)
        //    {
        //        Console.WriteLine("Id: {0}, Code: {1}, Description: {2}", item.id, item.Code, item.Description);
        //    }
        //}
    }
}