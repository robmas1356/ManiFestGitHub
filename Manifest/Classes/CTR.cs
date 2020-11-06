using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class CTR
    {
        public static List<CTRViewModel> GetAllData()
        {
            List<CTRViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CTRViewModel>("Select * from CTR").ToList();
            }
            return list;
        }


        public static CTRViewModel GetById(int _ID)
        {
            CTRViewModel bol;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                bol = db.Query<CTRViewModel>("Select * from CTR where ID=@ID", new { ID = _ID }).SingleOrDefault();
            }
            return bol;
        }

        public static bool Insert(CTRViewModel _ctr)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "INSERT INTO CTR (BOLRef, BolNo, txt1, txt2, txt3, txt4, txt5) VALUES(@BOLRef, @BolNo, @txt1, @txt2, @txt3, @txt4, @txt5)";
                    db.Execute(query, _ctr);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Update(CTRViewModel _ctr)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "UPDATE CTR SET BolRef =@BolRef, BolNo =@BolNo, txt1 =@txt1, txt2 =@txt2, txt3 =@txt3, txt4 =@txt4, txt5 =@txt5 where ID=@ID";
                    db.Execute(query, _ctr);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Delete(int _Id)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete From CTR where ID=@ID";
                    db.Execute(query, new { ID = _Id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool DeleteByBolRef(int _BolRef)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete From CTR where BolRef=@BolRef";
                    db.Execute(query, new { BolRef = _BolRef });
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static List<CTRViewModel> GetByRef(int _Ref)
        {
            List<CTRViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CTRViewModel>("Select * from CTR where BolRef=@Ref", new { Ref = _Ref }).ToList();
            }
            return list;
        }

        public static bool IsFirstRecord()
        {
            try
            {
                var c = GetAllData().Count;
                if (c == 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public static bool DeleteAll()
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete * from CTR";
                    db.Execute(query);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public class CTRViewModel
    {
        public int ID { get; set; }
        public int BolRef { get; set; }
        public string BolNo { get; set; }
        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txt3 { get; set; }
        public string txt4 { get; set; }
        public string txt5 { get; set; }
    }
}
