using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class ScheduleDTO {
        private int iD;
        private int dentistID;
        private int patientID;
        private DateTime timeMeet;
        public ScheduleDTO( DataRow row ) {
            this.ID = (int) row["ID"];
            this.dentistID = (int) row["dentistID"];
            this.patientID = (int) row["patientID"];
            this.timeMeet = DateTime.Parse(row["meetTime"].ToString());
        }
        public int ID { get => iD; set => iD = value; }
        public int DentistID { get => dentistID; set => dentistID = value; }
        public int PatientID { get => patientID; set => patientID = value; }
        public DateTime TimeMeet { get => timeMeet; set => timeMeet = value; }
    }
}
