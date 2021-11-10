using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ETL.Data.Dao
{
    public class OrdenDao : BaseDao
    {
        public void ModificarOrdenes()
        {
            var Ordenes = north.Orders.Take(5).ToList();
            Ordenes.ForEach(c => c.OrderDate = DateTime.Now);
            north.SaveChanges();
        }

        //Agarrar un pais random y hacer que el 60% de las ordenes del 98 sean de ahi
        public void ModificarCantidadPaises()
        {
            var paises = north.Orders.Select(c => c.Customer.Country).Distinct().ToList();
            Random rnd = new Random();
            var pais = paises[rnd.Next(0, paises.Count-1)];
            var p = north.OrderDetails_Quantity1();            
            var cantidadOrdenes = north.Orders.Where(o=>o.OrderDate.HasValue && o.OrderDate.Value.Year == 1998).Count();
            var OrdenCantidad = p.Select(x => new DTOResult
            {
                OrderId = x.OrderID,
                Quantity = x.Quantity.HasValue ? x.Quantity.Value : 0,
                CustomerId = x.CustomerID
            }).ToList();
            var ordenes = OrdenCantidad.Select(o => o.CustomerId).ToArray();            
            //var ordenes = north.Orders.Where(c => c.OrderDate.HasValue && c.OrderDate.Value.Year == 1998).Select(o => o.OrderID).ToList();
            //var ordenesCustomer = north.Orders.Where(c => c.OrderDate.HasValue && c.OrderDate.Value.Year == 1998).Select(o => o.CustomerID).ToList();
            //var orderDetails = north.Order_Details.Where(d => ordenes.Contains(d.OrderID))
                //.OrderByDescending(d => d.Quantity).Take(cantidadOrdenes/3).Select(d=>d.OrderID).ToList();
            //var customerIds = ordenesCustomer.Where(o=> orderDetails.Contains(o)).Select(o => o.CustomerID).ToList();            
            var clientesBD = north.Customers.Where(c => ordenes.Contains(c.CustomerID)).ToList();
            clientesBD.ForEach(c => c.Country = pais);
            north.SaveChanges();            
        }
    }

    public class DTOResult
    {
        public int OrderId;
        public int Quantity;
        public string CustomerId;
    }
}
