using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gara_Data.DAL;


namespace Gara_BUS
{
    public class BaoCaoDoanhSoBUS
    {
        private static readonly BaoCaoDoanhSoDAL db = new BaoCaoDoanhSoDAL();
        public static void BaoCaoDoanhSo_Insert(int Thang, int Nam, double Tong)
        {
            db.BaoCaoDoanhSo_Insert(Thang, Nam, Tong);
        }
        public static DataTable BaoCaoDoanhSo_GetDuLieu(int Thang, int Nam)
        {
            return db.BaoCaoDoanhSo_GetDuLieu(Thang, Nam);
        }
        public static int BaoCaoDoanhSo_KiemTra(int Thang, int Nam, string HieuXe)
        {
            return db.BaoCaoDoanhSo_KT(Thang, Nam, HieuXe);
        }
    }
}
