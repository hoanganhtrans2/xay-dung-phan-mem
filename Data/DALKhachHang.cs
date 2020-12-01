using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
    public class DALKhachHang
    {
        dbQuanLyDiaDataContext db = new dbQuanLyDiaDataContext();

        public List<eKhachHang> getAllKhachHang()
        {
            List<eKhachHang> ls = new List<eKhachHang>();
            IEnumerable <KhachHang> khachHangs= db.KhachHangs.Where(kh=>kh.Deleted == false);
            foreach (KhachHang kh in khachHangs)
            {
                eKhachHang eKhach = new eKhachHang();
                eKhach.MaKhachHang = kh.MaKhachHang;
                eKhach.TenKhachHang = kh.TenKhachHang;
                eKhach.SoDienThoai = kh.SoDienThoai;
                eKhach.Deleted = kh.Deleted;
                eKhach.DiaChi = kh.DiaChi;
                ls.Add(eKhach);
            }
            return ls;
        }

        public bool deleteKhachHang(string id)
        {
            KhachHang khachHang = new KhachHang();
            var temp = db.KhachHangs.Where(kh => kh.MaKhachHang.Trim() == id).FirstOrDefault();
            khachHang = (KhachHang)temp;
            khachHang.Deleted = true;
            try
            {
                db.SubmitChanges();
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi không xoa được " + e.Message);
            }
            return true;
        }
        
    }
}
