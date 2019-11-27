using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApi.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public double Price { get; set; }
    }
}