﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class eKhachHang
    {
        private string maKhachHang;
        private string diaChi;
        private string soDienThoai;
        private bool deleted;
        private string tenKhachHang;

        public string MaKhachHang { get => maKhachHang; set => maKhachHang = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai = value; }
        public bool Deleted { get => deleted; set => deleted = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
    }
}
