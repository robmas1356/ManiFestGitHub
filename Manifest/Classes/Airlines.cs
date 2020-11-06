using Dapper;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Data;

namespace Manifest
{
    class Airlines
    {
        public static List<AirLinesViewModel> GetAllData()
        {
            List<AirLinesViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<AirLinesViewModel>("Select * from AirLines").ToList();
            }
            return list;
        }
    }



    public class AirLinesViewModel
    {
        public string  Name { get; set; }
    }
}
