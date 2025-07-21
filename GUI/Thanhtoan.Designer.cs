namespace QuanLyPhongKham.GUI {
    partial class ThanhToan {
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
            this.lvwBillInfor = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbxBillID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTotalFee = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.databaseDataSet1 = new QuanLyPhongKham.DatabaseDataSet();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwBillInfor
            // 
            this.lvwBillInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvwBillInfor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwBillInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwBillInfor.GridLines = true;
            this.lvwBillInfor.HideSelection = false;
            this.lvwBillInfor.Location = new System.Drawing.Point(3, 53);
            this.lvwBillInfor.Name = "lvwBillInfor";
            this.lvwBillInfor.Size = new System.Drawing.Size(1450, 789);
            this.lvwBillInfor.TabIndex = 0;
            this.lvwBillInfor.UseCompatibleStateImageBehavior = false;
            this.lvwBillInfor.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên dịch vụ";
            this.columnHeader1.Width = 700;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tổng tiền";
            this.columnHeader3.Width = 400;
            // 
            // tbxBillID
            // 
            this.tbxBillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBillID.Location = new System.Drawing.Point(212, 9);
            this.tbxBillID.Name = "tbxBillID";
            this.tbxBillID.Size = new System.Drawing.Size(1019, 38);
            this.tbxBillID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hóa đơn";
            // 
            // btnTotalFee
            // 
            this.btnTotalFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTotalFee.BackColor = System.Drawing.Color.LightCyan;
            this.btnTotalFee.Enabled = false;
            this.btnTotalFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTotalFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalFee.Location = new System.Drawing.Point(380, 8);
            this.btnTotalFee.Name = "btnTotalFee";
            this.btnTotalFee.Size = new System.Drawing.Size(871, 39);
            this.btnTotalFee.TabIndex = 3;
            this.btnTotalFee.Text = "0";
            this.btnTotalFee.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(325, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số tiền cần phải trả";
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPay.BackColor = System.Drawing.Color.Lime;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.Location = new System.Drawing.Point(1257, 8);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(193, 39);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.Lime;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1257, 9);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(196, 39);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.tbxBillID);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.lvwBillInfor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 845);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btnPay);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnTotalFee);
            this.panel2.Location = new System.Drawing.Point(3, 854);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1453, 50);
            this.panel2.TabIndex = 7;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ThanhToan";
            this.Size = new System.Drawing.Size(1462, 907);
            this.Load += new System.EventHandler(this.ThanhToan_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwBillInfor;
        private System.Windows.Forms.TextBox tbxBillID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnTotalFee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DatabaseDataSet databaseDataSet1;
    }
}
