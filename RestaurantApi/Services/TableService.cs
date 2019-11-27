using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestaurantApi.Models;

namespace RestaurantApi.Services
{
    public class TableService : ITableService
    {
        public List<Table> TablesWithOrder(List<Table> ourTables)
        {
            var tablesWithOrder = new List<Table>();
            foreach (var table in ourTables)
            {
                if (table.Empty == false)
                {
                    tablesWithOrder.Add(table);
                }
            }
            return tablesWithOrder;
        }
        public List<Table> TablesWithOutOrder(List<Table> ourTables)
        {
            var tablesWithOutOrder = new List<Table>();
            foreach (var table in ourTables)
            {
                if (table.Empty == true)
                {
                    tablesWithOutOrder.Add(table);
                }
            }
            return tablesWithOutOrder;
        }
    }
}