using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.BLL {
    public class EmployeeBLL {
        private static EmployeeBLL instance;
        private EmployeeBLL() { }

        public static EmployeeBLL Instance {
            get {
                if (instance == null)
                    instance = new EmployeeBLL();
                return instance;
            }
            set => instance = value;
        }

        public string checkLoginBLL( string username, string password ) {
            if(username == "" || password == "") {
                MessageBox.Show("Tài khoản hoặc mật khẩu không được để trống");
                return null;
            }
            if(username.Length != 10) {
                MessageBox.Show("Số điện thoại phải đủ 10 chữ số");
                return null;

            }
            if(password.Length > 16) {
                MessageBox.Show("Mật khẩu tối đa 16 chữ số");
                return null;

            }
            EmployeeDTO employee = EmployeeDAO.Instance.checkLogin(username, password);
            if (employee == null) {
                if(EmployeeDAO.Instance.getEmployeeByPhoneNumber(username) == null) {
                    MessageBox.Show("Số điện thoại không chính xác");
                    return null;
                }
                MessageBox.Show("Mật khẩu không chính xác");
                return null;
            }
            if (!recordLogin(employee.ID)) {
                MessageBox.Show("Điểm danh không thành công", "Lỗi điểm danh", MessageBoxButtons.OK);
                return null;
            }
            return PositionDAO.Instance.getNameByID(employee.PositionID);

        }
        private bool recordLogin( int ID ) {
            return AttendanceDAO.Instance.insertAttendance(ID);
        }
        public string insertEmployee( EmployeeDTO employee ) {
            if (EmployeeDAO.Instance.insertEmployee(employee) > 0) {
                //if (employee.PositionID == 2) {
                //    if (DentistDAO.Instance.
                //        return "Thêm nhân viên thành công";
                //}
                return "Thêm nhân viên thành công";
            }
            return "Thêm nhân viên không thành công";
        }
    }
}
