using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.DAO {
    public class DataProvider {
        //private string db = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True";
        private string db;
        private static DataProvider instance;

        private DataProvider() {
            try {
                db = ConfigurationManager.ConnectionStrings["myDatabase"].ConnectionString;

            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message);
            }

        }
        public static DataProvider Instance {
            get {
                if (instance == null) {
                    instance = new DataProvider();

                }
                return instance;

            }
            private set => instance = value;
        }


        public int ExecuteNonQuery( string query, object[] paramater = null ) {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(db)) {
                try {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null) {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string para in listPara) {
                            if (para[0] == '@') {
                                command.Parameters.AddWithValue(para, paramater[i++]);
                            }
                        }
                    }
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            return data;
        }
        public object ExecuteScalar( string query, object[] paramater = null ) {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(db)) {
                try {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null) {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string para in listPara) {
                            if (para[0] == '@') {
                                command.Parameters.AddWithValue(para, paramater[i++]);
                            }
                        }
                    }
                    data = command.ExecuteScalar();
                    connection.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }
            return data;
        }
        public DataTable ExecuteQuery( string query, object[] paramater = null ) {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(db)) {
                try {
                    connection.Open();

                    SqlCommand command = new SqlCommand(query, connection);
                    if (paramater != null) {
                        string[] listPara = query.Split(' ');
                        int i = 0;
                        foreach (string para in listPara) {
                            if (para[0] == '@') {
                                command.Parameters.AddWithValue(para, paramater[i++]);
                            }
                        }
                    }
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(table);
                    connection.Close();
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
            }


            return table;
        }
    }
}
