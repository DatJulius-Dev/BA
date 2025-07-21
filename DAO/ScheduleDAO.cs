using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class ScheduleDAO {
        private static ScheduleDAO instance;
        private ScheduleDAO() { }

        public static ScheduleDAO Instance {
            get {
                if (instance == null)
                    instance = new ScheduleDAO();
                return instance;
            }
            private set => instance = value;
        }
        public Boolean checkOldPatient(int id ) {
            string query = String.Format("select count(*) from Schedule where patientID = {0}", id);
            int check = (int) DataProvider.Instance.ExecuteScalar(query);
            return check > 0 ? true : false;
        }
    }
}
