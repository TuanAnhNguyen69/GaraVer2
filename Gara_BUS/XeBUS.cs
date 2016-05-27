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
    public class XeBUS
    {
        private static readonly XeDAL db = new XeDAL();
        public static void Xe_Insert(Xe Data)
        {
            db.Xe_Insert(Data);
        }
        public static void Xe_Update(Xe Data)
        {
            db.Xe_Update(Data);
        }
        public static void Xe_Delete(Xe Data)
        {
            db.Xe_Delete(Data);
        }
        public static DataTable Xe_DanhSach()
        {
            return db.Xe_DanhSach();
        }

        public static DataTable Xe_DSTheoNgay(string NgayTiepNhan)
        {
            return db.Xe_DSTheoNgay(NgayTiepNhan);
        }
        public static DataTable Xe_GetTenChuXe(string Ten)
        {
            return db.Xe_GetTenChuXe(Ten);
        }
        public static DataTable Xe_GetBienSo(string BienSo)
        {
            return db.Xe_GetBienSo(BienSo);
        }
        public static DataTable Xe_GetHieuXe(string HieuXe)
        {
            return db.Xe_GetHieuXe(HieuXe);
        }
        public static DataTable Xe_DSDaSuaChua()
        {
            return db.Xe_DSDaSuaChua();
        }
        public static DataTable Xe_DSDaThuTien()
        {
            return db.Xe_DSDaThuTien();
        }
        public static int Xe_DemDSTheoNgay(string Ngay)
        {
            return db.Xe_DemDSTheoNgay(Ngay);
        }
        public static int SoXeSuaChuaTrongNgay()
        {
            return db.Xe_SoXeSuaChuaTrongNgay();
        }
        public static DataTable Xe_GetAllTen()
        {
            return db.Xe_GetAllTen();
        }
        public static DataTable Xe_GetAllBienSo()
        {
            return db.Xe_GetAllBienSo();
        }
    }
}
