using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ETL.Data.Dao
{
    public class EmpleadoDao : BaseDao
    {
        public string CambiarDatos()
        {
            Random rnd = new Random();
            var emp = north.Employees.FirstOrDefault();
            emp.FirstName = "Alex#"+rnd.Next(1,300);
            emp.LastName = "Morozova";
            emp.Country = "UK";
            north.SaveChanges();
            return "Empleado "+emp.FirstName+" Morozova de UK #" + emp.EmployeeID;
        }

        public void BoostearEmpleado()
        {
            var emp = north.Employees.FirstOrDefault();
            var orderId = emp.Orders.Select(o => o.OrderID).FirstOrDefault();
            var orderDetail = north.Order_Details.Where(o => o.OrderID == orderId).FirstOrDefault();
            orderDetail.Quantity = 1555;
            north.SaveChanges();
        }
    }
}
