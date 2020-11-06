using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class VOY
    {
        public static List<VOYViewModel> GetAllData()
        {
            List<VOYViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<VOYViewModel>("Select * from VOY").ToList();
            }
            return list;
        }


        public static VOYViewModel GetById(int _ID)
        {
            VOYViewModel bol;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                bol = db.Query<VOYViewModel>("Select * from VOY where ID=@ID", new { ID = _ID }).SingleOrDefault();
            }
            return bol;
        }

        public static bool Insert(VOYViewModel _voy)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "INSERT INTO VOY (ID, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11) VALUES(@ID, @txt1, @txt2, @txt3, @txt4, @txt5, @txt6, @txt7, @txt8, @txt9, @txt10, @txt11)";
                    db.Execute(query, _voy);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                System.Windows.Forms.MessageBox.Show(ex.Message);
                return false;
                throw;
            }
        }

        public static bool Update(VOYViewModel _voy)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "UPDATE VOY SET txt1 =@txt1, txt2 =@txt2, txt3 =@txt3, txt4 =@txt4, txt5 =@txt5, txt6 =@txt6, txt7 =@txt7, txt8 =@txt8, txt9 =@txt9, txt10 =@txt10, txt11 =@txt11 where ID=@ID";
                    db.Execute(query, _voy);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        public static bool Delete(int _Id)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete From VOY where ID=@ID";
                    db.Execute(query, new { ID = _Id });
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
                throw;
            }
        }

        public static bool DeleteAll()
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete * from VOY";
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

    public class VOYViewModel
    {
        public int ID { get; set; }

        public string txt1 { get; set; }
        public string txt2 { get; set; }
        public string txt3 { get; set; }
        public string txt4 { get; set; }
        public string txt5 { get; set; }
        public string txt6 { get; set; }
        public string txt7 { get; set; }
        public string txt8 { get; set; }
        public string txt9 { get; set; }
        public string txt10 { get; set; }
        public string txt11 { get; set; }
    }
}