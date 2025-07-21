namespace QuanLyPhongKham.GUI {
    partial class DuLieuDiemDanh {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing ) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lvwAttendance = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lvwAttendance
            // 
            this.lvwAttendance.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwAttendance.GridLines = true;
            this.lvwAttendance.HideSelection = false;
            this.lvwAttendance.Location = new System.Drawing.Point(0, 63);
            this.lvwAttendance.Name = "lvwAttendance";
            this.lvwAttendance.Size = new System.Drawing.Size(1641, 850);
            this.lvwAttendance.TabIndex = 0;
            this.lvwAttendance.UseCompatibleStateImageBehavior = false;
            this.lvwAttendance.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên nhân viên";
            this.columnHeader1.Width = 328;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Chức vụ";
            this.columnHeader2.Width = 301;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thời gian đăng nhập";
            this.columnHeader3.Width = 756;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dữ liệu điểm danh";
            // 
            // DuLieuDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvwAttendance);
            this.Name = "DuLieuDiemDanh";
            this.Size = new System.Drawing.Size(1644, 916);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvwAttendance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}
