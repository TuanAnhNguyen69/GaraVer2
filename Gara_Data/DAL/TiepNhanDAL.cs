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
    public class TiepNhanDAL : Connections
    {
        public DataTable TiepNhan_DanhSachTheoNgay(string NgayTiepNhan)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_DSTheoNgay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgayTiepNhan", NgayTiepNhan);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void TiepNhan_Insert(TiepNhan Data)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTiepNhan", Data.MaTiepNhan);
                cmd.Parameters.Add("@BienSo", Data.BienSo);
                cmd.Parameters.Add("@NgayTiepNhan", Data.NgayTiepNhan);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void TiepNhan_Update(TiepNhan TiepNhan, Xe data)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_Update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTiepNhan", TiepNhan.MaTiepNhan);
                cmd.Parameters.Add("@BienSo", TiepNhan.BienSo);
                cmd.Parameters.Add("@NgayTiepNhan", TiepNhan.NgayTiepNhan);
                cmd.Parameters.Add("@HieuXe", data.HieuXe);
                cmd.Parameters.Add("@TenChuXe", data.TenChuXe);
                cmd.Parameters.Add("@DiaChi", data.DiaChi);
                cmd.Parameters.Add("@DienThoai", data.DienThoai);
                cmd.Parameters.Add("@Email", data.Email);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void TiepNhan_Delete(string MaTiepNhan)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTiepNhan", MaTiepNhan);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int TiepNhan_DemDSTheoNgay(string Ngay)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_DemDSTheoNgay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@NgayTiepNhan", Ngay));
                int k = (int)cmd.ExecuteScalar();
                return k;
            }
        }

        public DataTable TiepNhan_GetAll()
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public string TiepNhan_GetBienSo(string MaTiepNhan)
        {
            using (var cmd = new SqlCommand("sp_TiepNhan_GetBienSo",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaTiepNhan", MaTiepNhan);
                string BienSo = (string)cmd.ExecuteScalar();
                return BienSo;
            }
        }
    }
}
