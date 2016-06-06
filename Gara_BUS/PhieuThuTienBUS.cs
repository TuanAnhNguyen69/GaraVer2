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
    public class PhieuThuTienBUS
    {
        private static readonly PhieuThuTienDAL db = new PhieuThuTienDAL();
        public static void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            db.PhieuThuTien_Insert(Data);
        }
        public static void PhieuThuTien_DeleteByMaTiepNhan(string MaTiepNhan)
        {
            db.PhieuThuTien_DeleteByMaTiepNhan(MaTiepNhan);
        }
        public static void PhieuThuTien_DeleteByMaPhieuThu(string MaPhieuThu)
        {
            db.PhieuThuTien_DeleteByMaPhieuThu(MaPhieuThu);
        }
        public static DataTable PhieuThuTien_GetByDay(string NgayThuTien)
        {
            return db.PhieuThuTien_GetByDay(NgayThuTien);
        }

        public static DataTable PhieuThuTien_GetAll()
        {
            return db.PhieuThuTien_GetAll();
        }
    }
}
