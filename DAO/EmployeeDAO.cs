using iTextSharp.text;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO
{
    public class EmployeeDAO
    {
        private static EmployeeDAO instance;
        private EmployeeDAO() { }

        public static EmployeeDAO Instance
        {
            get
            {
                if (instance == null) instance = new EmployeeDAO();
                return instance;
            }
            private set { instance = value; }
        }

        public EmployeeDTO checkLogin(string phoneNumber, string password)
        {
            string query = "select * from Employee WHERE phoneNumber = @phoneNumber and password = @password";
            DataTable table = DataProvider.Instance.ExecuteQuery(query, new object[] { phoneNumber, password });
            if (table.Rows.Count == 1) {
                foreach (DataRow row in table.Rows) {
                    return new EmployeeDTO(row);
                }
                
            }
            return null;
        }
        public int insertEmployee(EmployeeDTO employee) {
            int sex = employee.Sex.Equals("Nam") ? 1 : 0;
            string query = "exec sp_insertEmployee @positionID , @branchID , @name , @birthday , @sex , @phoneNumber , @address , @email";
            int check = DataProvider.Instance.ExecuteNonQuery(query, new object[] { employee.PositionID, employee.BranchID, employee.Name, employee.Birthday, sex, employee.PhoneNumber, employee.Address, employee.Email });
            if(check <=0)
                return check;
            if(employee.PositionID == 2) {
                query = String.Format("insert into Dentist(ID) values ({0})",getEmployeeByPhoneNumber(employee.PhoneNumber).ID);
                return DataProvider.Instance.ExecuteNonQuery(query);
            }
            return 1;

        }
        public EmployeeDTO getEmployeeByID(int id ) {
            string query = String.Format("select * from Employee where ID = {0}", id);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;
        }
        public EmployeeDTO getEmployeeByPhoneNumber(string phoneNumber) {
            string query = String.Format("select * from Employee where phoneNumber = {0}", phoneNumber);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;

        }
        public List<EmployeeDTO> getAllEmployee() {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = "select * from Employee";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new EmployeeDTO(row));
            }
            return list;
        }
        public List<EmployeeDTO> findEmployeeByName(string name ) {
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            string query = String.Format("select * from Employee where name like N'%{0}%'", name);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                list.Add(new EmployeeDTO(row));
            }
            return list;
        }
        public EmployeeDTO findEmployeeByID(int ID ) {
            string query = String.Format("select * from Employee where ID ={0}", ID);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;
        }
        public EmployeeDTO findEmployeeByEmail(string email) {
            string query = String.Format("select * from Employee where email ='{0}'", email.Trim());
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in table.Rows) {
                return new EmployeeDTO(row);
            }
            return null;
        }
        public int changePassword(int ID, string password) {
            string query = "update Employee set password = @password where ID = @ID";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { password, ID });
        }
        public List<EmployeeDTO> getAllAssistant() {
            string query = "select * from Employee where positionID = 5";
            List<EmployeeDTO> list = new List<EmployeeDTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows) {
                 list.Add(new EmployeeDTO(row));
                
            }
            return list;
        }
        public int getEmployeeIDByName(string name ) {
            string query = String.Format("select ID from Employee where name = N'{0}'", name);
            return (int) DataProvider.Instance.ExecuteScalar(query);
        }
    }
}
