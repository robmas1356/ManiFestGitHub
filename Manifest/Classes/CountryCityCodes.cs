using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class CountryCityCodes
    {
       public static List<CountryCityCodesViewModel> GetAllData()
        {
            List<CountryCityCodesViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CountryCityCodesViewModel>("Select * from CountryCityCodes").ToList(); 
            }

            return list;
        }
    }


    public class CountryCityCodesViewModel
    {
        public string Country { get; set; }
        public string City { get; set; }
        public string Code { get; set; }

        public string Full => Country + "," + City + "-" + Code;
    }
}
