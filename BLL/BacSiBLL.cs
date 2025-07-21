using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.BLL {
    public class BacSiBLL {
        private static BacSiBLL instance;
        private Dictionary<int, Queue<PatientTreamentNeedsDTO>> queuePatient = new Dictionary<int, Queue<PatientTreamentNeedsDTO>>();
        private BacSiBLL() {
            List<RoomDTO> roomList = RoomDAO.Instance.getAllRoom();
            foreach(RoomDTO room in roomList) {
                queuePatient.Add(room.RoomNumber, new Queue<PatientTreamentNeedsDTO>());
            }
        }

        public static BacSiBLL Instance {
            get {
                if (instance == null)
                    instance = new BacSiBLL();
                return instance;
            }
            private set => instance = value;
        }

        public Dictionary<int, Queue<PatientTreamentNeedsDTO>> QueuePatient { get => queuePatient; set => queuePatient = value; }

        public List<PatientDTO> getAllPatients() {
            return PatientDAO.Instance.getAllPatient();
        }
    }
}
