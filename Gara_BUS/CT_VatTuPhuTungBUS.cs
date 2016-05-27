using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gara_DATA.GaRa_Info;
using Gara_DATA.Gara_DAL;

namespace Gara_BUS
{
    public class CT_VatTuPhuTungBUS
    {
        private static readonly CT_VatTuPhuTungDAL db = new CT_VatTuPhuTungDAL();
        public static void CT_VatTuPhuTung_Insert(CT_VatTuPhuTung Data)
        {
            db.CT_VatTuPhuTung_Insert(Data);
        }
        public static void CT_VatTuPhuTung_Delete(string MaPhieuSuaChua, string MaTienCong, string MaVatTuPhuTung)
        {
            db.CT_VatTuPhuTung_Delete(MaPhieuSuaChua, MaTienCong, MaVatTuPhuTung);
        }
        public static DataTable CT_VatTuPhuTung_GetAll()
        {
            return db.CT_VatTuPhuTung_GetAll();
        }
    }
}
