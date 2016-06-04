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
    public class VatTuPhuTungDAL : Connections
    {
        public void VatTuPhuTung_Insert(VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_Insert", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@TenVatTuPhuTung", Data.TenVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", Data.SoLuongTon));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public DataTable VatTu_GetAll()
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetAll", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                var da = new SqlDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
        public void VatTu_Update(VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_update", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@TenVatTuPhuTung", Data.TenVatTuPhuTung));
                cmd.Parameters.Add(new SqlParameter("@SoLuongTon", Data.SoLuongTon));
                cmd.Parameters.Add(new SqlParameter("@DonGia", Data.DonGia));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public void VatTu_Delete(VatTuPhuTung Data)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_Delete", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", Data.MaVatTuPhuTung));
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public int VatTu_GetSoLuongTon(string TenVatTu)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetSoLuongTon", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenVatTu",TenVatTu));
                int x= Convert.ToInt16(cmd.ExecuteScalar());
                return x;
            }
        }
        public string  VatTu_GetTenVatTu(string MaVatTuPhuTung)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetTenVatTuPhuTung", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaVatTuPhuTung", MaVatTuPhuTung));
                return (string)cmd.ExecuteScalar();
            }
        }

        public double VatTu_GetDonGia(string TenVatTu)
        {
            using (var cmd = new SqlCommand("sp_VatTuPhuTung_GetDonGia", GetConnection()))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@TenVatTu", TenVatTu));
                double DonGia= new double();
                DonGia=Convert.ToDouble(cmd.ExecuteScalar());
                return DonGia;
            }
        }
    }
}
