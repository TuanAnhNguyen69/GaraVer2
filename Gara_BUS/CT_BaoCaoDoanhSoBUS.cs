using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gara_Data.DAL;


namespace Gara_BUS
{
    public class CT_BaoCaoDoanhSoBUS
    {
        private static readonly CT_BaoCaoDoanhSoDAL db = new CT_BaoCaoDoanhSoDAL();
        public static void CT_BaoCaoDoanhSo_Insert(int Thang,int Nam, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            db.CT_BaoCaoDoanhSo_Insert(Thang, Nam, HieuXe, SoLuotSua, ThanhTien, TiLe);
        }
        public static void CT_BaoCaoDoanhSo_Update(int Thang, int Nam, string HieuXe, int SoLuotSua, double ThanhTien, float TiLe)
        {
            db.CT_BaoCaoDoanhSo_Update(Thang, Nam, HieuXe, SoLuotSua, ThanhTien, TiLe);
        }
    }
}
