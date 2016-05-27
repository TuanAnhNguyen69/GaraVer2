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
    public class ThamSoDAL : Connections
    {
        public void ThamSo_Update(int Data)
        {
            using (var cmd = new SqlCommand("sp_ThayDoiSoXeSuaChuaToiDa", GetConnection()))
            {
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@SoXeSuaChuaToiDa", Data));
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        //public int ThamSo_Get()
        //{
        
        //    using (var cmd = new SqlCommand("sp_SoXeSuaChuaTrongNgay", GetConnection()))
        //    {
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        var da = new SqlDataAdapter(cmd);
        //        return da;
        //    }
        //}
        }
    
}
