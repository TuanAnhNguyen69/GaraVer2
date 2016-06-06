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
    public class XeDAL : Connections
    {
        public void Xe_Insert(Xe Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Xe_Update(Xe Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Data.TenChuXe));
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.HieuXe));
                cmd.Parameters.Add(new SqlParameter("@DienThoai", Data.DienThoai));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", Data.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@Email", Data.Email));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void Xe_Delete(Xe Data)
        {
            using (var cmd = new SqlCommand("sp_Xe_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable Xe_DanhSach()
        {
            using (var cmd = new SqlCommand("sp_Xe_DanhSach", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetAllTen()
        {
            using (var cmd = new SqlCommand("Xe_GetTen", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetAllBienSo()
        {
            using (var cmd = new SqlCommand("Xe_GetBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    
        
        public DataTable Xe_GetTenChuXe(string Ten)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetTenChuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenChuXe", Ten));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetHieuXe(string HieuXe)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", HieuXe));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_GetBienSo(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_DSDaSuaChua()
        {
            using (var cmd = new SqlCommand("sp_Xe_DSDaSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable Xe_DSDaThuTien()
        {
            using (var cmd = new SqlCommand("sp_Xe_DSDaThuTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public int Xe_SoXeSuaChuaTrongNgay()
        {
            using (var cmd = new SqlCommand("sp_SoXeSuaChuaTrongNgay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                int k = (int)cmd.ExecuteScalar();
                return k;
            }
        }

        public double Xe_GetTienNo(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_Xe_GetTienNo",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("BienSo", BienSo);
                double k = Convert.ToDouble(cmd.ExecuteScalar());
                return k;
            }
        }
    }
}
