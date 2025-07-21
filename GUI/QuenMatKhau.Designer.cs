namespace QuanLyPhongKham.GUI {
    partial class quenMatKhau {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxNewPass = new System.Windows.Forms.TextBox();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbxOTP = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnShowNewPassword = new System.Windows.Forms.Button();
            this.btnShowConfirmPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxID
            // 
            this.tbxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxID.Location = new System.Drawing.Point(281, 3);
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(472, 38);
            this.tbxID.TabIndex = 0;
            this.tbxID.TextChanged += new System.EventHandler(this.tbxID_TextChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(281, 47);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(472, 38);
            this.tbxEmail.TabIndex = 1;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email đã đăng kí";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xác nhận mật khẩu";
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmPass.Location = new System.Drawing.Point(281, 135);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.Size = new System.Drawing.Size(436, 38);
            this.tbxConfirmPass.TabIndex = 15;
            this.tbxConfirmPass.UseSystemPasswordChar = true;
            this.tbxConfirmPass.TextChanged += new System.EventHandler(this.tbxConfirmPass_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 32);
            this.label4.TabIndex = 14;
            this.label4.Text = "Nhập mật khẩu mới";
            // 
            // tbxNewPass
            // 
            this.tbxNewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewPass.Location = new System.Drawing.Point(281, 91);
            this.tbxNewPass.Name = "tbxNewPass";
            this.tbxNewPass.Size = new System.Drawing.Size(436, 38);
            this.tbxNewPass.TabIndex = 13;
            this.tbxNewPass.UseSystemPasswordChar = true;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(281, 262);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(203, 39);
            this.btnChangePass.TabIndex = 18;
            this.btnChangePass.Text = "Đổi mật khẩu";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.btnShowConfirmPassword);
            this.panel1.Controls.Add(this.btnShowNewPassword);
            this.panel1.Controls.Add(this.tbxOTP);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.tbxID);
            this.panel1.Controls.Add(this.btnChangePass);
            this.panel1.Controls.Add(this.tbxEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbxConfirmPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbxNewPass);
            this.panel1.Location = new System.Drawing.Point(62, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 323);
            this.panel1.TabIndex = 19;
            // 
            // tbxOTP
            // 
            this.tbxOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOTP.Location = new System.Drawing.Point(281, 179);
            this.tbxOTP.Name = "tbxOTP";
            this.tbxOTP.Size = new System.Drawing.Size(225, 38);
            this.tbxOTP.TabIndex = 22;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(278, 220);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(180, 16);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "Vui lòng điền đầy đủ thông tin";
            this.lblError.VisibleChanged += new System.EventHandler(this.lblError_VisibleChanged);
            // 
            // btnSend
            // 
            this.btnSend.AutoSize = true;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.ForeColor = System.Drawing.Color.Black;
            this.btnSend.Location = new System.Drawing.Point(512, 179);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(105, 35);
            this.btnSend.TabIndex = 20;
            this.btnSend.Text = "Send OTP";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSendOTP_Click);
            // 
            // btnShowNewPassword
            // 
            this.btnShowNewPassword.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.visible;
            this.btnShowNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowNewPassword.Location = new System.Drawing.Point(715, 91);
            this.btnShowNewPassword.Name = "btnShowNewPassword";
            this.btnShowNewPassword.Size = new System.Drawing.Size(38, 38);
            this.btnShowNewPassword.TabIndex = 23;
            this.btnShowNewPassword.UseVisualStyleBackColor = true;
            this.btnShowNewPassword.Click += new System.EventHandler(this.btnShowNewPassword_Click);
            // 
            // btnShowConfirmPassword
            // 
            this.btnShowConfirmPassword.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.visible;
            this.btnShowConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnShowConfirmPassword.Location = new System.Drawing.Point(715, 135);
            this.btnShowConfirmPassword.Name = "btnShowConfirmPassword";
            this.btnShowConfirmPassword.Size = new System.Drawing.Size(38, 38);
            this.btnShowConfirmPassword.TabIndex = 24;
            this.btnShowConfirmPassword.UseVisualStyleBackColor = true;
            this.btnShowConfirmPassword.Click += new System.EventHandler(this.btnShowConfirmPassword_Click);
            // 
            // quenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 374);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "quenMatKhau";
            this.Text = "QuenMatKhau";
            this.Load += new System.EventHandler(this.QuenMatKhau_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbxConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxNewPass;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox tbxOTP;
        private System.Windows.Forms.Button btnShowNewPassword;
        private System.Windows.Forms.Button btnShowConfirmPassword;
    }
}