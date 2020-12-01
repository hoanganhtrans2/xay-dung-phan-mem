using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class TieuDeDAL
    {
        dbQuanLyDiaDataContext db;
       
        public TieuDeDAL()
        {
            db = new dbQuanLyDiaDataContext();
        }
        public bool themCongViec(eTieuDe tieuDe)
        {
            TieuDe td = new TieuDe();
            td.TieuDe1 = tieuDe.TieuDe;
            td.SoLuongDia = 0;
            td.GiaThue = tieuDe.GiatHue;

            db.TieuDes.InsertOnSubmit(td);
            db.SubmitChanges();
            return true;
        }
    }
}
