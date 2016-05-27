using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.Info;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Gara_Data.DAL
{
    public class HieuXeDAL : Connections
    {
        public DataTable HieuXe_GetHieuXe()
        {
            using (var cmd = new SqlCommand("sp_HieuXe_GetHieuXe", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void HieuXe_Insert(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void HieuXe_Delete(HieuXe Data)
        {
            using (var cmd = new SqlCommand("sp_HieuXe_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@HieuXe", Data.TenHieuXe));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
