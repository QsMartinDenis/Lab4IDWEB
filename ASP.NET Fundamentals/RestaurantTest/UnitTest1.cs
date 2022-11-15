using ASP.NET.Fund.Core;
using ASP.NET.Fund.Data;
using System;
using System.Collections.Generic;
using Xunit;

namespace RestaurantTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            InMemoryRestaurantData test = new InMemoryRestaurantData();
            var restaurants = test.GetAll();
        }

        [Fact]
        public void Test2()
        {
            InMemoryRestaurantData test = new InMemoryRestaurantData();
            var restaurants = test.GetAll();

            foreach (var restaurant in restaurants)
            {
                Assert.Equal("z", restaurant.Name);
            }
        }
    }
}
