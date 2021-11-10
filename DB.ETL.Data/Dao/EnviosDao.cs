using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ETL.Data.Dao
{
    public class EnviosDao : BaseDao
    {

        public string ModificarEnvio()
        {
            Random rnd = new Random();
            var envio = north.Shippers.FirstOrDefault();
            envio.Phone = rnd.Next(111,999) + "-"+ rnd.Next(1111, 9999) + "-" + rnd.Next(111, 999);
            envio.CompanyName = "Universidad de Belgrano #" + rnd.Next(1, 30);
            north.SaveChanges();
            return "Se modifico el Shipper " + envio.ShipperID + " Datos: " + envio.Phone + "\n" + envio.CompanyName;
        }
    }
}
