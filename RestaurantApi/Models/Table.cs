using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApi.Models
{
    public class Table
    {
        public int Id { get; set; }
        public string TableName { get; set; }
        public bool Empty { get; set; }
    }
}