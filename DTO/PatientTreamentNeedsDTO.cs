using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class PatientTreamentNeedsDTO {
        private PatientDTO patient;
        private List<TreatmentNeedsDTO> treatments;

        public PatientTreamentNeedsDTO(PatientDTO patient ) {
            this.Patient = patient;
            treatments = new List<TreatmentNeedsDTO>();
        }
        public PatientDTO Patient { get => patient; set => patient = value; }
        public List<TreatmentNeedsDTO> Treatments { get => treatments; set => treatments = value; }
    }
}
