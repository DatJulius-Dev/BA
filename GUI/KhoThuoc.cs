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

namespace QuanLyPhongKham.GUI
{
    public partial class KhoThuoc : UserControl
    {
        public KhoThuoc()
        {
            InitializeComponent();
        }


        public void loadMedicine(List<MedicineDTO> list ) {
            lvwMedicine.Items.Clear();
            foreach(MedicineDTO medicine in list) {
                ListViewItem item = new ListViewItem(medicine.ID.ToString());
                item.SubItems.Add(medicine.Name);
                item.SubItems.Add(medicine.Price.ToString());
                item.SubItems.Add(medicine.Stock.ToString());
                item.Tag = medicine;
                lvwMedicine.Items.Add(item);
            }
        }
        private void tbxSearch_TextChanged( object sender, EventArgs e ) {
            loadMedicine(MedicineDAO.Instance.findMedicineByName(tbxSearch.Text));
        }

        private void KhoThuoc_Load( object sender, EventArgs e ) {
            loadMedicine(MedicineDAO.Instance.getAllMedicine());
        }

        private void btnEnterMedicine_Click( object sender, EventArgs e ) {
            AddService addService = new AddService();
            addService.ShowDialog();
            loadMedicine(MedicineDAO.Instance.getAllMedicine());
        }
        public void reload() {
            loadMedicine(MedicineDAO.Instance.getAllMedicine());
        }
    }
}
