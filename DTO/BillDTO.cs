using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class BillDTO {
        private int iD;
        private int treamentRecordID;
        private DateTime dateCheckIn;
        private DateTime dateCheckOut;
        private bool status;
        public BillDTO( DataRow row ) {
            this.ID = (int) row["ID"];
            this.treamentRecordID = (int) row["treamentRecordID"];
            this.dateCheckIn = (DateTime) row["dateCheckIn"];
            if (row["dateCheckOut"].ToString() != "")
                this.dateCheckOut = (DateTime) row["dateCheckOut"];
            this.status = (bool) row["status"];
        }
        public int TreamentRecordID { get => treamentRecordID; set => treamentRecordID = value; }
        public DateTime DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
        public DateTime DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
        public bool Status { get => status; set => status = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
