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
    public class BaoCaoTonBUS
    {
        private static readonly BaoCaoTonDAL db = new BaoCaoTonDAL();
        public static DataTable BaoCaoTon_GetAll(int Thang, int Nam)
        {
            return db.BaoCaoTon_GetAll(Thang, Nam);
        }
        public static void BaoCaoTon_Insert(BaoCaoTon Data)
        {
            db.BaoCaoTon_Insert(Data);
        }
        public static void BaoCaoTon_Update(BaoCaoTon Data)
        {
            db.BaoCaoTon_Update(Data);
        }
    }
}
