using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class ShiftDTO {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public ShiftDTO( DataRow row ) {
            this.iD = (int) row["ID"];
            this.name = row["name"].ToString();
        }
    }
}
