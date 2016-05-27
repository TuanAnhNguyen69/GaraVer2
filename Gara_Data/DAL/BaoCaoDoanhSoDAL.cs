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
    public class BaoCaoDoanhSoDAL : Connections
    {
        public void BaoCaoDoanhSo_Insert(int Thang, int Nam, double TongDoanhThu)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoDoanhSo_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Nam));
                cmd.Parameters.Add(new SqlParameter("@TongDoanhThu", TongDoanhThu));
                cmd.ExecuteNonQuery();
                connection.Close();

            }
        }

        public DataTable BaoCaoDoanhSo_GetDuLieu(int Thang, int Nam)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetSoLuotSua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Nam));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public int BaoCaoDoanhSo_KT(int Thang,int Nam, string HieuXe)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoDoanhSo_KiemTra ", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Thang", Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Nam));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                return (int)cmd.ExecuteScalar();
            }
        }
    }
}
