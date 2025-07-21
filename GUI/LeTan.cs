using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class LeTan : Form {
        public LeTan() {
            InitializeComponent();
        }
        private void Letan_Load( object sender, EventArgs e ) {
            quanLyHoSoBenhNhan.BringToFront();
        }
        private void resetColorButton() {
            btnQuanLyHoSoBenhNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            btnPhanCongLichTruc.BackColor = System.Drawing.Color.WhiteSmoke;
            btnPay.BackColor = System.Drawing.Color.WhiteSmoke;
        }
        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void quanLiHosobenhnhan_Load( object sender, EventArgs e ) {
            quanLyHoSoBenhNhan.loadRoom();
            quanLyHoSoBenhNhan.loadTreamentNeeds();
        }

        private void btnQuanLyHoSoBenhNhan_Click( object sender, EventArgs e ) {
            quanLyHoSoBenhNhan.BringToFront();
            resetColorButton();
            btnQuanLyHoSoBenhNhan.BackColor = System.Drawing.Color.Lime;
        }

        private void btnPay_Click( object sender, EventArgs e ) {
            thanhToan.BringToFront();
            resetColorButton();
            btnPay.BackColor = System.Drawing.Color.Lime;
        }

        private void btnPhanCongLichTruc_Click( object sender, EventArgs e ) {
            phanCongLichTruc.BringToFront();
            resetColorButton();
            btnPhanCongLichTruc.BackColor = System.Drawing.Color.Lime;
        }

    }
}
