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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QuanLyPhongKham.GUI {
    public partial class Pricelist : UserControl {
        public Pricelist() {
            InitializeComponent();
        }
        private void Pricelist_Load( object sender, EventArgs e ) {
            loadPriceList(ServiceDAO.Instance.getServiceAll());
        }
        public void reload() {
            loadPriceList(ServiceDAO.Instance.getServiceAll());
        }
        private void btnAdd_Click( object sender, EventArgs e ) {
            AddService addService = new AddService();
            addService.ShowDialog();
            loadPriceList(ServiceDAO.Instance.getServiceAll());

        }

        public void loadPriceList( List<ServiceDTO> list ) {
            lvpricelist.Items.Clear();
            foreach (ServiceDTO service in list) {
                ListViewItem lvwItem = new ListViewItem(service.ID.ToString());
                lvwItem.SubItems.Add(service.Name.ToString());
                lvwItem.SubItems.Add(service.Unit.ToString());
                lvwItem.SubItems.Add(service.Price.ToString());
                lvwItem.SubItems.Add(service.Note.ToString());
                lvwItem.Tag = service;
                lvpricelist.Items.Add(lvwItem);
            }
        }
        //private void lvpricelist_SelectedIndexChanged( object sender, EventArgs e ) {
        //    if (lvpricelist.SelectedItems.Count > 0) {
        //        Service_Load(lvpricelist.SelectedItems[0].Tag as ServiceDTO);
        //    }
        //}
        //private void Service_Load( ServiceDTO service ) {
        //    AddService addService = new AddService();
        //    addService.AddService_Load(service);
        //    addService.ShowDialog();

        //}

        private void tbxSearch_TextChatbxSearch( object sender, EventArgs e ) {
            List<ServiceDTO> list = ServiceDAO.Instance.findServiceByName(tbxSearch.Text.Trim());
            loadPriceList(list);
        }

        private void btnSearch_Click( object sender, EventArgs e ) {
            ServiceDTO service = ServiceDAO.Instance.getServiceByName(tbxSearch.Text.Trim());
            if (service == null) {
                if (MessageBox.Show("Dịch vụ không có thông tin trong phòng khám.\nBạn có muốn thêm dịch vụ ?", "Không tìm thấy kết quả", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    btnAdd_Click(sender, e);
                }
                tbxSearch.Text = "";
                return;
            }
            List<ServiceDTO> result = new List<ServiceDTO>();
            result.Add(service);
            loadPriceList(result);
            tbxSearch.Text = "";
        }
        private void btnDelete_Click( object sender, EventArgs e ) {
            //if (lvpricelist.SelectedItems.Count > 0) {
            //    ServiceDAO.Instance.DeleteService((lvpricelist.Se
                    
                    
                    
                    
            //        lectedItems[0].Tag as ServiceDTO));

            //}
            //loadPriceList(ServiceDAO.Instance.getServiceAll());
        }

        //private void btnChange_Click( object sender, EventArgs e ) {
        //    lvpricelist_SelectedIndexChanged(sender, e);
        //    loadPriceList(ServiceDAO.Instance.getServiceAll());
        //}

    }
}
