using QuanLyPhongKham.DAO;
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

namespace QuanLyPhongKham.GUI {
    public partial class DuLieuDiemDanh : UserControl {
        public DuLieuDiemDanh() {
            InitializeComponent();
            loadAttendanceData(AttendanceDAO.Instance.getAllAttendanceData());
        }
        public void loadAttendanceData(List<AttendanceDataDTO> list) {
            lvwAttendance.Items.Clear();
            foreach(AttendanceDataDTO item in list) {
                EmployeeDTO employee = EmployeeDAO.Instance.getEmployeeByID(item.EmployeeID);
                ListViewItem lvi = new ListViewItem(employee.Name);
                lvi.SubItems.Add(PositionDAO.Instance.getNameByID(employee.PositionID));
                lvi.SubItems.Add(item.Time.ToString("HH:mm dd/MM/yyyy"));
                lvwAttendance.Items.Add(lvi);
            }
        }
    }
}
