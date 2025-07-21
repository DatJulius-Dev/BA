using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class BranchDAO {
        private static BranchDAO instance;
        private BranchDAO() { }

        public static BranchDAO Instance {
            get {
                if (instance == null)
                    instance = new BranchDAO();
                return instance;
            }
            private set => instance = value;
        }

        public List<BranchDTO> getAllBranch() {
            string query = "select * from Branch";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<BranchDTO> list = new List<BranchDTO>();
            foreach (DataRow row in table.Rows) {
                list.Add(new BranchDTO(row));
            }
            return list;
        }
    }
}
