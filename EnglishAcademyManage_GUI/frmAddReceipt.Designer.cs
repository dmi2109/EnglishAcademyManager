using System;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    partial class frmAddReceipt
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

        #region Windows Form Designer generated code

        private System.Windows.Forms.TextBox txtStudentID;        // TextBox nhập ID sinh viên
        private System.Windows.Forms.TextBox txtAmount;            // TextBox nhập số tiền
        private System.Windows.Forms.DateTimePicker dtpPaymentDate; // DateTimePicker chọn ngày thanh toán
        private System.Windows.Forms.TextBox txtDescription;       // TextBox nhập mô tả
        private System.Windows.Forms.ComboBox cmbPaymentStatus;    // ComboBox chọn trạng thái thanh toán
        private System.Windows.Forms.Button btnCancel;             // Nút hủy
        private System.Windows.Forms.Button btnAdd;                // Nút thêm biên lai
        private System.Windows.Forms.Label lblStudentID;           // Nhãn cho TextBox ID sinh viên
        private System.Windows.Forms.Label lblAmount;              // Nhãn cho TextBox số tiền
        private System.Windows.Forms.Label lblPaymentDate;         // Nhãn cho DateTimePicker
        private System.Windows.Forms.Label lblDescription;         // Nhãn cho TextBox mô tả
        private System.Windows.Forms.Label lblPaymentStatus;       // Nhãn cho ComboBox trạng thái thanh toán

        private void InitializeComponent()
        {
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentID
            // 
            this.txtStudentID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStudentID.Location = new System.Drawing.Point(20, 40);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(300, 26);
            this.txtStudentID.TabIndex = 0;
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(20, 100);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(300, 26);
            this.txtAmount.TabIndex = 1;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(20, 160);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(300, 26);
            this.dtpPaymentDate.TabIndex = 2;
            // 
            // txtDescription
            // 
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Location = new System.Drawing.Point(20, 220);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(300, 60);
            this.txtDescription.TabIndex = 3;
            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(20, 300);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(300, 28);
            this.cmbPaymentStatus.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(150, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(20, 340);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(20, 20);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 20);
            this.lblStudentID.TabIndex = 7;
            this.lblStudentID.Text = "Student ID:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(20, 80);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 8;
            this.lblAmount.Text = "Amount:";
            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(20, 140);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(114, 20);
            this.lblPaymentDate.TabIndex = 9;
            this.lblPaymentDate.Text = "Payment Date:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(20, 200);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 10;
            this.lblDescription.Text = "Description:";
            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(20, 280);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(126, 20);
            this.lblPaymentStatus.TabIndex = 11;
            this.lblPaymentStatus.Text = "Payment Status:";
            // 
            // frmAddReceipt
            // 
            this.ClientSize = new System.Drawing.Size(340, 400);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtStudentID);
            this.BackColor = System.Drawing.Color.Lavender;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmAddReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
