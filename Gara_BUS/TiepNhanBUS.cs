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
    public class TiepNhanBUS
    {
        private static readonly TiepNhanDAL db = new TiepNhanDAL();
        public static void TiepNhan_Insert(TiepNhan Data)
        {
            db.TiepNhan_Insert(Data);
        }
        public static void TiepNhan_Update(TiepNhan Data,Xe XeData)
        {
            db.TiepNhan_Update(Data,XeData);
        }
        public static void TiepNhan_Delete(string MaTiepNhan)
        {
            db.TiepNhan_Delete(MaTiepNhan);
        }
        public static DataTable TiepNhan_DanhSachTheoNgay(string NgayTiepNhan)
        {
            return db.TiepNhan_DanhSachTheoNgay(NgayTiepNhan);
        }
        public static int TiepNhan_DemDSTheoNgay(string NgayTiepNhan)
        {
            return db.TiepNhan_DemDSTheoNgay(NgayTiepNhan);
        }
        public static DataTable TiepNhan_GetAll()
        {
            return db.TiepNhan_GetAll();
        }
        public static string TiepNhan_GetBienSo(string MaTiepNhan)
        {
            return db.TiepNhan_GetBienSo(MaTiepNhan);
        }
    }
}
