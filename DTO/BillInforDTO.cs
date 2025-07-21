using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class BillInforDTO {
        private int billID;
        private int serviceID;
        private int quantity;
        public BillInforDTO(DataRow row ) {
            this.billID = (int) row["billID"];
            this.serviceID = (int) row["serviceID"];
            this.quantity = (int) row["quantity"];
        }
        public int BillID { get => billID; set => billID = value; }
        public int ServiceID { get => serviceID; set => serviceID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
    }
}
