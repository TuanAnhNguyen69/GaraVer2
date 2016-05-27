using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_Data.DAL;
using Gara_Data.Info;
using System.Data;

namespace Gara_BUS
{
    public class HieuXeBUS
    {
        private static readonly HieuXeDAL db = new HieuXeDAL();
        public static DataTable HieuXe_GetHieuXe()
        {
            return db.HieuXe_GetHieuXe();
        }
        public static void HieuXe_Insert(HieuXe Data)
        {
            db.HieuXe_Insert(Data);
        }
        public static void HieuXe_Delete(HieuXe Data)
        {
            db.HieuXe_Delete(Data);
        }
    }
}
