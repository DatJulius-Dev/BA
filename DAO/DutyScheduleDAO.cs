using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class DutyScheduleDAO {
        private static DutyScheduleDAO instance;
        private DutyScheduleDAO() { }

        public static DutyScheduleDAO Instance {
            get {
                if (instance == null)
                    instance = new DutyScheduleDAO();
                return instance;
            }
            private set => instance = value;
        }
        public DutyScheduleDTO getDutyScheduleByDentistID(int dentist ) {
            string query ="select * from DutySchedule where dentistID = @dentistID and date= @date and shiftID = @shift";
            int shiftID = 1;
            if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18) {
                shiftID = 2;
            }
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { dentist, DateTime.Now.ToString("MM/dd/yyyy"), shiftID });
            foreach(DataRow row in table.Rows) {
                return new DutyScheduleDTO(row);
            }
            return null;

        }
        public DutyScheduleDTO getDutyScheduleByRoomNumber(int roomNumber ) {
            //string query ="select * from DutySchedule where roomNumber= @room and date= @date and shiftID = @shift";
            int shiftID = 1;
            if(DateTime.Now.Hour >= 12 && DateTime.Now.Hour <= 18) {
                shiftID = 2;
            }
            string query =String.Format("select * from DutySchedule where roomNumber= {0} and date= '{1}' and shiftID = {2}",roomNumber,DateTime.Now.ToString("MM/dd/yyyy"),shiftID);
            //else if(DateTime.Now.Hour >= 7 && DateTime.Now.Hour <= 11) {
            //    shiftID = 1;
            //}
            //DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { roomNumber, DateTime.Now.ToString("dd/MM/yyyy"), shiftID });
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new DutyScheduleDTO(row);
            }
            return null;

        }
        public List<DutyScheduleDTO> getDutyScheduleByDate(DateTime day ) {
            if (checkCreateDutySchedule(day) == 0) {
                createDutySchedule(day);
            }
            List<DutyScheduleDTO> list = new List<DutyScheduleDTO>();
            DataTable table = DataProvider.Instance.ExecuteQuery("select * from DutySchedule where date = @date", new object[] { day.ToString("MM/dd/yyyy")});
            foreach(DataRow row in table.Rows) {
                list.Add(new DutyScheduleDTO(row));
            }
            return list;
        }
        public int checkCreateDutySchedule(DateTime date ) {
            string query = "select count(*) from DutySchedule where date = @date";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { date.ToString("MM/dd/yyyy") });
        }
        public int createDutySchedule(DateTime date ) {
            List<RoomDTO> rooms = RoomDAO.Instance.getAllRoom();
            List<ShiftDTO> shifts = ShiftDAO.Instance.getAllShift();
            string query = "insert into DutySchedule(date, roomNumber, shiftID) values ";
            foreach(ShiftDTO shift in shifts) {
                foreach(RoomDTO room in rooms) {
                    query += String.Format("( '{0}', {1}, {2}),",date.ToString("yyyy/MM/dd"),room.RoomNumber,shift.ID);
                }
            }
            return DataProvider.Instance.ExecuteNonQuery(query.Substring(0,query.Length -1));
        }
        public int updateDutySchedule(DutyScheduleDTO dutySchedule ) {
            string query = "update DutySchedule set dentistID = @dentist , assistantID = @assistant where date = @date and roomNumber = @room and shiftID = @shift";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { dutySchedule.DentistID, dutySchedule.AssistantID, dutySchedule.Date.ToString("MM/dd/yyyy"), dutySchedule.RoomNumber, dutySchedule.ShiftID });
        }
        public bool existDutyScheduleDentist(int shiftID, DateTime date, int dentistID) {
            string query = "select count(*) from DutySchedule where date = @date and shiftID = @shift and dentistID = @dentist";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { date.ToString("MM/dd/yyyy"), shiftID , dentistID}) > 0;
        }
        public bool existDutyScheduleAssistant( int shiftID, DateTime date, int assistantID) {
            string query = "select count(*) from DutySchedule where date = @date and shiftID = @shift and assistantID = @dentist";
            return (int)DataProvider.Instance.ExecuteScalar(query, new object[] { date.ToString("MM/dd/yyyy"), shiftID , assistantID}) > 0;
        }
    }
}
