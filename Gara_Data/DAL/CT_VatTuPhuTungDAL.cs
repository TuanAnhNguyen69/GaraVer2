using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gara_Data.Info;

namespace Gara_Data.DAL
{
    public class CT_VatTuPhuTungDAL : Connections
    {
        public void CT_VatTuPhuTung_Insert(CT_VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTu_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", Data.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@MaTienCong", Data.MaTienCong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void CT_VatTuPhuTung_Delete(string MaPhieuSuaChua, string MaTienCong, string MaVatTuPhuTung)
        {
            using (var cmd = new SqlCommand("sp_CT_VatTuPhuTung_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@MaTienCong", MaTienCong));
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", MaVatTuPhuTung));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable CT_VatTuPhuTung_GetAll()
        {
            using (var cmd = new SqlCommand("sp_CT_VatTuPhuTung_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
