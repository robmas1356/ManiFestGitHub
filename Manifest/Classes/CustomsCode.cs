using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class CustomsCode
    {
        public static List<CustomsCodeViewModel> GetAllData()
        {
            List<CustomsCodeViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CustomsCodeViewModel>("Select * from CustomsCode").ToList();
            }

            return list;
        }
    }


    public class CustomsCodeViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public string Full => Name + "_" + Code;
    }
}
