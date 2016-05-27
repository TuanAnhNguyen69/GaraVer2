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
    public class BaoCaoTonDAL : Connections
    {
        public DataTable BaoCaoTon_GetAll(int Thang, int Nam)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoTon_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void BaoCaoTon_Insert(BaoCaoTon Data)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoTon_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@Thang", Data.Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Data.Nam));
                cmd.Parameters.Add(new SqlParameter("@TonDau", Data.TonDau));
                cmd.Parameters.Add(new SqlParameter("@TonCuoi", Data.TonCuoi));
                cmd.Parameters.Add(new SqlParameter("@PhatSinh", Data.PhatSinh));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void BaoCaoTon_Update(BaoCaoTon Data)
        {
            using (var cmd = new SqlCommand("sp_BaoCaoTon_update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@Thang", Data.Thang));
                cmd.Parameters.Add(new SqlParameter("@Nam", Data.Nam));
                cmd.Parameters.Add(new SqlParameter("@TonDau", Data.TonDau));
                cmd.Parameters.Add(new SqlParameter("@TonCuoi", Data.TonCuoi));
                cmd.Parameters.Add(new SqlParameter("@PhatSinh", Data.PhatSinh));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
