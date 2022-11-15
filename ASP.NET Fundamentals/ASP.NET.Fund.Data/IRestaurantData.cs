using ASP.NET.Fund.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ASP.NET.Fund.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        IEnumerable<Restaurant> GetRestaurantsByName(string name);
        Restaurant GetById(int id);
    }
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant&^&^&^>()
            {
                new Restaurant {Id = 1, Name = "La Costa", Location="London", Cuisine=CuisineType.Mexican },
                new Restaurant {Id = 2, Name = "Scott Pizza", Location="California", Cuisine=CuisineType.Italian},
                new Restaurant {Id = 3, Name = "Club", Location="Mississippi", Cuisine=CuisineType.Indian},
            }; 
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }

        public Restaurant GetById(int id)
        {
            return restaurants.SingleOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetRestaurantsByName(string name = null)
        {
            return from r in restaurants
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name)
                   orderby r.Name
                   select r;
        }
    }
}
