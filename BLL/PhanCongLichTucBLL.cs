using QuanLyPhongKham.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.BLL {
    public class PhanCongLichTucBLL {
        private static PhanCongLichTucBLL instance;
        private PhanCongLichTucBLL() { }

        public static PhanCongLichTucBLL Instance {
            get {
                if (instance == null)
                    instance = new PhanCongLichTucBLL();
                return instance;
            }
            private set => instance = value;
        }
        public void checkSave(string roomNumber, string shift, string dentist, string assistant,DateTime date) {
            if (roomNumber == "" || shift == "" || dentist == "" || assistant == "" ) {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                return;
            
            }
            int room = int.Parse(roomNumber);
            int shiftID = ShiftDAO.Instance.getShiftIDByName(shift);
            int dentistID = EmployeeDAO.Instance.getEmployeeIDByName(dentist);
            int assistantID = EmployeeDAO.Instance.getEmployeeIDByName(assistant);
            if(DutyScheduleDAO.Instance.existDutyScheduleDentist(shiftID, date, dentistID)) {
                MessageBox.Show("Bác sĩ này hiện đã trực ở một ca khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            if(DutyScheduleDAO.Instance.existDutyScheduleAssistant(shiftID, date, assistantID)) {
                MessageBox.Show("Phụ tá này hiện đã trực ở một ca khác", "Thông báo", MessageBoxButtons.OK);
                return;
            }

            int update = DutyScheduleDAO.Instance.updateDutySchedule(new DTO.DutyScheduleDTO(room, shiftID,date,dentistID,assistantID));
            if(update != 1) {
                MessageBox.Show("Lưu thất bại", "Thông báo", MessageBoxButtons.OK);
                return;

            }
            MessageBox.Show("Lưu thành công", "Thông báo", MessageBoxButtons.OK);
        }   
    }
}
