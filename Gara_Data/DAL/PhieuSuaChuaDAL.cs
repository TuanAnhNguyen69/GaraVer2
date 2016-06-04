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
    public class PhieuSuaChuaDAL : Connections
    {
        public void PhieuSuaChua_Insert(PhieuSuaChua Data)
        {
            using(var cmd = new SqlCommand("sp_PhieuSuaChua_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", Data.MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@BienSo", Data.BienSo));
                cmd.Parameters.Add(new SqlParameter("@NgaySuaChua", Data.NgaySuaChua));
                cmd.Parameters.Add(new SqlParameter("@MaTiepNhan", Data.MaTiepNhan));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable PhieuSuaChua_GetAll()
        {
            using(var cmd = new SqlCommand("sp_PhieuSuaChua_GetAll",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public DataTable PhieuSuaChua_GetByBienSo(string BienSo)
        {
            using(var cmd = new SqlCommand("sp_CT_PhieuSuaChua_GetByBienSo",GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        
        public DataTable PhieuSuaChua_GetTongTien(string MaPhieuSuaChua, string BienSo)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetTongTien", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuSuaChua", MaPhieuSuaChua));
                cmd.Parameters.Add(new SqlParameter("@BienSo", BienSo));
                var da = new SqlDataAdapter();
                var dt = new DataTable();
                da.SelectCommand = cmd;
                da.Fill(dt);
                return dt;
            }
        }
        public SqlDataReader PhieuSuaChua_KTMaSuaChua()
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader dr = cmd.ExecuteReader();
                return dr;
            }
        }

        public DataTable PhieuSuaChua_GetByDay(string NgaySua)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_GetByDay", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@NgaySuaChua", NgaySua);
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public void PhieuSuaChua_Delete(string MaPhieu)
        {
            using (var cmd = new SqlCommand("sp_PhieuSuaChua_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@MaPhieuSuaChua", MaPhieu);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
    
}
