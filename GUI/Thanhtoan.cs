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
    public partial class ThanhToan : UserControl {
        public ThanhToan() {
            InitializeComponent();
        }

        private void ThanhToan_Load( object sender, EventArgs e ) {

        }
        private void loadBillInfor(List<BillInforDTO> list ) {
            lvwBillInfor.Items.Clear();
            int totalFee = 0;
            foreach (BillInforDTO billInfor in list) {
                ServiceDTO service = ServiceDAO.Instance.getServiceByID(billInfor.ServiceID);
                ListViewItem item = new ListViewItem(service.Name);
                item.SubItems.Add(billInfor.Quantity.ToString());
                int price = billInfor.Quantity * service.Price;
                item.SubItems.Add(price.ToString());
                lvwBillInfor.Items.Add(item);
                totalFee += price;
            }
            btnTotalFee.Text = totalFee.ToString();
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            if(tbxBillID.Text.Trim() == "") {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }
            int billID;
            if(int.TryParse(tbxBillID.Text,out billID)== false) {
                MessageBox.Show("Mã hóa đơn không chính xác");
                return;
            }
            btnTotalFee.Text = "0";
            List<BillInforDTO> list = BillInforDAO.Instance.getBillInforByBillID(int.Parse(tbxBillID.Text));
            if(list.Count <= 0) {
                MessageBox.Show("Mã hóa đơn không chính xác");
                return;
            }
            loadBillInfor(list);
            if(BillDAO.Instance.getBillByID(int.Parse(tbxBillID.Text)).Status == true) {
                btnTotalFee.Text = "0";
                return;
            }
            
        }

        private void btnPay_Click( object sender, EventArgs e ) {
            if(tbxBillID.Text.Trim() == "") {
                MessageBox.Show("Vui lòng nhập mã hóa đơn");
                return;
            }
            if(btnTotalFee.Text == "0") {
                MessageBox.Show("Hóa đơn đã được thanh toán");
                return;
            } 
            if (BillDAO.Instance.payBillByBillID(int.Parse(tbxBillID.Text))) {
                btnTotalFee.Text = "0";
                MessageBox.Show("Thanh toán thành công");
            }
            else {
                MessageBox.Show("Thanh toán thất bại");
            }
        }

    }
}
