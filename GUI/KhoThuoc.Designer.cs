namespace QuanLyPhongKham.GUI
{
    partial class KhoThuoc
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
            this.lvwMedicine = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEnterMedicine = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwMedicine
            // 
            this.lvwMedicine.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwMedicine.GridLines = true;
            this.lvwMedicine.HideSelection = false;
            this.lvwMedicine.Location = new System.Drawing.Point(3, 65);
            this.lvwMedicine.Name = "lvwMedicine";
            this.lvwMedicine.Size = new System.Drawing.Size(1641, 848);
            this.lvwMedicine.TabIndex = 0;
            this.lvwMedicine.UseCompatibleStateImageBehavior = false;
            this.lvwMedicine.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã thuốc";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên thuốc";
            this.columnHeader1.Width = 500;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Giá";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Tồn kho";
            this.columnHeader3.Width = 200;
            // 
            // btnEnterMedicine
            // 
            this.btnEnterMedicine.BackgroundImage = global::QuanLyPhongKham.Properties.Resources.plus;
            this.btnEnterMedicine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEnterMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnterMedicine.Location = new System.Drawing.Point(1588, 4);
            this.btnEnterMedicine.Name = "btnEnterMedicine";
            this.btnEnterMedicine.Size = new System.Drawing.Size(50, 50);
            this.btnEnterMedicine.TabIndex = 1;
            this.btnEnterMedicine.UseVisualStyleBackColor = true;
            this.btnEnterMedicine.Click += new System.EventHandler(this.btnEnterMedicine_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(160, 4);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(560, 38);
            this.tbxSearch.TabIndex = 3;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(3, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(151, 39);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.tbxSearch);
            this.panel1.Controls.Add(this.btnEnterMedicine);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1641, 56);
            this.panel1.TabIndex = 5;
            // 
            // KhoThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMedicine);
            this.Name = "KhoThuoc";
            this.Size = new System.Drawing.Size(1644, 916);
            this.Load += new System.EventHandler(this.KhoThuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMedicine;
        private System.Windows.Forms.Button btnEnterMedicine;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}
