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
    public partial class KhamLamSang : UserControl
    {
        public KhamLamSang()
        {
            InitializeComponent();
        }

        private void btnSave_Click( object sender, EventArgs e ) {
            if(tbxStatus.Text.Trim() == "") {
                lblStatusErr.Visible = true;
                return;
            }
            lblStatusErr.Visible = false;
            if(tbxDiagnostic.Text.Trim() == "") {
                lblDiagnosticErr.Visible = true;
                return;
            }
            lblDiagnosticErr.Visible = false;
            if(tbxTreatmentDirection.Text.Trim() == "") {
                lblDirectErr.Visible = true;
                return;
            }
            lblDirectErr.Visible = false;
            TreamentRecordsDTO treamentRecords = this.Tag as TreamentRecordsDTO;
            treamentRecords.Status = tbxStatus.Text;
            treamentRecords.OtherDiseases = tbxOtherDiseases.Text;
            treamentRecords.DrugAllergy = tbxDrugAllergy.Text;
            treamentRecords.Diagnostic = tbxDiagnostic.Text;
            treamentRecords.TreamentDirection = tbxTreatmentDirection.Text;
            treamentRecords.Date = DateTime.Now;
            treamentRecords.Note = tbxNote.Text;
            if(TreamentRecordsDAO.Instance.updateTreamentRecord(treamentRecords)) {
                MessageBox.Show("Đã lưu hồ sơ");
            }
            else {
                MessageBox.Show("Lưu khoogn thành công");
            }
        }
        public void loadTreamentRecord(TreamentRecordsDTO treamentRecords ) {
            tbxStatus.Text = treamentRecords.Status;
            tbxOtherDiseases.Text = treamentRecords.OtherDiseases;
            tbxDrugAllergy.Text = treamentRecords.DrugAllergy;
            tbxDiagnostic.Text = treamentRecords.Diagnostic;
            tbxTreatmentDirection.Text = treamentRecords.TreamentDirection;
            tbxNote.Text = treamentRecords.Note;
        }
    }
}
