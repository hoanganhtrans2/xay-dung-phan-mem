using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class eTieuDe
    {
        private string maTieuDe;
        private string tieuDe;
        private int soLuongDia;
        private float giatHue;
        private bool choThue;
        private int soNgayDuocThue;
        private string loaiDia;
        private bool deleted;

        public string MaTieuDe { get => maTieuDe; set => maTieuDe = value; }
        public string TieuDe { get => tieuDe; set => tieuDe = value; }
        public int SoLuongDia { get => soLuongDia; set => soLuongDia = value; }
        public float GiatHue { get => giatHue; set => giatHue = value; }
        public bool ChoThue { get => choThue; set => choThue = value; }
        public int SoNgayDuocThue { get => soNgayDuocThue; set => soNgayDuocThue = value; }
        public string LoaiDia { get => loaiDia; set => loaiDia = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
    }
}
