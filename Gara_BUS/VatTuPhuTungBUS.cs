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
    public class VatTuPhuTungBUS
    {
        private static readonly VatTuPhuTungDAL db = new VatTuPhuTungDAL();
        public static void VatTuPhuTung_Insert(VatTuPhuTung Data)
        {
            db.VatTuPhuTung_Insert(Data);
        }

        public static DataTable VatTuPhuTung_GetAll()
        {
            return db.VatTu_GetAll();
        }
        public static void VatTuPhuTung_Update(VatTuPhuTung Data)
        {
            db.VatTu_Update(Data);
        }

        public static void VatTuPhuTung_Delete(VatTuPhuTung Data)
        {
            db.VatTu_Delete(Data);
        }

        public static int VatTuPhuTung_GetSoLuongTon(string MaVatTuPhuTung)
        {
            return db.VatTu_GetSoLuongTon(MaVatTuPhuTung);
        }
        public static string VatTuPhuTung_GetTenVatTu(string MaVatTuPhutung)
        {
            return db.VatTu_GetTenVatTu(MaVatTuPhutung);
        }
    }
}
