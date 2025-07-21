using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class PositionDTO {
        private int iD;
        private string name;
        public PositionDTO( DataRow row ) {
            this.ID = (int) row["ID"];
            this.Name = row["Name"].ToString();

        }

        public string Name { get => name; set => name = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
