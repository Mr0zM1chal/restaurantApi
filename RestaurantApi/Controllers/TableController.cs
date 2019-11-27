using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Caching;
using System.Web.Http;
using System.Web.Mvc;
using RestaurantApi.DAL;
using RestaurantApi.Models;
using RestaurantApi.Services;

namespace RestaurantApi.Controllers
{
    public class TableController : ApiController
    {

        public MealsTablesWaitersInitializer mtwi = new MealsTablesWaitersInitializer();
        public ITableService its = new TableService();
        public RestaurantCache rc = new RestaurantCache();


        // GET: api/Table
        public List<Table> GetTables()
        {
            return rc.Tables;
        }
        public List<Order> GetOrders()
        {
            return rc.Orders;
        }
        // GET: api/Table/GetOrder/0
        public Order GetOrder(int id)
        {
            var o = rc.Orders.ElementAt(id);
            return o;
        }
        // GET: api/Table/GetMenu
        public List<Meal> GetMenu()
        {
            return mtwi.Meals;
        }
        
        // POST: api/Table/PostOrder
        public HttpResponseMessage PostOrder([FromBody] Order order)
        {
            var tableToUpdate = rc.Tables.FirstOrDefault(t => t.Id == order.TableId);
            if (tableToUpdate != null)
            {
                tableToUpdate.Empty = false; }
            rc.Orders.Add(order);
            return Request.CreateResponse(HttpStatusCode.Moved, "Json acept");
        }

        // GET: api/Table/GetTablesWithOrder
        public List<Table> GetTablesWithOrder()
        {
            return its.TablesWithOrder(rc.Tables);
        }
        // GET: api/Table/GetTablesWithOutOrder
        public List<Table> GetTablesWithOutOrder()
        {
            return its.TablesWithOutOrder(rc.Tables);
        }

        // PUT: api/Table/PutOrder/5
        public void PutOrder(int id, [FromBody]Order order)
        {
            var orderToUpdate = rc.Orders.FirstOrDefault(t => t.Id == order.Id);
            if (orderToUpdate != null)
            {
                orderToUpdate.OrderedMeals = order.OrderedMeals;
                orderToUpdate.TotalPrice = order.TotalPrice;
            }
        }

        public List<Order> DeleteOrder(int id)
        {
            var tableToUpdate = rc.Tables.FirstOrDefault(t => t.Id == id);
            if (tableToUpdate != null)
            {
                tableToUpdate.Empty = true;
            }
            var orderToDelete = rc.Orders.FirstOrDefault(t => t.Id == id);
            rc.Orders.Remove(orderToDelete);
            return rc.Orders;
        }
    }
}
