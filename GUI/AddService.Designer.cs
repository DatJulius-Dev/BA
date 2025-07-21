namespace QuanLyPhongKham.GUI
{
    partial class AddService
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxUnit = new System.Windows.Forms.TextBox();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxPrice = new System.Windows.Forms.TextBox();
            this.cbbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlQuantity = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            this.pnlQuantity.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxName.Location = new System.Drawing.Point(197, 84);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(481, 38);
            this.tbxName.TabIndex = 0;
            // 
            // tbxUnit
            // 
            this.tbxUnit.Enabled = false;
            this.tbxUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUnit.Location = new System.Drawing.Point(197, 257);
            this.tbxUnit.Name = "tbxUnit";
            this.tbxUnit.Size = new System.Drawing.Size(481, 38);
            this.tbxUnit.TabIndex = 3;
            // 
            // tbxNote
            // 
            this.tbxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNote.Location = new System.Drawing.Point(197, 316);
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.Size = new System.Drawing.Size(481, 38);
            this.tbxNote.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn vị";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 2;
            this.label4.Text = "Giá dịch vụ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ghi chú";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(302, 395);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 44);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(439, 395);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(131, 44);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Làm mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(576, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 44);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxPrice
            // 
            this.tbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPrice.Location = new System.Drawing.Point(197, 203);
            this.tbxPrice.Name = "tbxPrice";
            this.tbxPrice.Size = new System.Drawing.Size(481, 38);
            this.tbxPrice.TabIndex = 2;
            // 
            // cbbType
            // 
            this.cbbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "1.Thuốc",
            "2.Dịch vụ phòng khám"});
            this.cbbType.Location = new System.Drawing.Point(197, 139);
            this.cbbType.Name = "cbbType";
            this.cbbType.Size = new System.Drawing.Size(193, 39);
            this.cbbType.TabIndex = 1;
            this.cbbType.SelectedIndexChanged += new System.EventHandler(this.cbbType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loại";
            // 
            // nudQuantity
            // 
            this.nudQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantity.Location = new System.Drawing.Point(150, 14);
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(120, 38);
            this.nudQuantity.TabIndex = 7;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng";
            // 
            // pnlQuantity
            // 
            this.pnlQuantity.Controls.Add(this.label6);
            this.pnlQuantity.Controls.Add(this.nudQuantity);
            this.pnlQuantity.Location = new System.Drawing.Point(396, 126);
            this.pnlQuantity.Name = "pnlQuantity";
            this.pnlQuantity.Size = new System.Drawing.Size(282, 66);
            this.pnlQuantity.TabIndex = 9;
            this.pnlQuantity.Visible = false;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(302, 373);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(44, 16);
            this.lblError.TabIndex = 10;
            this.lblError.Text = "label7";
            this.lblError.Visible = false;
            // 
            // AddService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 442);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.pnlQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbType);
            this.Controls.Add(this.tbxPrice);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.tbxUnit);
            this.Controls.Add(this.tbxName);
            this.MaximizeBox = false;
            this.Name = "AddService";
            this.Text = "Thêm dịch vụ";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            this.pnlQuantity.ResumeLayout(false);
            this.pnlQuantity.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxUnit;
        private System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxPrice;
        private System.Windows.Forms.ComboBox cbbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlQuantity;
        private System.Windows.Forms.Label lblError;
    }
}