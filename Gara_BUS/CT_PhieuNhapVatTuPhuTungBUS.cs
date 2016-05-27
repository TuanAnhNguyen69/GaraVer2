using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gara_Data.DAL;
using Gara_Data.Info;


namespace Gara_BUS
{
    public class CT_PhieuNhapVatTuPhuTungBUS
    {
        private static readonly CT_PhieuNhapVatTuPhuTungDAL db = new CT_PhieuNhapVatTuPhuTungDAL();
        public static void CT_PhieuNhapVatTuPhuTung_Insert(CT_PhieuNhapVatTuPhuTung Data)
        {
            db.CT_PhieuNhapVatTuPhuTung_Insert(Data);
        }
        public static DataTable CT_PhieuNhapVatTuPhuTung_GetByPhieuNhap(string MPN)
        {
            return db.CT_PhieuNhapVatTuPhuTung_GetByPhieuNhap(MPN);
        }
        public static void CT_PhieuNhapVatTuPhuTung_Delete(string MPN, string MVT )
        {
            db.CT_PhieuNhapVatTuPhuTung_Delete(MPN, MVT);
        }
    }
}
