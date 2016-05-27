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
    public class CT_PhieuNhapVatTuPhuTungDAL : Connections
    {
        public void CT_PhieuNhapVatTuPhuTung_Insert(CT_PhieuNhapVatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTuPhuTung_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", Data.SoPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@TenVatTuPhuTung",Data.TenVatTuPhuTung)); 
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable CT_PhieuNhapVatTuPhuTung_GetByPhieuNhap(string MPN)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTuPhuTung_GetByPhieuNhap", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", MPN));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void CT_PhieuNhapVatTuPhuTung_Delete(string MPN, string MVT)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuNhapVatTuPhuTung_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", MPN));
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", MVT));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
