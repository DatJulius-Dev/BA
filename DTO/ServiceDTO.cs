using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class ServiceDTO {
        private int iD;
        private string name;
        private string unit;
        private int price;
        private string note;
        public ServiceDTO(DataRow row ) {
            this.iD = (int) row["ID"];
            this.price = (int) row["price"];
            this.name = (string) row["Name"];
            this.unit = (string) row["unit"];
                if (row["note"].ToString() != "")
            this.note = (string) row["note"];
            if(this.note == null)
                this.note = "";
        }
        public ServiceDTO( int iD, string name, string unit, int price, string note ) {
            this.ID = iD;
            this.Name = name;
            this.Unit = unit;
            this.Price = price;
            this.Note = note;
        }
        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }
        public string Unit { get => unit; set => unit = value; }
        public int Price { get => price; set => price = value; }
        public string Note { get => note; set => note = value; }
    }
}
