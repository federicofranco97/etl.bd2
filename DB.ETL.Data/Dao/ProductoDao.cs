using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ETL.Data.Dao
{
    public class ProductoDao : BaseDao
    {
        public void ModificarPrecio()
        {
            Random rnd = new Random();
            var NuevoValor = rnd.Next(400, 600);
            var productoID = north.Order_Details.OrderBy(o => o.UnitPrice).Select(o => o.ProductID).FirstOrDefault();
            var ordenes = north.Order_Details.Where(o => o.ProductID == productoID).ToList();
            ordenes.ForEach(o => o.UnitPrice = NuevoValor);
            north.SaveChanges();
        }

        public void CambiarNombreProducto()
        {
            Random rnd = new Random();
            var NuevoValor = rnd.Next(1, 600);
            north.Products.FirstOrDefault().ProductName = "Producto #"+NuevoValor;
            north.SaveChanges();
        }

        public void CambiarCategoria()
        {
            var prod = north.Products.OrderByDescending(p=>p.ProductID).FirstOrDefault();
            var nuevaCat = north.Categories.Where(c => c.CategoryID != prod.CategoryID).FirstOrDefault();
            prod.CategoryID = nuevaCat.CategoryID;
            north.SaveChanges();
        }
    }
}
