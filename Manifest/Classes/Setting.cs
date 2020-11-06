using Dapper;
using System;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class Setting
    {
        public static bool CreateSettingtbl()
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    db.Query("CREATE TABLE \"Setting\" ( \"ID\" INTEGER NOT NULL,"
                        + " \"Ver\" INTEGER NOT NULL, \"Mode\" INTEGER NOT NULL, \"S1\" TEXT,"
                        + " \"S2\" TEXT, \"S3\" TEXT, \"N1\" INTEGER, \"N2\" INTEGER, \"N3\" INTEGER, PRIMARY KEY(\"ID\")); ");
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Insert(SettingViewModel _set)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "INSERT INTO Setting (ID, Ver, Mode) VALUES(@ID, @Ver, @Mode)";
                    db.Execute(query, _set);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Get/Set Data from/to Setting tbl
        /// </summary>
        /// <param name="_val">Ver/Mode/S1~3/N1~3</param>
        /// <returns>string</returns>
        public static string GetData(string _val)
        {
            SettingViewModel sett;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                sett = db.Query<SettingViewModel>("Select * from setting where ID=1").Single();
            }
            switch (_val.ToUpper())
            {
                case "VER":
                    return sett.Ver.ToString();
                case "MODE":
                    return sett.Mode.ToString();
                default:
                    return "";
            }
        }

        public static bool Update(SettingViewModel _sett)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "UPDATE Setting " +
                         "SET Ver =@Ver, Mode =@Mode, S1 =@S1, S2 =@S2, S3 =@S3, N1 =@N1, N2 =@N2, N3 =@N3 Where ID=@ID";
                    db.Execute(query, _sett);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }

    public class SettingViewModel
    {
        public int ID { get; set; }
        public int Ver { get; set; }
        public int Mode { get; set; }
        public string S1 { get; set; }
        public string S2 { get; set; }
        public string S3 { get; set; }
        public int N1 { get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
    }
}
