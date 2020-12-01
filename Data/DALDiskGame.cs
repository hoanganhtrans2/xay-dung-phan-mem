using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;

namespace Data
{
   public class DALDiskGame
    {
        dbQuanLyDiaDataContext db;

        public DALDiskGame()
        {
            db = new dbQuanLyDiaDataContext();
        }
        public bool themDia(int soLuongDia, string maTieuDe)
        {
            for(int i=0;i<soLuongDia;i++)
            {
                Disk_Game diskGame = new Disk_Game();
                diskGame.MaTieuDe = maTieuDe;
                db.Disk_Games.InsertOnSubmit(diskGame);
            }
            try { 
                db.SubmitChanges(); 
            }
            catch (Exception e)
            {
                throw new Exception("Lỗi thêm được " + e.Message);
            }
            return true;
        }
    }
}
