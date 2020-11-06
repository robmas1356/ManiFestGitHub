using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class PortCodes5
    {
        public static List<PortCodes5ViewModel> GetAllData()
        {
            List<PortCodes5ViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<PortCodes5ViewModel>("Select * from PortCodes5").ToList();
            }
            return list;
        }

        public static List<PortCodes5ViewModel> GetData(string _str)
        {
            List<PortCodes5ViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                //Select 5 char from right and select 2 of first char

                list = db.Query<PortCodes5ViewModel>($"Select * from PortCodes5 where substr(EN,-5,2)='{_str.ToUpper()}'").ToList();
            }
            return list;
        }

    }
    public class PortCodes5ViewModel
    {
        public string EN { get; set; }

    }
}

