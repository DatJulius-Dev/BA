using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class AttendanceDataDTO {
        private int employeeID;
        private DateTime time;
        public AttendanceDataDTO(DataRow row) {
            this.EmployeeID = (int) row["employeeID"];
            this.Time = (DateTime) row["time"];
        }
        public int EmployeeID { get => employeeID; set => employeeID = value; }
        public DateTime Time { get => time; set => time = value; }
    }
}
