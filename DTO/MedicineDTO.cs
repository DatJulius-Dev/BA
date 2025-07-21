using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class MedicineDTO {
        private int iD;
        private string name;
        private int price;
        private int stock;
        public MedicineDTO(DataRow row ) {
            this.iD = (int) row["ID"];
            this.name = (string) row["name"];
            this.price = (int) row["price"];
            this.stock = (int) row["stock"];
        }
        public int ID { get => iD; set => iD = value; }
        public int Stock { get => stock; set => stock = value; }
        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
    }
}
