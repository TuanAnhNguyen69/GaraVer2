using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.DAL;
using Gara_Data.Info;
using System.Data;

namespace Gara_BUS
{
    public class CT_PhieuSuaChuaBUS
    {
        private static readonly CT_PhieuSuaChuaDAL db = new CT_PhieuSuaChuaDAL();
        public static void CT_PhieuSuaChua_Insert(CT_PhieuSuaChua Data)
        {
            db.CT_PhieuSuaChua_Insert(Data);
        }
        public static DataTable CT_PhieuSuaChua_GetByMaSuaChua(string MaSC)
        {
            return db.CT_PhieuSuaChua_GetByMaSuaChua(MaSC);
        }
        public static DataTable CT_PhieuSuaChua_GetByBienSo(string BienSo)
        {
            return db.CT_PhieuSuaChua_GetByBienSo(BienSo);
        }
        public static DataTable CT_PhieuSuaChua_KiemTra(string MaPhieuSuaChua, string NoiDung)
        {
            return db.CT_PhieuSuaChua_KiemTra(MaPhieuSuaChua, NoiDung);
        }

        public static DataTable CT_PhieuSuaChua_GetAll()
        {
            return db.CT_PhieuSuaChua_GetAll();
        }

        public static void CT_PhieuSuaChua_Delete(string MaPhieuSuaChua, int STT)
        {
            db.CT_PhieuSuaChua_Delete(MaPhieuSuaChua,STT);
        }

       public static void CT_PhieuSuaChua_Update(CT_PhieuSuaChua ct)
        {
            db.CT_PhieuSuaChua_Update(ct);
        }
    }
}
