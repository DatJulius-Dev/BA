using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class EmployeeDTO {
        private int iD;
        private int positionID;
        private int branchID;
        private string name;
        private DateTime birthday;
        private string sex;
        private string phoneNumber;
        private string address;
        private string email;
        public EmployeeDTO(int positionID, int branchID, string name,
            DateTime birthday, string sex, string phoneNumber, string adddress, string email ) {
            this.ID = -1;
            this.positionID = positionID;
            this.branchID = branchID;
            this.name = name;
            this.birthday = birthday;
            this.sex = sex;
            this.phoneNumber = phoneNumber;
            this.address = adddress;
            this.email = email;
        }
        public EmployeeDTO(DataRow row ) {
            this.ID = (int) row["ID"];
            this.PositionID = (int) row["positionID"];
            this.BranchID = (int) row["branchID"];
            this.Name =row["name"].ToString();
            this.Name =row["name"].ToString();
            this.Birthday = DateTime.Parse(row["birthday"].ToString());
            this.Sex = (bool)row["sex"] ? "Nam" : "Nữ";
            this.PhoneNumber = row["phoneNumber"].ToString();
            this.Address = row["address"].ToString();
            this.Email = row["email"].ToString();
            
        }
        public int PositionID { get => positionID; set => positionID = value; }
        public int BranchID { get => branchID; set => branchID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public string Sex { get => sex; set => sex = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public string Email { get => email; set => email = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
