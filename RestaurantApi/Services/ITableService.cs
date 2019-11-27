using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApi.Models;

namespace RestaurantApi.Services
{
    public interface ITableService
    {
        List<Table> TablesWithOrder(List<Table> ourTables);
        List<Table> TablesWithOutOrder(List<Table> ourTables);
    }
}
