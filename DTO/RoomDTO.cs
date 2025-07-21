using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DTO {
    public class RoomDTO {
        private int roomNumber;
        public RoomDTO(DataRow row ) {
            this.roomNumber = (int)row["roomNumber"];
        }
        public int RoomNumber { get => roomNumber; set => roomNumber = value; }
    }
}
