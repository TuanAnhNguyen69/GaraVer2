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
    public class CT_PhieuSuaChuaDAL : Connections
    {
        public void CT_PhieuSuaChua_Insert(CT_PhieuSuaChua Data)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", Data.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@TenVatTuPhuTung", Data.TenVatTuPhuTung));;
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", Data.NoiDungSuaChua));
                cmd.Parameters.Add(new SqlParameter("@TienCong", Data.TienCong));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", Data.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", Data.ThanhTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable CT_PhieuSuaChua_GetAll()
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public DataTable CT_PhieuSuaChua_GetByMaSuaChua(string MaSC)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByMaSuaChua", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaSC));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable CT_PhieuSuaChua_GetByBienSo(string BienSo)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByBienSo", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable CT_PhieuSuaChua_KiemTra(string MaPhieuSuaChua, string NoiDung)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_KiemTra", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@NoiDungSuaChua", NoiDung));
                //cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", MaVatTuPhuTung));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void CT_PhieuSuaChua_Delete(string MaPhieuSuaChua,int STT)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@STT", STT));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void CT_PhieuSuaChua_Update(CT_PhieuSuaChua ct)
        {
            using (var cmd = new SqlCommand("sp_CT_PhieuSuaChua_Update",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@STT", ct.STT));
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", ct.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@TenVatTu", ct.TenVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@NoiDung", ct.NoiDungSuaChua));
                cmd.Parameters.Add(new SqlParameter("@DonGia", ct.DonGia));
                cmd.Parameters.Add(new SqlParameter("@TienCong", ct.TienCong));
                cmd.Parameters.Add(new SqlParameter("@SoLuong", ct.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", ct.ThanhTien));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
