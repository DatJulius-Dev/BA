using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class quenMatKhau : Form {
        public quenMatKhau() {
            InitializeComponent();
        }
        private string randomOTP() {
            Random random = new Random();
            return random.Next(999999).ToString("000000");
        }

        private void btnSendOTP_Click( object sender, EventArgs e ) {
            
            if (lblError.Visible) {
                return;
            }
            string receiverMail = tbxEmail.Text.Trim();
            string senderMail = "nhomchatkin@gmail.com";
            string password = "nodj pwul icvu clvr";
            MailMessage mail = new MailMessage(senderMail, receiverMail);
            mail.Subject = "OTP XÁC NHẬN ĐỔI MẬT KHẨU PHÒNG KHÁM";
            string OTP = randomOTP();
            tbxOTP.Tag = OTP;
            mail.Body = "Mã OTP của bạn là:" + OTP + "\nVui lòng không chia sẻ email này với người khác.";
            try {
                SmtpClient send = new SmtpClient("smtp.gmail.com");
                send.Port = 587;
                send.UseDefaultCredentials = false;
                send.Credentials = new System.Net.NetworkCredential(senderMail, password);
                send.EnableSsl = true;

                send.Send(mail);
                MessageBox.Show("Mã OTP đã được gửi đến email của bạn");

            }
            catch (Exception ex) {
                MessageBox.Show("Lỗi gửi email không thành công: " + ex.Message);
            }
        }

        private void tbxID_TextChanged( object sender, EventArgs e ) {
            int ID;
            if(int.TryParse(tbxID.Text, out ID)== false) {
                lblError.Text = "Mã nhân viên không chính xác";
                lblError.Visible = true;
                return;
            }
            if (EmployeeDAO.Instance.findEmployeeByID(ID) == null) {
                lblError.Text = "Mã nhân viên không chính xác";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;

        }

        private void tbxEmail_TextChanged( object sender, EventArgs e ) {
            if (EmployeeDAO.Instance.findEmployeeByEmail(tbxEmail.Text) == null) {
                lblError.Text = "Email không chính xác";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;

        }

        private void tbxConfirmPass_TextChanged( object sender, EventArgs e ) {
            if (tbxNewPass.Text != tbxConfirmPass.Text) {
                lblError.Text = "Mật khẩu không trùng khớp";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;
        }

        private void btnChangePass_Click( object sender, EventArgs e ) {
            //if(tbxID.Text == "" || tbxEmail.Text == "" || tbxNewPass.Text == "" || tbxConfirmPass.Text == "") {
            //    MessageBox.Show("Vui lòng điền đầy đủ thông tin");
            //    return;
            //}
            if(tbxOTP.Tag == null) {
                MessageBox.Show("Vui lòng nhấn gửi mã OTP trước");
                return;
            }
            if(tbxOTP.Text != tbxOTP.Tag.ToString()) {
                MessageBox.Show("Mã OTP không chính xác");
                return;
            }
            if (EmployeeDAO.Instance.changePassword(int.Parse(tbxID.Text), tbxNewPass.Text) == 1) {
                MessageBox.Show("Đổi mật khẩu thành công");
                this.Close();
                return;
            }
            MessageBox.Show("Đổi mật khẩu không thành công");
        }

        private void QuenMatKhau_Load( object sender, EventArgs e ) {

        }

        private void btnShowNewPassword_Click( object sender, EventArgs e ) {
            tbxNewPass.UseSystemPasswordChar = !tbxNewPass.UseSystemPasswordChar;
        }

        private void btnShowConfirmPassword_Click( object sender, EventArgs e ) {
            tbxConfirmPass.UseSystemPasswordChar = !tbxConfirmPass.UseSystemPasswordChar;

        }

        private void lblError_VisibleChanged( object sender, EventArgs e ) {
            if (tbxID.Text == "" || tbxEmail.Text == "" || tbxNewPass.Text == "" || tbxConfirmPass.Text == "") {
                lblError.Text= "Vui lòng điền đầy đủ thông tin";
                lblError.Visible = true;
            }
        }
    }
}
