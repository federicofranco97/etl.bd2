using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.ETL.Data.Dao
{
    public class BaseDao
    {
        public NorthwindEntities north = new NorthwindEntities();
        public NorhwindDWEntities dwNorth = new NorhwindDWEntities();
    }
}
