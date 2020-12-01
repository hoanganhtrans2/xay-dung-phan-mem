using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BUS;

namespace AppThueDia
{
    public partial class frmTieuDe : Form
    {
        public frmTieuDe()
        {
            InitializeComponent();
        }
        TieuDeBUS tieuDeBUS;
        BindingSource bsTieuDe;
        List<eTieuDe> lsTieuDe;
        List<string> loaiDia;
        private void frmTieuDe_Load(object sender, EventArgs e)
        {
            tieuDeBUS = new TieuDeBUS();
            bsTieuDe = new BindingSource();
            lsTieuDe = new List<eTieuDe>();
            loaiDia = new List<string>() { "DVD", "moive" };
            cbLoaiDia.DataSource = loaiDia;
            bsTieuDe.DataSource = tieuDeBUS.getAllTieuDe();
            dgvDSDia.DataSource = bsTieuDe;
            
        }
        private void btnThemTD_Click(object sender, EventArgs e)
        {
            
            choPhepNhapThongTin();
            if (btnThemTD.Text=="Lưu Lại")
            {
                eTieuDe tieuDe = taoTieuDe();
                if (kiemTraThongTinNhap())
                {
                    if (tieuDeBUS.themTieuDe(tieuDe))
                    {
                        voHieuNhapThongTin();
                        btnThemTD.Text = "Thêm";
                        btnSuaTD.Text = "Sửa";
                        MessageBox.Show("Thêm tiêu đề mới thành công");

                    }
                    else
                    {
                        MessageBox.Show("Lỗi không lưu được");
                    }
                }
                else
                {
                    MessageBox.Show("Nhập sai thông tin");
                }
            }else
            {
                btnThemTD.Text = "Lưu Lại";
                btnSuaTD.Text = "Hủy";
            }
            
        }
        public void CustomGirdView()
        {
            dgvDSDia.Dock = DockStyle.Fill;
            dgvDSDia.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.AllCells;

        }
        public bool kiemTraThongTinNhap()
        {
            return true;
        }

        public void choPhepNhapThongTin()
        {
            txtGiaThue.Text = "";
            txtSoLuong.Text = "";
            txtTieuDe.Text = "";
            txtSoNgay.Text = "";
            cbLoaiDia.Text = "";
            txtTrangThai.Text = "";
            txtTieuDe.Enabled = true;
            txtGiaThue.Enabled = true;
            txtSoNgay.Enabled = true;
            txtTrangThai.Enabled = false;
            txtMaDia.Enabled = true;
            txtSoLuong.Text = "0";
            txtTrangThai.Text = "Nhập mới";
            
        }
        public void voHieuNhapThongTin()
        {
            txtGiaThue.Text = "";
            txtSoLuong.Text = "";
            txtTieuDe.Text = "";
            txtSoNgay.Text = "";
            cbLoaiDia.Text = "";
            txtTrangThai.Text = "";
            txtTieuDe.Enabled = false;
            txtGiaThue.Enabled = false;
            txtSoNgay.Enabled = false;
            txtTrangThai.Enabled = false;
            txtMaDia.Enabled = true;
            txtSoLuong.Text = "";
            List<string> loaiDia = new List<string>() { "DVD", "moive" };
            cbLoaiDia.DataSource = loaiDia;
        }

        public eTieuDe taoTieuDe()
        {
           eTieuDe etieuDe = new eTieuDe();
            etieuDe.TieuDe = txtTieuDe.Text;
            etieuDe.GiaThue = float.Parse(txtGiaThue.Text);
            etieuDe.Deleted = false;
            etieuDe.SoNgayDuocThue = int.Parse(txtSoNgay.Text);
            etieuDe.LoaiDia = cbLoaiDia.Text;
            return etieuDe;
        }

        public void capNhatThongTinVaoTextBox(eTieuDe eTieuDe)
        {
            txtGiaThue.Text = eTieuDe.GiaThue.ToString();
            txtSoLuong.Text = eTieuDe.SoLuongDia.ToString();
            txtTieuDe.Text = eTieuDe.TieuDe;
            txtSoNgay.Text = eTieuDe.SoNgayDuocThue.ToString();
            cbLoaiDia.Text = eTieuDe.LoaiDia;
            txtTrangThai.Text = eTieuDe.Deleted ? "Không còn cho thuê" : "Cho thuê";
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dgvDSDia_Click(object sender, EventArgs e)
        {
            try
            {
                eTieuDe tieuDe = (eTieuDe)bsTieuDe.Current;

                capNhatThongTinVaoTextBox(tieuDe);
            }
            catch
            {
                throw;
            }
        }

        private void btnSuaTD_Click(object sender, EventArgs e)
        {
            //hủy thêm tiêu đề mới
            if (btnSuaTD.Text == "Hủy")
            {
                btnThemTD.Text = "Thêm";
                btnSuaTD.Text = "Sửa";
                voHieuNhapThongTin();
            }
        }
    }
}
