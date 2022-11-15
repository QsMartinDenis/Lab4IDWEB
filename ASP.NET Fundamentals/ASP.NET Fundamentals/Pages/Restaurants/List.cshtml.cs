using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.Fund.Core;
using ASP.NET.Fund.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace ASP.NET_Fundamentals.Pages.Restaurants
{
    public class ListModel : PageModel
    {
        public string Msg { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
        private readonly IConfiguration config;
        private readonly IRestaurantData restaurantData;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public ListModel(IConfiguration config, IRestaurantData restaurantData)
        {
            this.config = config;
            this.restaurantData = restaurantData;
        }
        public void OnGet()
        {
            Msg = config["Msg"];
            Restaurants = restaurantData.GetRestaurantsByName(SearchTerm);
        }
    }
}
