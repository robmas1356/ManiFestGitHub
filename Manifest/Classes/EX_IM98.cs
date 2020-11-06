using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class EX_IM98
    {
        public static List<CPP98ViewModel> GetAllData()
        {
            List<CPP98ViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CPP98ViewModel>("SELECT * FROM CPP98").ToList();
            }
            return list;
        }
    }

    public class CPP98ViewModel
    {
        public int GroupID { get; set; }
        public string TName { get; set; }
        public string TKalaName { get; set; }
        public string TVorodi { get; set; }
        public string TSUQ { get; set; }
        public string TDesc { get; set; }
        public string TPreferential { get; set; }

    }
}
