using QuanLyPhongKham.BLL;
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
    public partial class AddService : Form {
        public AddService() {
            InitializeComponent();
        }





        private void btnSave_Click( object sender, EventArgs e ) {
            if (tbxName.Text == "" || cbbType.Text == ""|| tbxPrice.Text=="") {
                lblError.Text = "Vui lòng nhập đầy đủ thông tin";
                lblError.Visible = true;
                return;
            }
            lblError.Visible = false;
            int iD = -1;
            string name = tbxName.Text;
            if(ServiceDAO.Instance.isExistService(name))
                iD= ServiceDAO.Instance.getServiceByName(name).ID;
            string unit = tbxUnit.Text;
            int price = int.Parse(tbxPrice.Text);
            string note = tbxNote.Text;
            switch (cbbType.Text[0]) {
                case '1':
                    if(nudQuantity.Value<=0) {
                        lblError.Text = "Vui lòng nhập số lượng";
                        lblError.Visible = true;
                        return;
                    }
                    if (MedicineDAO.Instance.insertMedicine(name, unit, price, (int) nudQuantity.Value, note) != 1) {
                        MessageBox.Show("Thêm dịch vụ không thành công", "Successfully", MessageBoxButtons.OK);
                        return;
                    }
                    break;
                case '2':
                    if (ServiceDAO.Instance.insertService(new ServiceDTO(iD, name, unit, price, note)) != 1) {
                        MessageBox.Show("Thêm dịch vụ không thành công", "Successfully", MessageBoxButtons.OK);
                        return;
                    }
                    break;

            }
            MessageBox.Show("Thêm dịch vụ thành công", "Successfully", MessageBoxButtons.OK);

        }
        private void btnReset_Click( object sender, EventArgs e ) {
            tbxName.Text = "";
            cbbType.Text = "";
            pnlQuantity.Visible = false;
            tbxPrice.Text = "";
            tbxUnit.Text = "";
            tbxNote.Text = "";

        }


        private void cbbType_SelectedIndexChanged( object sender, EventArgs e ) {
            if (cbbType.SelectedItem.ToString() == "1.Thuốc") {
                tbxUnit.Text = "Viên";
                pnlQuantity.Visible = true;
            }
            else {
                tbxUnit.Text = "Lần";
                pnlQuantity.Visible = false;
            }
        }

        private void btnExit_Click( object sender, EventArgs e ) {
            this.Close();
        }
    }
}
