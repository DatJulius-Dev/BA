using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI
{
    public partial class ThemBenhNhan : Form
    {
        public ThemBenhNhan()
        {
            InitializeComponent();
        }
        public ThemBenhNhan(PatientDTO patient)
        {
            InitializeComponent();
            loadPatient(patient);
        }
        private void loadPatient(PatientDTO patient) {
            tbxName.Text = patient.Name.ToString();
            dtpBirthday.CustomFormat ="yyyy/MM/dd";
            dtpBirthday.Value = patient.Birthday;
            tbxPhoneNumber.Text = patient.PhoneNumber.ToString();
            tbxAddress.Text = patient.Address.ToString();
            tbxCCCD.Text = patient.CCCD.ToString();
            if (patient.Sex) {
                rdbMale.Checked = true;
            }
            else {
                rdbFemale.Checked = true;
            }
            btnSavePatient.Tag = patient.ID;
        }


        private void dtpBirthday_ValueChanged( object sender, EventArgs e ) {
            (sender as DateTimePicker).CustomFormat = "yyyy/MM/dd";
        }

        private void btnSavePatient_Click( object sender, EventArgs e ) {
            //int branchID = 1;       //mặc định chi nhánh hiện tại 
            string name = tbxName.Text;
            DateTime birthday = dtpBirthday.Value;
            string phoneNumber = tbxPhoneNumber.Text;
            string address = tbxAddress.Text;
            string cccd = tbxCCCD.Text;
            if(phoneNumber.Length != 10) {
                MessageBox.Show("Số điện thoại không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(tbxCCCD.Text.Length != 12) {
                MessageBox.Show("CCCD không hợp lệ", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(name == "" || phoneNumber == "" || address == "" || cccd == "") {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            PatientDTO patient = new PatientDTO(1, tbxName.Text, dtpBirthday.Value, rdbMale.Checked, tbxPhoneNumber.Text, tbxAddress.Text, tbxCCCD.Text);
            if (btnSavePatient.Tag != null) {
                patient.ID = (int)btnSavePatient.Tag;
            }
            LeTanBLL.Instance.savePatient(patient);
            this.Close();
        }

        private void btnExit_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void tbxName_TextChanged( object sender, EventArgs e ) {

        }
    }
}
