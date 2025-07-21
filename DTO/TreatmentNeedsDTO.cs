using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class TreatmentNeedsDTO {
        private int iD;
        private string name;

        public int ID { get => iD; set => iD = value; }
        public string Name { get => name; set => name = value; }

        public TreatmentNeedsDTO(int iD, string name) {
            this.ID = iD;
            this.Name = name;
        }
        public TreatmentNeedsDTO(DataRow row) {
            this.ID = (int)row["ID"];
            this.name = row["name"].ToString();
        }

    }
}
