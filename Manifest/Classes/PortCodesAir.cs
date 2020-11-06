using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class PortCodesAir
    {
        public static List<PortCodesAirViewModel> GetAllData()
        {
            List<PortCodesAirViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodesAirViewModel>("Select * from PortCodesAir").ToList();
            }
            return list;
        }

        public static List<PortCodesAirViewModel> GetCode()
        {
            List<PortCodesAirViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodesAirViewModel>("Select distinct(code) from PortCodesAir").ToList();
            }
            return list;
        }

        public static List<PortCodesAirViewModel> GetData(string _code)
        {
            List<PortCodesAirViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodesAirViewModel>($"Select * from PortCodesAir where Code='{_code}'").ToList();
            }
            return list;
        }
    }


    public class PortCodesAirViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string FullCode { get; set; }

    }
}
