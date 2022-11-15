using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NET.Fund.Core;
using ASP.NET.Fund.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP.NET_Fundamentals.Pages.Restaurants
{
    public class DetailModel : PageModel
    {
        public Restaurant Restaurant{ get; set; }
        private IRestaurantData RestaurantData; 

        public DetailModel(IRestaurantData restaurantData)
        {
            RestaurantData = restaurantData;
        }
        public IActionResult OnGet(int restaurantId)
        {
            Restaurant = RestaurantData.GetById(restaurantId);
            if (Restaurant == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
