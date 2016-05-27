using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.DAL;
using Gara_Data.Info;
using System.Data;
using System.Data.SqlClient;


namespace Gara_BUS
{
    public class PhieuSuaChuaBUS
    {
        private static readonly PhieuSuaChuaDAL db = new PhieuSuaChuaDAL();
        public static void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            db.PhieuSuaChua_Insert(Data);
        }
        public static DataTable PhieuSuaChua_GetAll()
        {
            return db.PhieuSuaChua_GetAll();
        }
        public static DataTable PhieuSuaChua_GetByBienSo(string BienSo)
        {
            return db.PhieuSuaChua_GetByBienSo(BienSo);
        }
        //public static int PhieuSuaChua_KiemTraDaSuaChua(string BienSo)
        //{
        //    return db.PhieuSuaChua_KiemTraDaSuaChua(BienSo);
        //}
        public static DataTable PhieuSuaChua_GetTongTien(string msc, string bienso)
        {
            return db.PhieuSuaChua_GetTongTien(msc, bienso);
        }
        public static SqlDataReader PhieuSuaChua_KTMaSuaChua()
        {
            return db.PhieuSuaChua_KTMaSuaChua();
        }
    }
}
