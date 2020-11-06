using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class PortCodes
    {
        public static List<PortCodesViewModel> GetAllData()
        {
            List<PortCodesViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodesViewModel>("Select * from PortCodes").ToList();
            }
            return list;
        }
    }

    public class PortCodesViewModel
    {
        public string EN { get; set; }
        public string FA { get; set; }
        public string Full => FA + "-" + EN;
    }
}
