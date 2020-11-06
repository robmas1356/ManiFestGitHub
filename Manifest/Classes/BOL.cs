using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using System.Data.SQLite;

namespace Manifest
{
    class BOL
    {
        public static List<BOLViewModel> GetAllData()
        {
            List<BOLViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<BOLViewModel>("Select * from BOL").ToList();
            }
            return list;
        }

        public static BOLViewModel GetById(int _ID)
        {
            BOLViewModel bol;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                bol = db.Query<BOLViewModel>("Select * from BOL where ID=@ID", new { ID = _ID }).SingleOrDefault();
            }
            return bol;
        }

        //public static bool IsExistBol(string _bolNumber)
        //{
        //    var R = GetAllData().SingleOrDefault(s => s.txt2 == _bolNumber).ToString();
        //    return R.ToString() == "" ? false : true;
        //}

        public static bool Insert(BOLViewModel _bol)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "INSERT INTO BOL " +
                         "(txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21, txt22, txt23, txt24, txt25, txt26, txt27, txt28, txt29, txt30, txt31, txt32, txt33, txt34, txt35, txt36, txt37, txt38," +
                         "txt39, txt40, txt41, txt42, txt43, txt44, txt45, txt46, txt47, txt48, txt49, txt50, txt51, txt52, txt53, txt54, txt55, txt56, txt57, txt58, txt59, txt60, txt61, txt62)" +
                         "VALUES(@txt1, @txt2, @txt3, @txt4, @txt5, @txt6, @txt7, @txt8, @txt9, @txt10, @txt11, @txt12, @txt13, @txt14, @txt15, @txt16, @txt17, @txt18, @txt19, @txt20, @txt21, @txt22, @txt23, @txt24, @txt25, @txt26, @txt27, @txt28, @txt29, @txt30, @txt31, @txt32, @txt33, @txt34, @txt35, @txt36, @txt37, @txt38, " +
                         "@txt39, @txt40, @txt41, @txt42, @txt43, @txt44, @txt45, @txt46, @txt47, @txt48, @txt49, @txt50, @txt51, @txt52, @txt53, @txt54, @txt55, @txt56, @txt57, @txt58, @txt59, @txt60, @txt61, @txt62)";
                    db.Execute(query, _bol);
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public static bool Update(BOLViewModel _bol)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "UPDATE BOL " +
                         "SET txt1 =@txt1, txt2 =@txt2, txt3 =@txt3, txt4 =@txt4, txt5 =@txt5, txt6 =@txt6, txt7 =@txt7, txt8 =@txt8, txt9 =@txt9, txt10 =@txt10, txt11 =@txt11, txt12 =@txt12, txt13 =@txt13, txt14 =@txt14, txt15 =@txt15, txt16 =@txt16, txt17 =@txt17, txt18 =@txt18, txt19 =@txt19, txt20 =@txt20, txt21 =@txt21, txt22 =@txt22, txt23 =@txt23, txt24 =@txt24, txt25 =@txt25, txt26 =@txt26, txt27 =@txt27, txt28 =@txt28, txt29 =@txt29," +
                         "txt30 =@txt30, txt31 =@txt31, txt32 =@txt32, txt33 =@txt33, txt34 =@txt34, txt35 =@txt35, txt36 =@txt36, txt37 =@txt37, txt38 =@txt38, txt39 =@txt39, txt40 =@txt40, txt41 =@txt41, txt42 =@txt42, txt43 =@txt43, txt44 =@txt44, txt45 =@txt45, txt46 =@txt46, txt47 =@txt47, txt48 =@txt48, txt49 =@txt49, txt50 =@txt50, txt51 =@txt51, txt52 =@txt52, txt53 =@txt53, txt54 =@txt54, txt55 =@txt55, txt56 =@txt56, txt57 =@txt57," +
                         "txt58 =@txt58, txt59 =@txt59, txt60 =@txt60, txt61 =@txt61, txt62 =@txt62 Where ID=@ID";
                    db.Execute(query, _bol);
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
                    string query = "Delete From Bol where ID=@ID";
                    db.Execute(query, new { ID = _Id });
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool DeleteAll()
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete * from BOL";
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


    public class BOLViewModel
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
        public string txt12 { get; set; }
        public string txt13 { get; set; }
        public string txt14 { get; set; }
        public string txt15 { get; set; }
        public string txt16 { get; set; }
        public string txt17 { get; set; }
        public string txt18 { get; set; }
        public string txt19 { get; set; }
        public string txt20 { get; set; }
        public string txt21 { get; set; }
        public string txt22 { get; set; }
        public string txt23 { get; set; }
        public string txt24 { get; set; }
        public string txt25 { get; set; }
        public string txt26 { get; set; }
        public string txt27 { get; set; }
        public string txt28 { get; set; }
        public string txt29 { get; set; }
        public string txt30 { get; set; }
        public string txt31 { get; set; }
        public string txt32 { get; set; }
        public string txt33 { get; set; }
        public string txt34 { get; set; }
        public string txt35 { get; set; }
        public string txt36 { get; set; }
        public string txt37 { get; set; }
        public string txt38 { get; set; }
        public string txt39 { get; set; }
        public string txt40 { get; set; }
        public string txt41 { get; set; }
        public string txt42 { get; set; }
        public string txt43 { get; set; }
        public string txt44 { get; set; }
        public string txt45 { get; set; }
        public string txt46 { get; set; }
        public string txt47 { get; set; }
        public string txt48 { get; set; }
        public string txt49 { get; set; }
        public string txt50 { get; set; }
        public string txt51 { get; set; }
        public string txt52 { get; set; }
        public string txt53 { get; set; }
        public string txt54 { get; set; }
        public string txt55 { get; set; }
        public string txt56 { get; set; }
        public string txt57 { get; set; }
        public string txt58 { get; set; }
        public string txt59 { get; set; }
        public string txt60 { get; set; }
        public string txt61 { get; set; }
        public string txt62 { get; set; }
    }
}
