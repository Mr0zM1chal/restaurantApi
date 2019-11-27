using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RestaurantApi.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Meal> OrderedMeals { get; set; }
        public int TableId { get; set; }
        public double TotalPrice { get; set; }
    }
}