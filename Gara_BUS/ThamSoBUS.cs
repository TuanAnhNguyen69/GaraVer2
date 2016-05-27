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
    public class ThamSoBUS
    {
        private static readonly ThamSoDAL db = new ThamSoDAL();
        public static void ThamSo_Update(int Data)
        {
            db.ThamSo_Update(Data);
        }
        //public static int TienCong_GetAll()
        //{
        //    return db.ThamSo_Get();
        //}
    }
}
