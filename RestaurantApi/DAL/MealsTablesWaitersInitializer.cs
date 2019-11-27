using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using RestaurantApi.Models;

namespace RestaurantApi.DAL
{
    public class MealsTablesWaitersInitializer 
    {
        public List<Meal> Meals { get; set; }
        
        public MealsTablesWaitersInitializer(  )
        {
            Meals = MealData();
        }
        public List<Meal> MealData()
        {
            var meals = new List<Meal>
            {
                new Meal{Id = 0, MealName = "Margherita", Price = 19.99},
                new Meal{Id = 1, MealName = "Prosciutto", Price = 21.00},
                new Meal{Id = 2, MealName = "Prataiolo", Price = 21.50},
                new Meal{Id = 3, MealName = "Salame", Price = 23.50},
                new Meal{Id = 4, MealName = "Cacciatore", Price = 21.99},
                new Meal{Id = 5, MealName = "Spinace", Price = 25.00},
                new Meal{Id = 6, MealName = "Diavolo", Price = 24.00},
                new Meal{Id = 7, MealName = "Cola", Price = 5.00},
                new Meal{Id = 8, MealName = "Sok", Price = 4.00},
                new Meal{Id = 9, MealName = "Kawa", Price = 10.00},
                new Meal{Id = 10, MealName = "Herbata", Price = 8.00}
            };
            return meals;
        }

        
    }
}