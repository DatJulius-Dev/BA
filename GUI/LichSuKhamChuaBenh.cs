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
    public partial class LichSuKhamChuaBenh : UserControl
    {
        public LichSuKhamChuaBenh()
        {
            InitializeComponent();
        }
        public void loadTreamentRecord(int patientID ) {
            lvwTreamentRecords.Items.Clear();
            List<TreamentRecordsDTO> list = TreamentRecordsDAO.Instance.getAllTreamentRecordsByPatientID( patientID );
            foreach( TreamentRecordsDTO record in list) {
                ListViewItem item = new ListViewItem(record.Date.Date.ToString("dd/MM/yyyy"));
                item.SubItems.Add(DentistDAO.Instance.getDentistByID(record.DentistID).Name);
                item.SubItems.Add(record.Diagnostic);
                lvwTreamentRecords.Items.Add(item);
            }
        }
    }
}
