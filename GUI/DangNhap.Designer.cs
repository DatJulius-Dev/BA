using System.Drawing;
namespace QuanLyPhongKham.GUI
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.tbxPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.lblForgetPassword = new System.Windows.Forms.LinkLabel();
            this.cbkShowPassword = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxPhoneNumber
            // 
            this.tbxPhoneNumber.BackColor = System.Drawing.Color.LightCyan;
            this.tbxPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPhoneNumber.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tbxPhoneNumber.Location = new System.Drawing.Point(820, 88);
            this.tbxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPhoneNumber.Multiline = true;
            this.tbxPhoneNumber.Name = "tbxPhoneNumber";
            this.tbxPhoneNumber.Size = new System.Drawing.Size(397, 39);
            this.tbxPhoneNumber.TabIndex = 10;
            this.tbxPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPhoneNumber_KeyPress);
            // 
            // tbxPassword
            // 
            this.tbxPassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPassword.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.tbxPassword.Location = new System.Drawing.Point(820, 182);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '●';
            this.tbxPassword.ShortcutsEnabled = false;
            this.tbxPassword.Size = new System.Drawing.Size(397, 39);
            this.tbxPassword.TabIndex = 11;
            this.tbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxPassword_Enter);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDangNhap.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDangNhap.Location = new System.Drawing.Point(892, 328);
            this.btnDangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(265, 59);
            this.btnDangNhap.TabIndex = 12;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblForgetPassword
            // 
            this.lblForgetPassword.AutoSize = true;
            this.lblForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblForgetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblForgetPassword.LinkColor = System.Drawing.Color.Transparent;
            this.lblForgetPassword.Location = new System.Drawing.Point(819, 256);
            this.lblForgetPassword.Name = "lblForgetPassword";
            this.lblForgetPassword.Size = new System.Drawing.Size(215, 18);
            this.lblForgetPassword.TabIndex = 13;
            this.lblForgetPassword.TabStop = true;
            this.lblForgetPassword.Text = "Quên Mật Khẩu ?/Đổi mật khẩu";
            this.lblForgetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblForgetPassword_LinkClicked);
            // 
            // cbkShowPassword
            // 
            this.cbkShowPassword.AutoSize = true;
            this.cbkShowPassword.BackColor = System.Drawing.Color.Transparent;
            this.cbkShowPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbkShowPassword.ForeColor = System.Drawing.Color.Transparent;
            this.cbkShowPassword.Location = new System.Drawing.Point(1073, 252);
            this.cbkShowPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbkShowPassword.Name = "cbkShowPassword";
            this.cbkShowPassword.Size = new System.Drawing.Size(144, 22);
            this.cbkShowPassword.TabIndex = 14;
            this.cbkShowPassword.Text = "Hiển thị mật khẩu";
            this.cbkShowPassword.UseVisualStyleBackColor = false;
            this.cbkShowPassword.CheckedChanged += new System.EventHandler(this.cbkShowPassword_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(814, 145);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 35);
            this.lblPassword.TabIndex = 18;
            this.lblPassword.Text = "Mật khẩu";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 499);
            this.panel2.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(816, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 35);
            this.label1.TabIndex = 22;
            this.label1.Text = "Số điện thoại";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.SteelBlue;
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.panel2);
            this.pnlContainer.Controls.Add(this.lblPassword);
            this.pnlContainer.Controls.Add(this.cbkShowPassword);
            this.pnlContainer.Controls.Add(this.lblForgetPassword);
            this.pnlContainer.Controls.Add(this.btnDangNhap);
            this.pnlContainer.Controls.Add(this.tbxPassword);
            this.pnlContainer.Controls.Add(this.tbxPhoneNumber);
            this.pnlContainer.Font = new System.Drawing.Font("Calibri Light", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.pnlContainer.ForeColor = System.Drawing.Color.Black;
            this.pnlContainer.Location = new System.Drawing.Point(35, 158);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlContainer.Size = new System.Drawing.Size(1267, 493);
            this.pnlContainer.TabIndex = 10;
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1351, 750);
            this.Controls.Add(this.pnlContainer);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "DangNhap";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tbxPhoneNumber;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.LinkLabel lblForgetPassword;
        private System.Windows.Forms.CheckBox cbkShowPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlContainer;
    }
}

