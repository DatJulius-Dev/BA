using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class QuanLyNhanVien : UserControl {
        public QuanLyNhanVien() {
            InitializeComponent();
            loadEmployee(EmployeeDAO.Instance.getAllEmployee());
        }
        public void loadEmployee(List<EmployeeDTO> list ) {
            lvwEmployee.Items.Clear();
            foreach(EmployeeDTO employee in list) {
                ListViewItem item = new ListViewItem(employee.ID.ToString());
                item.SubItems.Add(employee.Name);
                item.SubItems.Add(employee.PhoneNumber);
                item.SubItems.Add(employee.Sex);
                item.SubItems.Add(employee.Email);
                item.SubItems.Add(PositionDAO.Instance.getNameByID(employee.PositionID));
                item.SubItems.Add(employee.Address);
                lvwEmployee.Items.Add(item);
            }
        }
        private void btnAddEmployee_Click( object sender, EventArgs e ) {
            DangKyNhanVien dk = new DangKyNhanVien();
            this.Parent.Hide();
            dk.ShowDialog();
            loadEmployee(EmployeeDAO.Instance.getAllEmployee());
            this.Parent.Show();
        }

        private void tbxSearch_TextChanged( object sender, EventArgs e ) {
            loadEmployee(EmployeeDAO.Instance.findEmployeeByName(tbxSearch.Text));
        }
    }
}
