using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Manifest
{
    class CONN
    {
        public static List<CONNViewModel> GetAllData()
        {
            List<CONNViewModel> list;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CONNViewModel>("Select * from CON").ToList();
            }
            return list;
        }

        public static List<CONNViewModel> GetAllDataSortedByBolNo()
        {
            return GetAllData().OrderBy(x => x.BolNo).ToList();
        }

        public static CONNViewModel GetById(int _ID)
        {
            CONNViewModel bol;
            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                bol = db.Query<CONNViewModel>("Select * from CON where ID=@ID", new { ID = _ID }).SingleOrDefault();
            }
            return bol;
        }

        public static bool Insert(CONNViewModel _con)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "INSERT INTO CON " +
                         "(CTRRef, CTRNo ,BolRef, BolNo, txt1, txt2, txt3, txt4, txt5, txt6, txt7, txt8, txt9, txt10, txt11, txt12, txt13, txt14, txt15, txt16, txt17, txt18, txt19, txt20, txt21, txt22)" +
                         "VALUES(@CTRRef, @CTRNo, @BolRef, @BolNo, @txt1, @txt2, @txt3, @txt4, @txt5, @txt6, @txt7, @txt8, @txt9, @txt10, @txt11, @txt12, @txt13, @txt14, @txt15, @txt16, @txt17, @txt18, @txt19, @txt20, @txt21, @txt22)";
                    db.Execute(query, _con);
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

        public static bool Update(CONNViewModel _con)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "UPDATE CON " +
                         "SET BolRef=@BolRef, BolNo=@BolNo, txt1 =@txt1, txt2 =@txt2, txt3 =@txt3, txt4 =@txt4, txt5 =@txt5, txt6 =@txt6, txt7 =@txt7, txt8 =@txt8, "
                         + "txt9 =@txt9, txt10 =@txt10, txt11 =@txt11, txt12 =@txt12, txt13 =@txt13, txt14 =@txt14, txt15 =@txt15, txt16 =@txt16,"
                         + "txt17 =@txt17, txt18 =@txt18, txt19 =@txt19, txt20 =@txt20, txt21 =@txt21, txt22 =@txt22 Where ID=@ID";
                    db.Execute(query, _con);
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
                    string query = "Delete From CON where ID=@ID";
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

        public static bool DeleteByBolID(int _BolId)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete From Con where BolRef=@BolRef";
                    db.Execute(query, new { BolRef = _BolId });
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

        public static bool DeleteByCTRID(int _CtrId)
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete From Con where CtrRef=@CtrRef";
                    db.Execute(query, new { CtrRef = _CtrId });
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

        public static List<CONNViewModel> GetByBolRef(int _Ref)
        {
            List<CONNViewModel> list;

            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CONNViewModel>("Select * from CON where BolRef=@Ref", new { Ref = _Ref }).ToList();
            }

            return list;
        }
        public static List<CONNViewModel> GetByCtrRef(int _Ref)
        {
            List<CONNViewModel> list;

            using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
            {
                list = db.Query<CONNViewModel>("Select * from CON where CtrRef=@Ref", new { Ref = _Ref }).ToList();
            }

            return list;
        }

        public static bool DeleteAll()
        {
            try
            {
                using (IDbConnection db = new SQLiteConnection(DataAccess.GetConnectionString()))
                {
                    string query = "Delete * from CON";
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

    public class CONNViewModel
    {
        public int ID { get; set; }
        public int CTRRef { get; set; }
        public string CTRNo { get; set; }
        public int BolRef { get; set; }
        public string BolNo { get; set; }
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
    }
}
