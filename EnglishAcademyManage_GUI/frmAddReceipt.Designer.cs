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

        private System.Windows.Forms.TextBox txtReceiptID;         // TextBox for entering Receipt ID
        private System.Windows.Forms.TextBox txtStudentID;         // TextBox for entering Student ID
        private System.Windows.Forms.TextBox txtAmount;            // TextBox for entering Amount
        private System.Windows.Forms.DateTimePicker dtpPaymentDate; // DateTimePicker for Payment Date
        private System.Windows.Forms.TextBox txtDescription;       // TextBox for entering Description
        private System.Windows.Forms.ComboBox cmbPaymentStatus;    // ComboBox for selecting Payment Status
        private System.Windows.Forms.ComboBox cmbEmployee;         // ComboBox for selecting Employee
        private System.Windows.Forms.Button btnCancel;             // Cancel button
        private System.Windows.Forms.Button btnAdd;                // Add button
        private System.Windows.Forms.Label lblReceiptID;           // Label for Receipt ID
        private System.Windows.Forms.Label lblStudentID;           // Label for Student ID
        private System.Windows.Forms.Label lblAmount;              // Label for Amount
        private System.Windows.Forms.Label lblPaymentDate;         // Label for Payment Date
        private System.Windows.Forms.Label lblDescription;         // Label for Description
        private System.Windows.Forms.Label lblPaymentStatus;       // Label for Payment Status
        private System.Windows.Forms.Label lblEmployee;            // Label for Employee

        private void InitializeComponent()
        {
            this.txtReceiptID = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cmbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblReceiptID = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblPaymentDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPaymentStatus = new System.Windows.Forms.Label();
            this.lblEmployee = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // txtReceiptID
            // 
            this.txtReceiptID.Location = new System.Drawing.Point(30, 40);
            this.txtReceiptID.Name = "txtReceiptID";
            this.txtReceiptID.Size = new System.Drawing.Size(400, 26);
            this.txtReceiptID.TabIndex = 0;

            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(30, 100);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(400, 26);
            this.txtStudentID.TabIndex = 1;

            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(30, 160);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(400, 26);
            this.txtAmount.TabIndex = 2;

            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.Location = new System.Drawing.Point(30, 220);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(400, 26);
            this.dtpPaymentDate.TabIndex = 3;

            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(30, 280);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(400, 60);
            this.txtDescription.TabIndex = 4;

            // 
            // cmbPaymentStatus
            // 
            this.cmbPaymentStatus.FormattingEnabled = true;
            this.cmbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cmbPaymentStatus.Location = new System.Drawing.Point(30, 360);
            this.cmbPaymentStatus.Name = "cmbPaymentStatus";
            this.cmbPaymentStatus.Size = new System.Drawing.Size(400, 28);
            this.cmbPaymentStatus.TabIndex = 5;

            // 
            // cmbEmployee
            // 
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(30, 420);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(400, 28);
            this.cmbEmployee.TabIndex = 6;

            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(220, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(100, 480);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Receipt";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // 
            // lblReceiptID
            // 
            this.lblReceiptID.AutoSize = true;
            this.lblReceiptID.Location = new System.Drawing.Point(30, 20);
            this.lblReceiptID.Name = "lblReceiptID";
            this.lblReceiptID.Size = new System.Drawing.Size(85, 20);
            this.lblReceiptID.TabIndex = 9;
            this.lblReceiptID.Text = "Receipt ID:";

            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(30, 80);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(91, 20);
            this.lblStudentID.TabIndex = 10;
            this.lblStudentID.Text = "Student ID:";

            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(30, 140);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(69, 20);
            this.lblAmount.TabIndex = 11;
            this.lblAmount.Text = "Amount:";

            // 
            // lblPaymentDate
            // 
            this.lblPaymentDate.AutoSize = true;
            this.lblPaymentDate.Location = new System.Drawing.Point(30, 200);
            this.lblPaymentDate.Name = "lblPaymentDate";
            this.lblPaymentDate.Size = new System.Drawing.Size(114, 20);
            this.lblPaymentDate.TabIndex = 12;
            this.lblPaymentDate.Text = "Payment Date:";

            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 260);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(93, 20);
            this.lblDescription.TabIndex = 13;
            this.lblDescription.Text = "Description:";

            // 
            // lblPaymentStatus
            // 
            this.lblPaymentStatus.AutoSize = true;
            this.lblPaymentStatus.Location = new System.Drawing.Point(30, 340);
            this.lblPaymentStatus.Name = "lblPaymentStatus";
            this.lblPaymentStatus.Size = new System.Drawing.Size(126, 20);
            this.lblPaymentStatus.TabIndex = 14;
            this.lblPaymentStatus.Text = "Payment Status:";

            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Location = new System.Drawing.Point(30, 400);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(84, 20);
            this.lblEmployee.TabIndex = 15;
            this.lblEmployee.Text = "Employee:";

            // 
            // frmAddReceipt
            // 
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(480, 540);
            this.Controls.Add(this.txtReceiptID);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dtpPaymentDate);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbPaymentStatus);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblReceiptID);
            this.Controls.Add(this.lblStudentID);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblPaymentDate);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblPaymentStatus);
            this.Controls.Add(this.lblEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
