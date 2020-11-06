using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class PortCodes3
    {
        public static List<PortCodes3ViewModel> GetAllData()
        {
            List<PortCodes3ViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodes3ViewModel>("Select * from PortCodes3").ToList();
            }
            return list;
        }
    }

    public class PortCodes3ViewModel
    {
        public string EN { get; set; }

    }
}
