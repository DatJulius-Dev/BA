using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class TreatmentNeedsDAO {
        private static TreatmentNeedsDAO instance;
        private TreatmentNeedsDAO() { }

        public static TreatmentNeedsDAO Instance {
            get {
                if (instance == null)
                    instance = new TreatmentNeedsDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<TreatmentNeedsDTO> getAllTreatmentNeeds() {
            string query = "select * from TreatmentNeeds";
            List<TreatmentNeedsDTO> list = new List<TreatmentNeedsDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new TreatmentNeedsDTO(row));
            }
            return list;
        }
        public TreatmentNeedsDTO getTreatmentNeeds(string name ) {
            string query = String.Format("select * from TreatmentNeeds where name = N'{0}'", name);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new TreatmentNeedsDTO(row);
            }
            return null;

        }
    }
}
