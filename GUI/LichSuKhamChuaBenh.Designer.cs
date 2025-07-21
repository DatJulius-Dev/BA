namespace QuanLyPhongKham.GUI
{
    partial class LichSuKhamChuaBenh
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvwTreamentRecords = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwTreamentRecords
            // 
            this.lvwTreamentRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3});
            this.lvwTreamentRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwTreamentRecords.GridLines = true;
            this.lvwTreamentRecords.HideSelection = false;
            this.lvwTreamentRecords.Location = new System.Drawing.Point(4, 55);
            this.lvwTreamentRecords.Margin = new System.Windows.Forms.Padding(4);
            this.lvwTreamentRecords.Name = "lvwTreamentRecords";
            this.lvwTreamentRecords.Size = new System.Drawing.Size(1591, 361);
            this.lvwTreamentRecords.TabIndex = 0;
            this.lvwTreamentRecords.UseCompatibleStateImageBehavior = false;
            this.lvwTreamentRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày khám";
            this.columnHeader2.Width = 230;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Bác sĩ khám";
            this.columnHeader4.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Chuẩn đoán";
            this.columnHeader3.Width = 1189;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Location = new System.Drawing.Point(4, 2);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1591, 47);
            this.panel9.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(215, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "Lịch sử khám chữa bệnh";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LichSuKhamChuaBenh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.lvwTreamentRecords);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LichSuKhamChuaBenh";
            this.Size = new System.Drawing.Size(1599, 420);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwTreamentRecords;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
