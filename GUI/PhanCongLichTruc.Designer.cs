using System;

namespace QuanLyPhongKham.GUI {
    partial class PhanCongLichTruc {
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
            this.lvwDutySchedule = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.cbbDentist = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbShift = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbAssistant = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwDutySchedule
            // 
            this.lvwDutySchedule.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader3,
            this.columnHeader5});
            this.lvwDutySchedule.GridLines = true;
            this.lvwDutySchedule.HideSelection = false;
            this.lvwDutySchedule.Location = new System.Drawing.Point(6, 81);
            this.lvwDutySchedule.Name = "lvwDutySchedule";
            this.lvwDutySchedule.Size = new System.Drawing.Size(1444, 547);
            this.lvwDutySchedule.TabIndex = 0;
            this.lvwDutySchedule.UseCompatibleStateImageBehavior = false;
            this.lvwDutySchedule.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Phòng";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ca";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Bác sĩ";
            this.columnHeader3.Width = 300;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phụ tá";
            this.columnHeader5.Width = 300;
            // 
            // cbbRoom
            // 
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(222, 47);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(410, 39);
            this.cbbRoom.TabIndex = 2;
            // 
            // cbbDentist
            // 
            this.cbbDentist.FormattingEnabled = true;
            this.cbbDentist.Location = new System.Drawing.Point(858, 47);
            this.cbbDentist.Name = "cbbDentist";
            this.cbbDentist.Size = new System.Drawing.Size(522, 39);
            this.cbbDentist.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(756, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bác sĩ";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Lime;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(1182, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 49);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 32);
            this.label4.TabIndex = 9;
            this.label4.Text = "Ca";
            // 
            // cbbShift
            // 
            this.cbbShift.FormattingEnabled = true;
            this.cbbShift.Location = new System.Drawing.Point(222, 135);
            this.cbbShift.Name = "cbbShift";
            this.cbbShift.Size = new System.Drawing.Size(406, 39);
            this.cbbShift.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(756, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 32);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phụ tá";
            // 
            // cbbAssistant
            // 
            this.cbbAssistant.FormattingEnabled = true;
            this.cbbAssistant.Location = new System.Drawing.Point(858, 135);
            this.cbbAssistant.Name = "cbbAssistant";
            this.cbbAssistant.Size = new System.Drawing.Size(522, 39);
            this.cbbAssistant.TabIndex = 10;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(6, 37);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(579, 38);
            this.dtpDate.TabIndex = 1;
            this.dtpDate.Value = DateTime.Now;
            this.dtpDate.ValueChanged += new System.EventHandler(this.dtpDate_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.lvwDutySchedule);
            this.groupBox1.Controls.Add(this.dtpDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1456, 634);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách lịch trực";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.cbbRoom);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbbDentist);
            this.groupBox2.Controls.Add(this.cbbAssistant);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbShift);
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 643);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1456, 261);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chỉnh sửa lịch trực";
            // 
            // PhanCongLichTruc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PhanCongLichTruc";
            this.Size = new System.Drawing.Size(1462, 907);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwDutySchedule;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.ComboBox cbbDentist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbShift;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbAssistant;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
