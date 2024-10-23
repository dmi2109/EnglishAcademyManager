using System;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    partial class frmAttendance
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.cmbClasses = new System.Windows.Forms.ComboBox();
            this.btnTakeAttendance = new System.Windows.Forms.Button();
            this.btnSaveAttendance = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dgvAttendance = new System.Windows.Forms.DataGridView();
            this.dateTimePickerAttendance = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbClasses
            // 
            this.cmbClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClasses.FormattingEnabled = true;
            this.cmbClasses.Location = new System.Drawing.Point(22, 25);
            this.cmbClasses.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbClasses.Name = "cmbClasses";
            this.cmbClasses.Size = new System.Drawing.Size(226, 28);
            this.cmbClasses.TabIndex = 0;
            this.cmbClasses.SelectedIndexChanged += new System.EventHandler(this.cmbClasses_SelectedIndexChanged);
            // 
            // btnTakeAttendance
            // 
            this.btnTakeAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnTakeAttendance.Location = new System.Drawing.Point(22, 483);
            this.btnTakeAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTakeAttendance.Name = "btnTakeAttendance";
            this.btnTakeAttendance.Size = new System.Drawing.Size(167, 46);
            this.btnTakeAttendance.TabIndex = 2;
            this.btnTakeAttendance.Text = "Take Attendance";
            this.btnTakeAttendance.UseVisualStyleBackColor = true;
            this.btnTakeAttendance.Click += new System.EventHandler(this.btnTakeAttendance_Click);
            // 
            // btnSaveAttendance
            // 
            this.btnSaveAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveAttendance.Location = new System.Drawing.Point(215, 483);
            this.btnSaveAttendance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveAttendance.Name = "btnSaveAttendance";
            this.btnSaveAttendance.Size = new System.Drawing.Size(170, 46);
            this.btnSaveAttendance.TabIndex = 3;
            this.btnSaveAttendance.Text = "Save Attendance";
            this.btnSaveAttendance.UseVisualStyleBackColor = true;
            this.btnSaveAttendance.Click += new System.EventHandler(this.btnSaveAttendance_Click_1);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefresh.Location = new System.Drawing.Point(429, 483);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(133, 46);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvAttendance
            // 
            this.dgvAttendance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAttendance.Location = new System.Drawing.Point(22, 83);
            this.dgvAttendance.Name = "dgvAttendance";
            this.dgvAttendance.RowHeadersWidth = 62;
            this.dgvAttendance.RowTemplate.Height = 28;
            this.dgvAttendance.Size = new System.Drawing.Size(849, 378);
            this.dgvAttendance.TabIndex = 5;
            // 
            // dateTimePickerAttendance
            // 
            this.dateTimePickerAttendance.Location = new System.Drawing.Point(312, 27);
            this.dateTimePickerAttendance.Name = "dateTimePickerAttendance";
            this.dateTimePickerAttendance.Size = new System.Drawing.Size(401, 26);
            this.dateTimePickerAttendance.TabIndex = 6;
            this.dateTimePickerAttendance.ValueChanged += new System.EventHandler(this.dateTimePickerAttendance_ValueChanged_1);
            // 
            // frmAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.dateTimePickerAttendance);
            this.Controls.Add(this.dgvAttendance);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnSaveAttendance);
            this.Controls.Add(this.btnTakeAttendance);
            this.Controls.Add(this.cmbClasses);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAttendance";
            this.Text = "Attendance Management";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ComboBox cmbClasses;
        private System.Windows.Forms.Button btnTakeAttendance;
        private System.Windows.Forms.Button btnSaveAttendance; 
        private System.Windows.Forms.Button btnRefresh;
        private DataGridView dgvAttendance;
        private DateTimePicker dateTimePickerAttendance;
    }
}
