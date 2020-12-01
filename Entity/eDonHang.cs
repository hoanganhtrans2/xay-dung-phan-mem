using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    class eDonHang
    {
        private string maDonHang;
        private DateTime hanTraDia;
        private DateTime ngayTraDia;
        private DateTime ngayThue;
        private float phiTraTre;
        private bool thanhToanPhiNo;

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public DateTime HanTraDia { get => hanTraDia; set => hanTraDia = value; }
        public DateTime NgayTraDia { get => ngayTraDia; set => ngayTraDia = value; }
        public DateTime NgayThue { get => ngayThue; set => ngayThue = value; }
        public float PhiTraTre { get => phiTraTre; set => phiTraTre = value; }
        public bool ThanhToanPhiNo { get => thanhToanPhiNo; set => thanhToanPhiNo = value; }
    }
}
