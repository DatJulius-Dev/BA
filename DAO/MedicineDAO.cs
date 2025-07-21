using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class MedicineDAO {
        private static MedicineDAO instance;
        private MedicineDAO() { }

        public static MedicineDAO Instance {
            get {
                if (instance == null)
                    instance = new MedicineDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<MedicineDTO> getAllMedicine() {
            string query = "select * from Medicine m, Service s where m.ID = s.ID";
            List<MedicineDTO> list = new List<MedicineDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new MedicineDTO(row));
            }
            return list;
        }
        public List<MedicineDTO> findMedicineByName(string name) {
            string query = String.Format("select * from Medicine m, Service s where m.ID = s.ID and name like '%{0}%'", name);
            List<MedicineDTO> list = new List<MedicineDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new MedicineDTO(row));
            }
            return list;
        }
        public int insertMedicine( string name, string unit, int price, int stock, string note ) {
            string query = String.Format("insert into Service(name, unit, price, note) values (N'{0}', N'{1}', {2}, N'{3}')", name, unit, price, note);
            int check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check != 1) {
                return -1;
            }
            int id = ServiceDAO.Instance.getLastestServiceID();
            query = String.Format("insert into Medicine(ID, stock) values ({0}, {1})", id, stock);
            return DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
