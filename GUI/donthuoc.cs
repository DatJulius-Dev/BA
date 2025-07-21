using iTextSharp.text.pdf;
using iTextSharp.text;
using QuanLyPhongKham.DAO;
using QuanLyPhongKham.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongKham.GUI {
    public partial class DonThuoc : UserControl {

        public DonThuoc() {
            InitializeComponent();
            loadStockMedicine(MedicineDAO.Instance.getAllMedicine());
        }
        private void loadStockMedicine( List<MedicineDTO> list ) {
            lvwStockMedicine.Items.Clear();
            foreach( MedicineDTO medicine in list ) {
                ListViewItem item = new ListViewItem(medicine.ID.ToString());
                item.SubItems.Add(medicine.Name);
                item.SubItems.Add(medicine.Stock.ToString());
                lvwStockMedicine.Items.Add(item);
            }
        }


        private void tbsSearch_TextChanged( object sender, EventArgs e ) {
           loadStockMedicine(MedicineDAO.Instance.findMedicineByName(tbsSearch.Text));
        }
        public void loadPrecrciption(List<BillInforDTO> prescription ) {
            lvwPrescription.Items.Clear();
            foreach(BillInforDTO billInfor in prescription) {
                ServiceDTO service = ServiceDAO.Instance.getServiceByID(billInfor.ServiceID);
                ListViewItem item = new ListViewItem(service.ID.ToString());
                item.SubItems.Add(service.Name);
                item.SubItems.Add(billInfor.Quantity.ToString());
                lvwPrescription.Items.Add(item);
            }
        }
        
        private void btnPrintPrescription_Click( object sender, EventArgs e ) {
            if(lvwPrescription.Items.Count == 0) {
                MessageBox.Show("Không có thuốc nào được kê");
                return;
            }
            iTextSharp.text.Document document = new iTextSharp.text.Document();
            TreamentRecordsDTO treamentRecord = this.Tag as TreamentRecordsDTO;
            string nameFile = PatientDAO.Instance.getPatientByID(treamentRecord.PatientID).Name+"_"+ treamentRecord.ID + ".pdf";
            PdfWriter.GetInstance(document, new FileStream(nameFile, FileMode.Create));

            document.Open();
            //sửa lại path arial.ttf, mang vào resource
            BaseFont bf = BaseFont.CreateFont(@"C:\Windows\Fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font fontHeader = new iTextSharp.text.Font(bf, 20, iTextSharp.text.Font.BOLD);
            iTextSharp.text.Font fontPaticular = new iTextSharp.text.Font(bf, 11);
            Paragraph header = new Paragraph("ĐƠN THUỐC", fontHeader);
            header.Alignment = Element.ALIGN_CENTER;
            document.Add(header);

            PdfPTable table = new PdfPTable(3);
            table.WidthPercentage = 100;
            table.SpacingBefore = 10f;
            table.SpacingAfter = 10f;
            PdfPCell column1 = new PdfPCell(new Phrase("Mã thuốc", fontPaticular));
            column1.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(column1);

            PdfPCell column2 = new PdfPCell(new Phrase("Tên Thuốc", fontPaticular));
            column2.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(column2);

            PdfPCell column3 = new PdfPCell(new Phrase("Số Lượng", fontPaticular));
            column3.HorizontalAlignment = Element.ALIGN_CENTER;
            table.AddCell(column3);


            foreach(ListViewItem item in lvwPrescription.Items) {
                table.AddCell(item.SubItems[0].Text);
                table.AddCell(item.SubItems[1].Text);
                table.AddCell(item.SubItems[2].Text);
            }   
            document.Add(table);
            Paragraph bill = new Paragraph("Mã hóa đơn:"+ BillDAO.Instance.getBillByTreamentRecord(treamentRecord.ID).ID, fontPaticular);
            bill.Alignment = Element.ALIGN_RIGHT;
            document.Add(bill);
            Paragraph footer = new Paragraph("Bác Sĩ Kê:"+ DentistDAO.Instance.getDentistByID(treamentRecord.DentistID).Name, fontPaticular);
            footer.Alignment = Element.ALIGN_RIGHT;
            document.Add(footer);

            Paragraph date = new Paragraph("Ngày Xuất Đơn:" + DateTime.Now.ToString("dd/MM/yyyy HH:mm"), fontPaticular);
            date.Alignment = Element.ALIGN_RIGHT;
            document.Add(date);

            document.Close();

            System.Diagnostics.Process.Start(nameFile);

        }

        private void btnRemoveMedicine_Click( object sender, EventArgs e ) {
            if (lvwPrescription.SelectedItems.Count != 1) {
                MessageBox.Show("Vui lòng chọn 1 loại thuốc");
                return;
            }
            int billID = BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID;
            int serviceID = int.Parse(lvwPrescription.SelectedItems[0].SubItems[0].Text);
            if (BillInforDAO.Instance.deleteBillInfor(billID, serviceID, int.Parse(lvwPrescription.SelectedItems[0].SubItems[2].Text))) {
                loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID));
                loadStockMedicine(MedicineDAO.Instance.getAllMedicine());
            }
            else {
                MessageBox.Show("Lỗi");
            }
        }
        private void btnAddMedicine_Click( object sender, EventArgs e ) {
            if (lvwStockMedicine.SelectedItems.Count != 1) {
                MessageBox.Show("Vui lòng chọn 1 loại thuốc");
                return;
            }
            if (nudQuantity.Value <= 0) {
                MessageBox.Show("Số lượng thuốc không hợp lệ");
                return;
            }
            int billID = BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID;
            int serviceID = int.Parse(lvwStockMedicine.SelectedItems[0].SubItems[0].Text);
            if (BillInforDAO.Instance.insertBillInfor(billID, serviceID, (int) nudQuantity.Value)) {
                MessageBox.Show("Thêm thành công");
                loadPrecrciption(BillInforDAO.Instance.getPrescriptionByBillID(BillDAO.Instance.getBillByTreamentRecord((this.Tag as TreamentRecordsDTO).ID).ID));
                loadStockMedicine(MedicineDAO.Instance.getAllMedicine());
                nudQuantity.Value = 1;
            }
            else {
                MessageBox.Show("Lỗi");
            }
        }

    }
}
