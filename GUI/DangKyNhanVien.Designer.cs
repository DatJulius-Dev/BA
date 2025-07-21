using System.Drawing;

namespace QuanLyPhongKham.GUI
{
    partial class DangKyNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKyNhanVien));
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.cbbBranch = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.pnlGender = new System.Windows.Forms.Panel();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPosition = new System.Windows.Forms.ComboBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.tbxSdt = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.btnLogup = new System.Windows.Forms.Button();
            this.pnlContainer.SuspendLayout();
            this.pnlGender.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.pnlContainer.Controls.Add(this.tbxAddress);
            this.pnlContainer.Controls.Add(this.cbbBranch);
            this.pnlContainer.Controls.Add(this.dtpBirthday);
            this.pnlContainer.Controls.Add(this.tbxEmail);
            this.pnlContainer.Controls.Add(this.pnlGender);
            this.pnlContainer.Controls.Add(this.tbxName);
            this.pnlContainer.Controls.Add(this.label5);
            this.pnlContainer.Controls.Add(this.label2);
            this.pnlContainer.Controls.Add(this.label6);
            this.pnlContainer.Controls.Add(this.label3);
            this.pnlContainer.Controls.Add(this.label4);
            this.pnlContainer.Controls.Add(this.label1);
            this.pnlContainer.Controls.Add(this.cbbPosition);
            this.pnlContainer.Controls.Add(this.lblHeader);
            this.pnlContainer.Controls.Add(this.lblPhoneNumber);
            this.pnlContainer.Controls.Add(this.tbxSdt);
            this.pnlContainer.Controls.Add(this.lblPosition);
            this.pnlContainer.Controls.Add(this.btnLogup);
            this.pnlContainer.Location = new System.Drawing.Point(197, 70);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(858, 538);
            this.pnlContainer.TabIndex = 0;
            // 
            // tbxAddress
            // 
            this.tbxAddress.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddress.Location = new System.Drawing.Point(325, 295);
            this.tbxAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxAddress.Multiline = true;
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(446, 39);
            this.tbxAddress.TabIndex = 6;
            // 
            // cbbBranch
            // 
            this.cbbBranch.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbbBranch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbBranch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbBranch.FormattingEnabled = true;
            this.cbbBranch.Location = new System.Drawing.Point(325, 384);
            this.cbbBranch.Name = "cbbBranch";
            this.cbbBranch.Size = new System.Drawing.Size(200, 39);
            this.cbbBranch.TabIndex = 8;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = " ";
            this.dtpBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(325, 252);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(446, 38);
            this.dtpBirthday.TabIndex = 5;
            this.dtpBirthday.ValueChanged += new System.EventHandler(this.dtpBirthday_ValueChanged);
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(325, 157);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxEmail.Multiline = true;
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(446, 39);
            this.tbxEmail.TabIndex = 3;
            // 
            // pnlGender
            // 
            this.pnlGender.BackColor = System.Drawing.Color.Transparent;
            this.pnlGender.Controls.Add(this.rdbMale);
            this.pnlGender.Controls.Add(this.rdbFemale);
            this.pnlGender.Location = new System.Drawing.Point(325, 201);
            this.pnlGender.Name = "pnlGender";
            this.pnlGender.Size = new System.Drawing.Size(446, 45);
            this.pnlGender.TabIndex = 4;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMale.Location = new System.Drawing.Point(5, 7);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(85, 33);
            this.rdbMale.TabIndex = 13;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFemale.Location = new System.Drawing.Point(122, 7);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(65, 33);
            this.rdbFemale.TabIndex = 14;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // tbxName
            // 
            this.tbxName.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(325, 114);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxName.Multiline = true;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(446, 39);
            this.tbxName.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 387);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 36);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chi nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 36);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 36);
            this.label6.TabIndex = 9;
            this.label6.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Chức vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Họ và tên";
            // 
            // cbbPosition
            // 
            this.cbbPosition.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cbbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPosition.FormattingEnabled = true;
            this.cbbPosition.Location = new System.Drawing.Point(325, 339);
            this.cbbPosition.Name = "cbbPosition";
            this.cbbPosition.Size = new System.Drawing.Size(200, 39);
            this.cbbPosition.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(204, 22);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(308, 36);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Đăng ký tài khoản mới";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(26, 74);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(190, 36);
            this.lblPhoneNumber.TabIndex = 1;
            this.lblPhoneNumber.Text = "Số điện thoại";
            // 
            // tbxSdt
            // 
            this.tbxSdt.BackColor = System.Drawing.Color.PaleTurquoise;
            this.tbxSdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSdt.Location = new System.Drawing.Point(325, 71);
            this.tbxSdt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSdt.Multiline = true;
            this.tbxSdt.Name = "tbxSdt";
            this.tbxSdt.Size = new System.Drawing.Size(446, 39);
            this.tbxSdt.TabIndex = 1;
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.Transparent;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(26, 210);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(126, 36);
            this.lblPosition.TabIndex = 3;
            this.lblPosition.Text = "Giới tính";
            // 
            // btnLogup
            // 
            this.btnLogup.BackColor = System.Drawing.SystemColors.Window;
            this.btnLogup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogup.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogup.Location = new System.Drawing.Point(245, 449);
            this.btnLogup.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogup.Name = "btnLogup";
            this.btnLogup.Size = new System.Drawing.Size(244, 54);
            this.btnLogup.TabIndex = 9;
            this.btnLogup.Text = "Đăng ký";
            this.btnLogup.UseVisualStyleBackColor = false;
            this.btnLogup.Click += new System.EventHandler(this.btnLogup_Click);
            // 
            // DangKyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1261, 673);
            this.Controls.Add(this.pnlContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKyNhanVien";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            this.pnlGender.ResumeLayout(false);
            this.pnlGender.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbxSdt;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Button btnLogup;
        private System.Windows.Forms.ComboBox cbbPosition;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Panel pnlGender;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.ComboBox cbbBranch;
    }
}