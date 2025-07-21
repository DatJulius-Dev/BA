using iTextSharp.text;
using iTextSharp.text.pdf;
using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyPhongKham.GUI {
    public partial class BacSi : Form {
        private int DENTIST_ID;
        private int ROOM_NUMBER = 0;

        public BacSi() {
            InitializeComponent();
        }

        private void Bacsi_Load( object sender, EventArgs e ) {

            khamLamSang.BringToFront();
            DENTIST_ID = (this.Tag as EmployeeDTO).ID;
            DutyScheduleDTO dutySchedule = DutyScheduleDAO.Instance.getDutyScheduleByDentistID(DENTIST_ID);
            if (dutySchedule == null) {
                MessageBox.Show("Hiện tại bạn không có lịch làm việc", "Thông báo", MessageBoxButtons.OK);

            }
            else {
                ROOM_NUMBER = dutySchedule.RoomNumber;
                Queue<PatientTreamentNeedsDTO> patientList = BacSiBLL.Instance.QueuePatient[ROOM_NUMBER];
                foreach (PatientTreamentNeedsDTO item in patientList) {
                    ListViewItem lvwItem = new ListViewItem(item.Patient.ID.ToString());
                    lvwItem.SubItems.Add(item.Patient.Name);
                    lvwItem.Tag = item;
                    lvwPatient.Items.Add(lvwItem);
                }
            }
            loadInforPatient();
        }
        public void loadInforPatient() {
            if (lvwPatient.Items.Count == 0) {
                resetAllField();
                khamLamSang.Enabled = false;
                donThuoc.Enabled = false;
                lichSuKhamChuaBenh.Enabled = false;
                btnEnd.Enabled = false;
                return;
            }
            PatientTreamentNeedsDTO patient = (lvwPatient.Items[0].Tag as PatientTreamentNeedsDTO);
            //load information to textbox
            tbxID.Text = patient.Patient.ID.ToString();
            tbxCCCD.Text = patient.Patient.CCCD.ToString();
            tbxBirthday.Text = patient.Patient.Birthday.Date.ToString("dd/MM/yyyy");
            tbxName.Text = patient.Patient.Name.ToString();
            tbxPhoneNumber.Text = patient.Patient.PhoneNumber.ToString();
            tbxSex.Text = patient.Patient.Sex ? "Nam" : "Nữ";
            //load listview nhu cầu điều trị
            loadTreamentNeeds(patient.Treatments);
            //load lịch sử khám chữa bệnh
            lichSuKhamChuaBenh.loadTreamentRecord(int.Parse(tbxID.Text));
            //load đơn thuốc
            TreamentRecordsDTO treamentRecord = TreamentRecordsDAO.Instance.getLastestTreamentRecordOfPatient(int.Parse(tbxID.Text));
            khamLamSang.Tag = treamentRecord;
            donThuoc.Tag = treamentRecord;
            if (donThuoc.Tag != null)
                donThuoc.loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((donThuoc.Tag as TreamentRecordsDTO).ID).ID));
            //load khám lâm sàng
            if (khamLamSang.Tag != null)
                khamLamSang.loadTreamentRecord(treamentRecord);
        }
        private void loadTreamentNeeds( List<TreatmentNeedsDTO> treamentNeeds ) {
            lvwTreamentNeeds.Items.Clear();
            foreach (TreatmentNeedsDTO treament in treamentNeeds) {
                ListViewItem item = new ListViewItem(treament.Name);
                lvwTreamentNeeds.Items.Add(item);
            }
        }

        private void resetColorButton() {
            btnDonThuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            btnKhamLamSang.BackColor = System.Drawing.Color.WhiteSmoke;
            btnLichSuKhamChuaBenh.BackColor = System.Drawing.Color.WhiteSmoke;
        }


        private void btnLogout_Click( object sender, EventArgs e ) {
            this.Close();
        }

        private void btnDonThuoc_Click( object sender, EventArgs e ) {
            donThuoc.BringToFront();
            resetColorButton();
            btnDonThuoc.BackColor = System.Drawing.Color.Lime;
        }


        private void btnKhamLamSang_Click( object sender, EventArgs e ) {
            khamLamSang.BringToFront();
            resetColorButton();
            btnKhamLamSang.BackColor = System.Drawing.Color.Lime;
        }

        private void btnLichSuKhamChuaBenh_Click( object sender, EventArgs e ) {
            lichSuKhamChuaBenh.BringToFront();
            resetColorButton();
            btnLichSuKhamChuaBenh.BackColor = System.Drawing.Color.Lime;
        }
        private void resetAllField() {
            tbxID.Text = "";
            tbxCCCD.Text = "";
            tbxBirthday.Text = "";
            tbxName.Text = "";
            tbxPhoneNumber.Text = "";
            tbxSex.Text = "";
            loadTreamentNeeds(new List<TreatmentNeedsDTO>());
        }
        private void btnEnd_Click( object sender, EventArgs e ) {
            lvwPatient.Items.RemoveAt(0);
            BacSiBLL.Instance.QueuePatient[ROOM_NUMBER].Dequeue();
            loadInforPatient();
        }
    }
}
