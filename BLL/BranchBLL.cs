using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.BLL {
    public class BranchBLL {
        private static BranchBLL instance;
        private BranchBLL() { }

        public static BranchBLL Instance {
            get {
                if (instance == null)
                    instance = new BranchBLL();
                return instance;
            }
            set => instance = value;
        }
        public List<BranchDTO> loadBranch() {
            return BranchDAO.Instance.getAllBranch();
        }
    }
}
