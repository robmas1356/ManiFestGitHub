using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class PackageCodes
    {
        public static List<PackageCodesViewModel> GetAllData()
        {
            List<PackageCodesViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PackageCodesViewModel>("Select * from PackageCodes").ToList();
            }
            return list;
        }
    }

    public class PackageCodesViewModel
    {
        public string Code { get; set; }
        public string EN { get; set; }
        public string FA { get; set; }

        public string Full => FA + "_" + EN;
        //public string FullFaCode => Fa_Des + "-" + EN;
    }
}
