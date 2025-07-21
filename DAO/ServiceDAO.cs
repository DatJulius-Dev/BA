using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhongKham.DAO {
    public class ServiceDAO {
        private static ServiceDAO instance;
        private ServiceDAO() { }
        public static ServiceDAO Instance {
            get {
                if (instance == null)
                    instance = new ServiceDAO();
                return instance;
            }
            private set => instance = value;
        }
        public ServiceDTO getServiceByID(int id) {
            string query = String.Format("select * from Service where ID ={0}", id);
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows) {
                return new ServiceDTO(row);
            }
            return null;
        }
        public List<ServiceDTO> getServiceAll() {
            List<ServiceDTO> List = new List<ServiceDTO>();
            DataTable dt = DataProvider.Instance.ExecuteQuery("select * from Service where ID not in (select ID from Medicine)");
            foreach (DataRow row in dt.Rows) {
                ServiceDTO service = new ServiceDTO(row);
                List.Add(service);
            }
            return List;
        }
        public bool isExistService(string name ) {
            return (int) DataProvider.Instance.ExecuteScalar(String.Format("select count(*) from Service where name = N'{0}'", name)) > 0;
        }
        public int insertService( ServiceDTO service ) {
            string query = "insert into Service( name, unit, price , note) values( @name , @unit , @price , @note )";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { service.Name.ToString(), service.Unit.ToString(), service.Price, service.Note.ToString() });

        }
        public int updateService( ServiceDTO service ) {
            string query = "update Service set name = @name, unit = @unit, price = @price, note = @note where ID = @ID";
            return DataProvider.Instance.ExecuteNonQuery(query, new object[] { service.Name.ToString(), service.Unit.ToString(), service.Price, service.Note.ToString(), service.ID });
        }
        public List<ServiceDTO> findServiceByName( string name ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Service where name like '%{0}%'", name.Trim()));
            List<ServiceDTO> list = new List<ServiceDTO>();
            foreach (DataRow row in table.Rows) {
                list.Add(new ServiceDTO(row));
            }
            return list;
        }
        public ServiceDTO getServiceByName( string name ) {
            DataTable table = DataProvider.Instance.ExecuteQuery(String.Format("select * from Service where name = '{0}'", name));
            foreach (DataRow row in table.Rows) {
                return new ServiceDTO(row);
            }
            return null;
        }
        public int getLastestServiceID() {
            return (int) DataProvider.Instance.ExecuteScalar("select top(1) ID from Service order by ID desc");
        }
    }
}
