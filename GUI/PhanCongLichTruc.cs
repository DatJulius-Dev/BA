using QuanLyPhongKham.DTO;
using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyPhongKham.BLL;

namespace QuanLyPhongKham.GUI {
    public partial class PhanCongLichTruc : UserControl {
        public PhanCongLichTruc() {
            InitializeComponent();
            loadDutySchedule(DutyScheduleDAO.Instance.getDutyScheduleByDate(dtpDate.Value));
            loadAssistant();
            loadDentist();
            loadRoom();
            loadShift();

        }
        public void loadDutySchedule(List<DutyScheduleDTO> list ) {
            lvwDutySchedule.Items.Clear();
            foreach(DutyScheduleDTO dutySchedule in list) {
                ListViewItem item = new ListViewItem(dutySchedule.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(dutySchedule.RoomNumber.ToString());
                item.SubItems.Add(ShiftDAO.Instance.getShiftByID(dutySchedule.ShiftID));
                string dentistName = "Trống";
                string assistantName = "Trống";
                EmployeeDTO dentist = EmployeeDAO.Instance.getEmployeeByID(dutySchedule.DentistID);
                if(dentist != null)
                    dentistName= dentist.Name;
                EmployeeDTO assistant = EmployeeDAO.Instance.getEmployeeByID(dutySchedule.AssistantID);
                if(assistant != null)
                    assistantName= assistant.Name;
                item.SubItems.Add(dentistName);
                item.SubItems.Add(assistantName);
                lvwDutySchedule.Items.Add(item);
            }
        }
        public void loadRoom() {
            cbbRoom.Items.Clear();
            List<RoomDTO> list = RoomDAO.Instance.getAllRoom();
            foreach(RoomDTO room in list) {
                cbbRoom.Items.Add(room.RoomNumber);

            }
        }
        public void loadShift() {
            cbbShift.Items.Clear();
            List<ShiftDTO> list = ShiftDAO.Instance.getAllShift();
            foreach(ShiftDTO shift in list) {
                cbbShift.Items.Add(shift.Name);
            }
        }
        public void loadDentist() {
            cbbDentist.Items.Clear();
            List<DentistDTO> list = DentistDAO.Instance.getAllDentist();
            foreach(DentistDTO employee in list) {
                    cbbDentist.Items.Add(employee.Name);
            }
        }
        public void loadAssistant() {
            cbbAssistant.Items.Clear();
            List<EmployeeDTO> list = EmployeeDAO.Instance.getAllAssistant();
            foreach(EmployeeDTO employee in list) {
                cbbAssistant.Items.Add(employee.Name);
            }
        }


        private void dtpDate_ValueChanged( object sender, EventArgs e ) {
            loadDutySchedule(DutyScheduleDAO.Instance.getDutyScheduleByDate(dtpDate.Value));
        }

        private void btnSave_Click( object sender, EventArgs e ) {
            PhanCongLichTucBLL.Instance.checkSave(cbbRoom.Text, cbbShift.Text, cbbDentist.Text, cbbAssistant.Text, dtpDate.Value);
            loadDutySchedule(DutyScheduleDAO.Instance.getDutyScheduleByDate(dtpDate.Value));
        }

        private void cbbDentist_SelectedIndexChanged( object sender, EventArgs e ) {

        }
    }
}
