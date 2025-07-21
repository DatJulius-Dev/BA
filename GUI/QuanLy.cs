using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class QuanLy : Form {
        public QuanLy() {
            InitializeComponent();
        }

        private void Quanliload( object sender, EventArgs e ) {
            quanLyNhanVien.BringToFront();
            btnQuanLyNhanVien.BackColor = System.Drawing.Color.Lime;
        }

        private void resetColorButton() {
            btnBaoCaoDanhThu.BackColor = System.Drawing.Color.WhiteSmoke;
            btnDuLieuDiemDanh.BackColor = System.Drawing.Color.WhiteSmoke;
            btnQuanLyNhanVien.BackColor = System.Drawing.Color.WhiteSmoke;
            btnKhoThuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            btnQuanLyBangGia.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnQuanLyNhanVien_Click( object sender, EventArgs e ) {
            quanLyNhanVien.BringToFront();
            resetColorButton();
            btnQuanLyNhanVien.BackColor = System.Drawing.Color.Lime;
        }


        private void btnDuLieuDiemDanh_Click( object sender, EventArgs e ) {
            duLieuDiemDanh.BringToFront();
            resetColorButton();
            btnDuLieuDiemDanh.BackColor = System.Drawing.Color.Lime;
        }


        private void btnQuanLyBangGia_Click( object sender, EventArgs e ) {
            quanLyBangGia.BringToFront();
            quanLyBangGia.reload();
            resetColorButton();
            btnQuanLyBangGia.BackColor = System.Drawing.Color.Lime;
        }

        private void btnKhoThuoc_Click( object sender, EventArgs e ) {
            khoThuoc.BringToFront();
            khoThuoc.reload();
            resetColorButton();
            btnKhoThuoc.BackColor = System.Drawing.Color.Lime;
        }

        private void btnBaoCaoDanhThu_Click( object sender, EventArgs e ) {
            baoCaoDanhThu.BringToFront();
            resetColorButton();
            btnBaoCaoDanhThu.BackColor = System.Drawing.Color.Lime;
        }

        private void label13_Click( object sender, EventArgs e ) {

        }
    }
}
