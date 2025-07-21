using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class ShiftDAO {
        private static ShiftDAO instance;
        private ShiftDAO() { }

        public static ShiftDAO Instance {
            get {
                if (instance == null)
                    instance = new ShiftDAO();
                return instance;
            }
            private set => instance = value;
        }
        public string getShiftByID(int id ) {
            string query = String.Format("select name from Shift where ID = {0}", id);
            return DataProvider.Instance.ExecuteScalar(query).ToString();
        }
        public int getShiftIDByName(string name ) {
            string query = String.Format("select ID from Shift where name = N'{0}'", name);
            return (int) DataProvider.Instance.ExecuteScalar(query);
        }
        public List<ShiftDTO> getAllShift() {
            List<ShiftDTO> list = new List<ShiftDTO>();
            string query = "select * from Shift";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows) {
                ShiftDTO shift = new ShiftDTO(row);
                list.Add(shift);
            }
            return list;
        }
    }
}
