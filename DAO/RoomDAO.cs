using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO {
    public class RoomDAO {
        private static RoomDAO instance;
        private RoomDAO() { }

        public static RoomDAO Instance {
            get {
                if (instance == null)
                    instance = new RoomDAO();
                return instance;
            }
            private set => instance = value;
        }
        public List<RoomDTO> getAllRoom() {
            List<RoomDTO> allRooms = new List<RoomDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from Room");
            foreach (DataRow row in table.Rows) {
                allRooms.Add(new RoomDTO(row));
            }
            return allRooms;
        }
        public RoomDTO getRoomByRoomNumber(int roomNumber) {
            string query = String.Format("select * from Room where roomNumber = {0}", roomNumber);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new RoomDTO(row);
            }
            return null;
        }
    }
}
