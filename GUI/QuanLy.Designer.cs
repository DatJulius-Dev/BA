namespace QuanLyPhongKham.GUI
{
    partial class QuanLy
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDuLieuDiemDanh = new System.Windows.Forms.Button();
            this.btnQuanLyNhanVien = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBaoCaoDanhThu = new System.Windows.Forms.Button();
            this.btnQuanLyBangGia = new System.Windows.Forms.Button();
            this.btnKhoThuoc = new System.Windows.Forms.Button();
            this.scheduleTableAdapter1 = new QuanLyPhongKham.DatabaseDataSetTableAdapters.ScheduleTableAdapter();
            this.khoThuoc = new QuanLyPhongKham.GUI.KhoThuoc();
            this.quanLyBangGia = new QuanLyPhongKham.GUI.Pricelist();
            this.duLieuDiemDanh = new QuanLyPhongKham.GUI.DuLieuDiemDanh();
            this.quanLyNhanVien = new QuanLyPhongKham.GUI.QuanLyNhanVien();
            this.databaseDataSet1 = new QuanLyPhongKham.DatabaseDataSet();
            this.baoCaoDanhThu = new QuanLyPhongKham.GUI.BaoCaoDanhThu();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1921, 57);
            this.panel1.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(3, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "RHM";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.N9_NiceNight__1_;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(1870, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 47);
            this.panel8.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.btnDuLieuDiemDanh);
            this.panel2.Controls.Add(this.btnQuanLyNhanVien);
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnBaoCaoDanhThu);
            this.panel2.Controls.Add(this.btnQuanLyBangGia);
            this.panel2.Controls.Add(this.btnKhoThuoc);
            this.panel2.Location = new System.Drawing.Point(1, 76);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 903);
            this.panel2.TabIndex = 1;
            // 
            // btnDuLieuDiemDanh
            // 
            this.btnDuLieuDiemDanh.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDuLieuDiemDanh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDuLieuDiemDanh.Location = new System.Drawing.Point(13, 79);
            this.btnDuLieuDiemDanh.Margin = new System.Windows.Forms.Padding(0);
            this.btnDuLieuDiemDanh.Name = "btnDuLieuDiemDanh";
            this.btnDuLieuDiemDanh.Size = new System.Drawing.Size(244, 69);
            this.btnDuLieuDiemDanh.TabIndex = 4;
            this.btnDuLieuDiemDanh.Text = "Dữ liệu điểm danh";
            this.btnDuLieuDiemDanh.UseVisualStyleBackColor = false;
            this.btnDuLieuDiemDanh.Click += new System.EventHandler(this.btnDuLieuDiemDanh_Click);
            // 
            // btnQuanLyNhanVien
            // 
            this.btnQuanLyNhanVien.BackColor = System.Drawing.Color.Lime;
            this.btnQuanLyNhanVien.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyNhanVien.Location = new System.Drawing.Point(13, 10);
            this.btnQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanLyNhanVien.Name = "btnQuanLyNhanVien";
            this.btnQuanLyNhanVien.Size = new System.Drawing.Size(244, 69);
            this.btnQuanLyNhanVien.TabIndex = 3;
            this.btnQuanLyNhanVien.Text = "Quản lý nhân viên";
            this.btnQuanLyNhanVien.UseVisualStyleBackColor = false;
            this.btnQuanLyNhanVien.Click += new System.EventHandler(this.btnQuanLyNhanVien_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Firebrick;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(11, 830);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(244, 69);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBaoCaoDanhThu
            // 
            this.btnBaoCaoDanhThu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnBaoCaoDanhThu.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBaoCaoDanhThu.Location = new System.Drawing.Point(11, 148);
            this.btnBaoCaoDanhThu.Margin = new System.Windows.Forms.Padding(0);
            this.btnBaoCaoDanhThu.Name = "btnBaoCaoDanhThu";
            this.btnBaoCaoDanhThu.Size = new System.Drawing.Size(244, 69);
            this.btnBaoCaoDanhThu.TabIndex = 2;
            this.btnBaoCaoDanhThu.Text = "Báo cáo doanh thu";
            this.btnBaoCaoDanhThu.UseVisualStyleBackColor = false;
            this.btnBaoCaoDanhThu.Click += new System.EventHandler(this.btnBaoCaoDanhThu_Click);
            // 
            // btnQuanLyBangGia
            // 
            this.btnQuanLyBangGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnQuanLyBangGia.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyBangGia.Location = new System.Drawing.Point(13, 286);
            this.btnQuanLyBangGia.Margin = new System.Windows.Forms.Padding(0);
            this.btnQuanLyBangGia.Name = "btnQuanLyBangGia";
            this.btnQuanLyBangGia.Size = new System.Drawing.Size(244, 69);
            this.btnQuanLyBangGia.TabIndex = 2;
            this.btnQuanLyBangGia.Text = "Quản lý bảng giá";
            this.btnQuanLyBangGia.UseVisualStyleBackColor = false;
            this.btnQuanLyBangGia.Click += new System.EventHandler(this.btnQuanLyBangGia_Click);
            // 
            // btnKhoThuoc
            // 
            this.btnKhoThuoc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKhoThuoc.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnKhoThuoc.Location = new System.Drawing.Point(13, 217);
            this.btnKhoThuoc.Margin = new System.Windows.Forms.Padding(0);
            this.btnKhoThuoc.Name = "btnKhoThuoc";
            this.btnKhoThuoc.Size = new System.Drawing.Size(244, 69);
            this.btnKhoThuoc.TabIndex = 2;
            this.btnKhoThuoc.Text = "Kho thuốc";
            this.btnKhoThuoc.UseVisualStyleBackColor = false;
            this.btnKhoThuoc.Click += new System.EventHandler(this.btnKhoThuoc_Click);
            // 
            // scheduleTableAdapter1
            // 
            this.scheduleTableAdapter1.ClearBeforeFill = true;
            // 
            // khoThuoc
            // 
            this.khoThuoc.BackColor = System.Drawing.Color.LightCyan;
            this.khoThuoc.Location = new System.Drawing.Point(278, 63);
            this.khoThuoc.Name = "khoThuoc";
            this.khoThuoc.Size = new System.Drawing.Size(1644, 916);
            this.khoThuoc.TabIndex = 5;
            // 
            // quanLyBangGia
            // 
            this.quanLyBangGia.BackColor = System.Drawing.Color.LightCyan;
            this.quanLyBangGia.Location = new System.Drawing.Point(278, 63);
            this.quanLyBangGia.Name = "quanLyBangGia";
            this.quanLyBangGia.Size = new System.Drawing.Size(1644, 916);
            this.quanLyBangGia.TabIndex = 4;
            // 
            // duLieuDiemDanh
            // 
            this.duLieuDiemDanh.BackColor = System.Drawing.Color.LightCyan;
            this.duLieuDiemDanh.Location = new System.Drawing.Point(278, 63);
            this.duLieuDiemDanh.Name = "duLieuDiemDanh";
            this.duLieuDiemDanh.Size = new System.Drawing.Size(1644, 916);
            this.duLieuDiemDanh.TabIndex = 3;
            // 
            // quanLyNhanVien
            // 
            this.quanLyNhanVien.BackColor = System.Drawing.Color.LightCyan;
            this.quanLyNhanVien.Location = new System.Drawing.Point(278, 63);
            this.quanLyNhanVien.Name = "quanLyNhanVien";
            this.quanLyNhanVien.Size = new System.Drawing.Size(1644, 916);
            this.quanLyNhanVien.TabIndex = 2;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // baoCaoDanhThu
            // 
            this.baoCaoDanhThu.BackColor = System.Drawing.Color.LightCyan;
            this.baoCaoDanhThu.Location = new System.Drawing.Point(278, 63);
            this.baoCaoDanhThu.Margin = new System.Windows.Forms.Padding(4);
            this.baoCaoDanhThu.Name = "baoCaoDanhThu";
            this.baoCaoDanhThu.Size = new System.Drawing.Size(1644, 916);
            this.baoCaoDanhThu.TabIndex = 6;
            // 
            // QuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.quanLyBangGia);
            this.Controls.Add(this.duLieuDiemDanh);
            this.Controls.Add(this.baoCaoDanhThu);
            this.Controls.Add(this.quanLyNhanVien);
            this.Controls.Add(this.khoThuoc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLy";
            this.Text = "Quanli";
            this.Load += new System.EventHandler(this.Quanliload);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnKhoThuoc;
        private System.Windows.Forms.Button btnQuanLyBangGia;
        private System.Windows.Forms.Button btnBaoCaoDanhThu;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnDuLieuDiemDanh;
        private System.Windows.Forms.Button btnQuanLyNhanVien;
        private QuanLyNhanVien quanLyNhanVien;
        private DuLieuDiemDanh duLieuDiemDanh;
        private DatabaseDataSetTableAdapters.ScheduleTableAdapter scheduleTableAdapter1;
        private Pricelist quanLyBangGia;
        private KhoThuoc khoThuoc;
        private DatabaseDataSet databaseDataSet1;
        private BaoCaoDanhThu baoCaoDanhThu;
        //private QuanLyNhanVien quanLyNhanVien;
        //private DuLieuDiemDanh duLieuDiemDanh;
    }
}