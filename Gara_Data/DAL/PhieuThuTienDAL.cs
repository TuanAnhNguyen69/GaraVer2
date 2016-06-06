using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.Info;
using System.Data;
using System.Data.SqlClient;

namespace Gara_Data.DAL
{
    public class PhieuThuTienDAL : Connections
    {
        public void PhieuThuTien_Insert(PhieuThuTien Data)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuThu", Data.MaPhieuThuTien));
                cmd.Parameters.Add(new SqlParameter("@MaTiepNhan", Data.MaTiepNhan));
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@NgayThuTien", Data.NgayThuTien));
                cmd.Parameters.Add(new SqlParameter("@SoTienThu", Data.SoTienThu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void PhieuThuTien_DeleteByMaTiepNhan(string MaTiepNhan)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_DeleteByMaTiepNhan",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTiepNhan", MaTiepNhan));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void PhieuThuTien_DeleteByMaPhieuThu(string MaPhieuThu)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_DeleteByMaPhieu", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuThu", MaPhieuThu));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable PhieuThuTien_GetByDay(string NgayThuTien)
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_GetByDay",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgayThuTien", NgayThuTien);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
                
            }
        }
        public DataTable PhieuThuTien_GetAll()
        {
            using (var cmd = new SqlCommand("sp_PhieuThuTien_GetAll", GetConnection()))
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
