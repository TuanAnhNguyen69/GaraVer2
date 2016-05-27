using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Gara_Data.DAL;
using Gara_Data.Info;

namespace Gara_BUS
{
    public class TienCongBUS
    {
        private static readonly TienCongDAL db = new TienCongDAL();

        public static DataTable TienCong_GetAll()
        {
            return db.TienCong_GetAll();
        }
        public static void TienCong_Insert(TienCong Data)
        {
            db.TienCong_Insert(Data);
        }
        public static void TienCong_Update(TienCong Data)
        {
            db.TienCong_Update(Data);
        }
        public static void TienCong_Delete(TienCong Data)
        {
            db.TienCong_Delete(Data);
        }
    }
}
