using System;
using System.Collections.Generic;
using System.Data;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class TreamentRecordsDTO {
        private int iD;
        private int patientID;
        private int dentistID;
        private string status;
        private string otherDiseases;
        private string drugAllergy;
        private string diagnostic;
        private string treamentDirection;
        private DateTime date;
        private string note;
        public TreamentRecordsDTO(DataRow row) {
            this.ID = (int) row["ID"];
            this.patientID = (int) row["patientID"];
            this.dentistID = (int) row["dentistID"];
            this.status = row["status"].ToString();
            this.otherDiseases = row["otherDiseases"].ToString();
            this.drugAllergy = row["drugAllergy"].ToString();
            this.diagnostic = row["diagnostic"].ToString();
            this.treamentDirection = row["note"].ToString();
            this.Date = DateTime.Parse(row["date"].ToString());
            this.note = row["note"].ToString();
        }
        public int ID { get => iD; set => iD = value; }
        public int PatientID { get => patientID; set => patientID = value; }
        public string Status { get => status; set => status = value; }
        public string OtherDiseases { get => otherDiseases; set => otherDiseases = value; }
        public string DrugAllergy { get => drugAllergy; set => drugAllergy = value; }
        public string Diagnostic { get => diagnostic; set => diagnostic = value; }
        public string TreamentDirection { get => treamentDirection; set => treamentDirection = value; }
        public string Note { get => note; set => note = value; }
        public DateTime Date { get => date; set => date = value; }
        public int DentistID { get => dentistID; set => dentistID = value; }
    }
}
