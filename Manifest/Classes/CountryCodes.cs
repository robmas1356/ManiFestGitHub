using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class CountryCodes
    {
        public static List<CountryCodesViewModel> GetAllData()
        {
            List<CountryCodesViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CountryCodesViewModel>("Select * from CountryCodes").ToList(); 
            }

            return list;
        }
    }

    public class CountryCodesViewModel
    {
        public string EN { get; set; }
        public string FA { get; set; }
        public string Full => FA + "-" + EN;
    }
}
