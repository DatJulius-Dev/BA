using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO {
    public class PatientDAO {
        private static PatientDAO instance;
        private PatientDAO() { }

        public static PatientDAO Instance {
            get {
                if (instance == null)
                    instance = new PatientDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<PatientDTO> getAllPatient() {
            List<PatientDTO> patientList = new List<PatientDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Patient");
            foreach (DataRow row in dt.Rows) {
                PatientDTO patient = new PatientDTO(row);
                patientList.Add(patient);
            }
            return patientList;
        }
        public List<PatientDTO> findPatientByPhoneNumber( string phoneNumber ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Patient where phoneNumber like '%{0}%'", phoneNumber.Trim()));
            List<PatientDTO> list = new List<PatientDTO>();
            foreach (DataRow row in table.Rows) {
                list.Add(new PatientDTO(row));
            }
            return list;
        }
        public PatientDTO getPatientByPhoneNumber( string phoneNumber ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Patient where phoneNumber = {0}", phoneNumber));
            foreach (DataRow row in table.Rows) {
                return new PatientDTO(row);
            }
            return null;
        }
        public PatientDTO getPatientByID( int id ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Patient where id = {0}", id));
            foreach (DataRow row in table.Rows) {
                return new PatientDTO(row);
            }
            return null;

        }
        public int savePatient(PatientDTO patient ) {
            string query;
            if (patient.ID == -1) {     //thêm bệnh nhân mới;
                query = "exec sp_insertPatient @branchID , @name , @birthday , @sex , @phoneNumber , @address , @cccd";
                return DataProvider.Instance.ExecuteNonQuery(query, new object[] { patient.BranchID, patient.Name.ToString(), patient.Birthday,
                    patient.Sex, patient.PhoneNumber.ToString(), patient.Address.ToString(), patient.CCCD.ToString() });

            }
            //update bệnh nhân
            query = "exec sp_updatePatient @id , @branchID , @name , @birthday , @sex , @phoneNumber , @address , @cccd";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] {patient.ID.ToString(), patient.BranchID.ToString(), patient.Name.ToString(), patient.Birthday,
                    patient.Sex, patient.PhoneNumber.ToString(), patient.Address.ToString(), patient.CCCD.ToString() });
        }
    }
}
