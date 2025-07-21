using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.BLL {
    public class PositionBLL {
        private static PositionBLL instance;
        private PositionBLL() { }

        public static PositionBLL Instance {
            get {
                if (instance == null)
                    instance = new PositionBLL();
                return instance;
            }
            set => instance = value;
        }
        public List<PositionDTO> loadPosition() {
            return PositionDAO.Instance.getAllPosition();
        }
    }
}
