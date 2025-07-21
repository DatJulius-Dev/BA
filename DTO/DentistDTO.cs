using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class DentistDTO {
        private int iD;
        private int specicaltyID;
        string name;
        public DentistDTO(DataRow row ) {
            this.ID = (int) row["ID"];
            if (row["specialtyID"] != DBNull.Value)
            this.specicaltyID = (int) row["specialtyID"];
            this.name = row["name"].ToString();
        }
        public int ID { get => iD; set => iD = value; }
        public int SpecicaltyID { get => specicaltyID; set => specicaltyID = value; }
        public string Name { get => name; set => name = value; }
    }
}
