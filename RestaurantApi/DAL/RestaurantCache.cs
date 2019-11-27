using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantApi.Models;

namespace RestaurantApi.DAL
{
    public class RestaurantCache
    {
        public MealsTablesWaitersInitializer m = new MealsTablesWaitersInitializer();
        public List<Table> _Tables = null;

        public List<Order> _Orders = null;
        public List<Table> Tables
        {
            get
            {
                if (_Tables == null)
                {
                    _Tables = (HttpContext.Current.Cache["Tables"] as List<Table>);
                    if (_Tables == null)
                    {
                        _Tables = TablesList();
                        HttpContext.Current.Cache.Insert("Tables", _Tables);
                    }
                }

                return _Tables;
            }
            set
            {
                HttpContext.Current.Cache.Insert("Tables", _Tables);
            }
        }

        public List<Table> TablesList()
        {
            var tables = new List<Table>
            {
                new Table{Id = 0, Empty = true, TableName = "Stolik0"},
                new Table{Id = 1, Empty = true, TableName = "Stolik1"},
                new Table{Id = 2, Empty = true, TableName = "Stolik2"},
                new Table{Id = 3, Empty = true, TableName = "Stolik3"},
                new Table{Id = 4, Empty = true, TableName = "Stolik4"},
                new Table{Id = 5, Empty = true, TableName = "Stolik5"},
                new Table{Id = 6, Empty = true, TableName = "Stolik6"},
                new Table{Id = 7, Empty = true, TableName = "Stolik7"},
                new Table{Id = 8, Empty = true, TableName = "Stolik8"},
                new Table{Id = 9, Empty = true, TableName = "Stolik9"}
            };
            return tables;
        }

        public List<Order> Orders
        {
            get
            {
                if (_Orders == null)
                {
                    _Orders = (HttpContext.Current.Cache["Orders"] as List<Order>);
                    if (_Orders == null)
                    {
                        _Orders = new List<Order>();
                        HttpContext.Current.Cache.Insert("Orders", _Orders);
                    }
                }

                return _Orders;
            }
            set
            {
                HttpContext.Current.Cache.Insert("Orders", _Orders);
            }
        }

        public void ClearOrders()
        {
            HttpContext.Current.Cache.Remove("Orders");
        }
        public void ClearTables()
        {
            HttpContext.Current.Cache.Remove("Tables");
        }

        

    }
}