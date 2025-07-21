using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class PatientDTO {

        public PatientDTO( DataRow row ) {
            this.ID = (int) row["ID"];
            this.branchID = (int) row["branchID"];
            this.name = row["name"].ToString();
            this.birthday = DateTime.Parse(row["birthday"].ToString());
            this.sex = (bool) row["sex"];
            this.phoneNumber = row["phoneNumber"].ToString();
            this.address = row["address"].ToString();
            this.CCCD = row["cccd"].ToString();
        }

        public PatientDTO( int branchID, string name, DateTime birthday, bool sex, string phoneNumber, string address, string cCCD, int iD = -1 ) {
            this.iD = iD;
            this.branchID = branchID;
            this.name = name;
            this.birthday = birthday;
            this.sex = sex;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.cCCD = cCCD;
        }


        public int BranchID { get => branchID; set => branchID = value; }
        public string Name { get => name; set => name = value; }
        public DateTime Birthday { get => birthday; set => birthday = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string Address { get => address; set => address = value; }
        public int ID { get => iD; set => iD = value; }
        public string CCCD { get => cCCD; set => cCCD = value; }
        private int iD;
        private int branchID;
        private string name;
        private DateTime birthday;
        private bool sex;
        private string phoneNumber;
        private string address;
        private string cCCD;

    }
}
