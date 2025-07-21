using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class DangNhap : Form {
        public DangNhap() {
            InitializeComponent();
        }



        private void Form1_Load( object sender, EventArgs e ) {
        }

        private void cbkShowPassword_CheckedChanged( object sender, EventArgs e ) {
            tbxPassword.UseSystemPasswordChar = cbkShowPassword.Checked;
        }
        private void tbxPassword_Enter( object sender, KeyPressEventArgs e ) {
            if (e.KeyChar == (char) Keys.Enter) {
                btnLogin_Click(sender, e);
            }
        }

        private void btnLogin_Click( object sender, EventArgs e ) {
            string phoneNumber = tbxPhoneNumber.Text.Trim();
            string password = tbxPassword.Text.Trim();
            switch (EmployeeBLL.Instance.checkLoginBLL(phoneNumber, password)) {
                case "BÁC SĨ":
                    BacSi bacsi = new BacSi();
                    bacsi.Tag = EmployeeDAO.Instance.getEmployeeByPhoneNumber(phoneNumber);
                    this.Hide();
                    bacsi.ShowDialog();
                    this.Show();
                    break;
                case "LỄ TÂN":
                    LeTan letan = new LeTan();
                    letan.Tag = EmployeeDAO.Instance.getEmployeeByPhoneNumber(phoneNumber);
                    this.Hide();
                    letan.ShowDialog();
                    this.Show();
                    break;
                case "QUẢN LÝ":
                    QuanLy quanLy   = new QuanLy();
                    quanLy.Tag = EmployeeDAO.Instance.getEmployeeByPhoneNumber(phoneNumber);
                    this.Hide();
                    quanLy.ShowDialog();
                    this.Show();
                    break;
                default:
                    break;
            }
            tbxPassword.Text = "";
            tbxPhoneNumber.Text = "";
        }
        private void lblForgetPassword_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e ) {
            quenMatKhau quenMatKhau = new quenMatKhau();
            quenMatKhau.ShowDialog();
            this.Show();
        }

        private void tbxPhoneNumber_KeyPress( object sender, KeyPressEventArgs e ) {
            if (e.KeyChar == (char) Keys.Enter) {
                e.Handled = true;
                tbxPassword.Focus();
            }
        }
    }
}
