using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class BranchDTO {
        private int iD;
        private string address;
        private string phoneNumber;
        public BranchDTO( DataRow row ) {
            this.ID = (int)row["ID"];
            this.Address = row["address"].ToString();
            this.phoneNumber = row["phoneNumber"].ToString();
        }

        public int ID { get => iD; set => iD = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}
