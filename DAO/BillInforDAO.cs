using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class BillInforDAO {
        private static BillInforDAO instance;
        private BillInforDAO() { }

        public static BillInforDAO Instance {
            get {
                if (instance == null)
                    instance = new BillInforDAO();
                return instance;
            }
            private set => instance = value;
        }
        public bool insertBillInfor(BillInforDTO billInfor ) {
            string query = "insert into BillInfor values( @bill , @service , @quantity)";
            int check = DataProvider.Instance.ExecuteNonQuery( query , new object[] {billInfor.BillID, billInfor.ServiceID, billInfor.Quantity});
            return check > 0;
        }
        private bool existBillInfor(int billID, int serviceID ) {
            string query = String.Format("select count(*) from BillInfor where billID={0} and serviceID ={1}", billID, serviceID);
            return (int) DataProvider.Instance.ExecuteScalar(query) > 0;
        }
        public bool insertBillInfor(int billID, int serviceID, int quantity ) {
            int check;
            string query;
            if (existBillInfor(billID, serviceID)) {
                 query= String.Format("update BillInfor set quantity = quantity + {0} where billID = {1} and serviceID ={2}", quantity, billID, serviceID);
                check = DataProvider.Instance.ExecuteNonQuery(query);
                return check>0;
            }
            query = "insert into BillInfor values( @bill , @service , @quantity )";
            check = DataProvider.Instance.ExecuteNonQuery( query , new object[] {billID, serviceID, quantity});
            if(check <=0)
                return false;
            query = String.Format("update Medicine set stock = stock - {0} where ID = {1}", quantity, serviceID);
            check = DataProvider.Instance.ExecuteNonQuery(query);
            return check > 0;
        }
        public bool deleteBillInfor(int billID, int serviceID , int quantity) {
            string query = String.Format("delete from BillInfor where billID = {0} and serviceID = {1}", billID, serviceID);
            int check = DataProvider.Instance.ExecuteNonQuery(query);
            if (check <= 0)
                return false;
            query = String.Format("update Medicine set stock = stock + {0} where ID = {1}", quantity, serviceID);
            check = DataProvider.Instance.ExecuteNonQuery(query);
            return check > 0;
        }
        public List<BillInforDTO> getBillInforByBillID(int billID) {
            string query = String.Format("select * from BillInfor where billID ={0}", billID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<BillInforDTO> list = new List<BillInforDTO>();
            foreach(DataRow row in table.Rows) {
                list.Add(new BillInforDTO(row));
            }
            return list;
        }
        public List<BillInforDTO> getPrescriptionByBillID(int billID) {
            string query = String.Format("select * from BillInfor b, Medicine m where b.billID ={0} and m.ID = b.serviceID", billID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            List<BillInforDTO> list = new List<BillInforDTO>();
            foreach(DataRow row in table.Rows) {
                list.Add(new BillInforDTO(row));
            }
            return list;
        }
    }
}
