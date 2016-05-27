using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.Info;
using System.Data;
using System.Data.SqlClient;

namespace Gara_Data
{
    public class PhieuNhapVatTuPhuTungDAL : Connections
    {
        public void PhieuNhapVatTuPhuTung_Insert(PhieuNhapVatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", Data.SoPhieuNhap));
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", Data.NgayNhap));
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }
        public DataTable PhieuNhapVatTuPhuTung_GetAll(string NgayNhap)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NgayNhap", NgayNhap));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public int PhieuNhapVatTuPhuTung_KiemTra(string SoPhieuNhap)
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_KiemTra", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@SoPhieuNhap", SoPhieuNhap));
                return (int)cmd.ExecuteScalar();
            }
        }
        public DataTable PhieuNhapVatTuPhuTung_GetPhieuNhap()
        {
            using (var cmd = new SqlCommand("sp_PhieuNhapVatTuPhuTung_GetPhieuNhap", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable VatTuPhuTungTheoMaSoPhieu_GetAll()
        {
            using (var cmd = new SqlCommand("sp_DanhSachVatTuPhuTungTheoMaSoPhieu", GetConnection()))
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
