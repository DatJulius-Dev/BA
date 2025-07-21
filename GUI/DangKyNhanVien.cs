using QuanLyPhongKham.BLL;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class DangKyNhanVien : Form {
        Dictionary<string,int> nameIDPosition = new Dictionary<string,int>();
        Dictionary<string,int> addressIDBranch = new Dictionary<string,int>();

        public DangKyNhanVien() {
            InitializeComponent();
        }

        private void DangKy_Load( object sender, EventArgs e ) {
            loadPosition();
            loadBranch();
        }
        private void loadPosition() {
            List<PositionDTO> positions = PositionBLL.Instance.loadPosition();
            foreach(PositionDTO position in positions ) {
                cbbPosition.Items.Add(position.Name);
                nameIDPosition.Add(position.Name, position.ID);
            }
        }
        private void loadBranch() {
            List<BranchDTO> branchs = BranchBLL.Instance.loadBranch();
            foreach (BranchDTO branch in branchs) {
                cbbBranch.Items.Add(branch.Address);
                addressIDBranch.Add(branch.Address, branch.ID); 
            }

        }

        private void btnLogup_Click( object sender, EventArgs e ) {
            string sex = rdbMale.Checked ? "Nam" : "Nữ";
            string result = EmployeeBLL.Instance.insertEmployee(new EmployeeDTO(nameIDPosition[cbbPosition.Text], addressIDBranch[cbbBranch.Text], tbxName.Text, dtpBirthday.Value, sex, tbxSdt.Text, tbxAddress.Text, tbxEmail.Text));
            MessageBox.Show(result);
            this.Close();
        }

        private void dtpBirthday_ValueChanged( object sender, EventArgs e ) {
            (sender as DateTimePicker).CustomFormat = "yyyy//MM//dd";
        }
    }
}
