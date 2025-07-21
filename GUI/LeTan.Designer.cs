namespace QuanLyPhongKham.GUI
{
    partial class LeTan
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
            this.panel9 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnPhanCongLichTruc = new System.Windows.Forms.Button();
            this.btnQuanLyHoSoBenhNhan = new System.Windows.Forms.Button();
            this.thanhToan = new QuanLyPhongKham.GUI.ThanhToan();
            this.quanLyHoSoBenhNhan = new QuanLyPhongKham.GUI.QuanLiHoSoBenhhan();
            this.phanCongLichTruc = new QuanLyPhongKham.GUI.PhanCongLichTruc();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.label13);
            this.panel9.Controls.Add(this.panel8);
            this.panel9.Location = new System.Drawing.Point(3, 1);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1923, 47);
            this.panel9.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label13.Location = new System.Drawing.Point(9, 7);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 24);
            this.label13.TabIndex = 2;
            this.label13.Text = "RHM";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.N9_NiceNight__1_;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(1872, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(48, 47);
            this.panel8.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Silver;
            this.panel11.Controls.Add(this.btnLogout);
            this.panel11.Controls.Add(this.btnPay);
            this.panel11.Controls.Add(this.btnPhanCongLichTruc);
            this.panel11.Controls.Add(this.btnQuanLyHoSoBenhNhan);
            this.panel11.Location = new System.Drawing.Point(18, 66);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(424, 907);
            this.panel11.TabIndex = 7;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Crimson;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.Location = new System.Drawing.Point(3, 856);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnLogout.Size = new System.Drawing.Size(145, 49);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPay.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.Location = new System.Drawing.Point(2, 145);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(419, 63);
            this.btnPay.TabIndex = 15;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnPhanCongLichTruc
            // 
            this.btnPhanCongLichTruc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPhanCongLichTruc.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPhanCongLichTruc.Location = new System.Drawing.Point(2, 76);
            this.btnPhanCongLichTruc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhanCongLichTruc.Name = "btnPhanCongLichTruc";
            this.btnPhanCongLichTruc.Size = new System.Drawing.Size(419, 65);
            this.btnPhanCongLichTruc.TabIndex = 15;
            this.btnPhanCongLichTruc.Text = "Quản lí lịch làm việc bác sĩ";
            this.btnPhanCongLichTruc.UseVisualStyleBackColor = false;
            this.btnPhanCongLichTruc.Click += new System.EventHandler(this.btnPhanCongLichTruc_Click);
            // 
            // btnQuanLyHoSoBenhNhan
            // 
            this.btnQuanLyHoSoBenhNhan.BackColor = System.Drawing.Color.Lime;
            this.btnQuanLyHoSoBenhNhan.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnQuanLyHoSoBenhNhan.Location = new System.Drawing.Point(3, 7);
            this.btnQuanLyHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQuanLyHoSoBenhNhan.Name = "btnQuanLyHoSoBenhNhan";
            this.btnQuanLyHoSoBenhNhan.Size = new System.Drawing.Size(419, 65);
            this.btnQuanLyHoSoBenhNhan.TabIndex = 15;
            this.btnQuanLyHoSoBenhNhan.Text = "Quản lý hồ sơ bệnh nhân";
            this.btnQuanLyHoSoBenhNhan.UseVisualStyleBackColor = false;
            this.btnQuanLyHoSoBenhNhan.Click += new System.EventHandler(this.btnQuanLyHoSoBenhNhan_Click);
            // 
            // thanhToan
            // 
            this.thanhToan.Location = new System.Drawing.Point(448, 66);
            this.thanhToan.Name = "thanhToan";
            this.thanhToan.Size = new System.Drawing.Size(1462, 907);
            this.thanhToan.TabIndex = 9;
            // 
            // quanLyHoSoBenhNhan
            // 
            this.quanLyHoSoBenhNhan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.quanLyHoSoBenhNhan.Location = new System.Drawing.Point(448, 66);
            this.quanLyHoSoBenhNhan.Margin = new System.Windows.Forms.Padding(5);
            this.quanLyHoSoBenhNhan.Name = "quanLyHoSoBenhNhan";
            this.quanLyHoSoBenhNhan.Size = new System.Drawing.Size(1462, 907);
            this.quanLyHoSoBenhNhan.TabIndex = 8;
            this.quanLyHoSoBenhNhan.Load += new System.EventHandler(this.quanLiHosobenhnhan_Load);
            // 
            // phanCongLichTruc
            // 
            this.phanCongLichTruc.Location = new System.Drawing.Point(448, 66);
            this.phanCongLichTruc.Name = "phanCongLichTruc";
            this.phanCongLichTruc.Size = new System.Drawing.Size(1462, 907);
            this.phanCongLichTruc.TabIndex = 10;
            // 
            // LeTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(1924, 984);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.thanhToan);
            this.Controls.Add(this.quanLyHoSoBenhNhan);
            this.Controls.Add(this.phanCongLichTruc);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LeTan";
            this.Text = "Letan";
            this.Load += new System.EventHandler(this.Letan_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnQuanLyHoSoBenhNhan;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnPhanCongLichTruc;
        private QuanLiHoSoBenhhan quanLyHoSoBenhNhan;
        private ThanhToan thanhToan;
        private PhanCongLichTruc phanCongLichTruc;
    }
}