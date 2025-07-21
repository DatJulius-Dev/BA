using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class DentistDAO {
        private static DentistDAO instance;
        private DentistDAO() { }

        public static DentistDAO Instance {
            get {
                if (instance == null)
                    instance = new DentistDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DentistDTO getDentistByID(int id ) {
            string query = String.Format("select * from Dentist d, Employee e where d.ID = {0} and d.ID = e.ID", id);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows) {
                return new DentistDTO(row);
            }
            return null;
        }
        public int getDentistIDByName(string name ) {
            string query = String.Format("select d.ID from Dentist d, Employee e where e.name = N'{0}' and d.ID = e.ID", name);
            return (int) DataProvider.Instance.ExecuteScalar(query);
        }
        public List<DentistDTO> getAllDentist() {
            List<DentistDTO> list = new List<DentistDTO>();
            string query = "select * from Dentist d, Employee e where d.ID = e.ID";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows) {
                DentistDTO dentist = new DentistDTO(row);
                list.Add(dentist);
            }
            return list;
        }
    }
}
