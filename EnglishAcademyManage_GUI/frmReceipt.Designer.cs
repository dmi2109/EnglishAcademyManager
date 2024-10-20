using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    partial class frmReceipt
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.btnUpdatePaymentStatus = new System.Windows.Forms.Button();
            this.btnDeleteReceipt = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.cmbPaymentStatusFilter = new System.Windows.Forms.ComboBox();
            this.dgvReceipts = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(20, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(410, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 30);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.AutoSize = true;
            this.btnAddReceipt.Location = new System.Drawing.Point(540, 20);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(120, 30);
            this.btnAddReceipt.TabIndex = 3;
            this.btnAddReceipt.Text = "Add Receipt";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnUpdatePaymentStatus
            // 
            this.btnUpdatePaymentStatus.AutoSize = true;
            this.btnUpdatePaymentStatus.Location = new System.Drawing.Point(479, 60);
            this.btnUpdatePaymentStatus.Name = "btnUpdatePaymentStatus";
            this.btnUpdatePaymentStatus.Size = new System.Drawing.Size(181, 30);
            this.btnUpdatePaymentStatus.TabIndex = 4;
            this.btnUpdatePaymentStatus.Text = "UpdatePaymentStatus";
            this.btnUpdatePaymentStatus.UseVisualStyleBackColor = true;
            this.btnUpdatePaymentStatus.Click += new System.EventHandler(this.btnUpdatePaymentStatus_Click);
            // 
            // btnDeleteReceipt
            // 
            this.btnDeleteReceipt.AutoSize = true;
            this.btnDeleteReceipt.Location = new System.Drawing.Point(680, 20);
            this.btnDeleteReceipt.Name = "btnDeleteReceipt";
            this.btnDeleteReceipt.Size = new System.Drawing.Size(125, 30);
            this.btnDeleteReceipt.TabIndex = 5;
            this.btnDeleteReceipt.Text = "Delete Receipt";
            this.btnDeleteReceipt.UseVisualStyleBackColor = true;
            this.btnDeleteReceipt.Click += new System.EventHandler(this.btnDeleteReceipt_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.AutoSize = true;
            this.btnPrintReceipt.Location = new System.Drawing.Point(680, 60);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(114, 30);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "Print Receipt ";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // cmbPaymentStatusFilter
            // 
            this.cmbPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatusFilter.FormattingEnabled = true;
            this.cmbPaymentStatusFilter.Items.AddRange(new object[] {
            "All",
            "Paid",
            "Unpaid"});
            this.cmbPaymentStatusFilter.Location = new System.Drawing.Point(240, 20);
            this.cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            this.cmbPaymentStatusFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbPaymentStatusFilter.TabIndex = 7;
            // 
            // dgvReceipts
            // 
            this.dgvReceipts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipts.Location = new System.Drawing.Point(20, 107);
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.ReadOnly = true;
            this.dgvReceipts.RowHeadersWidth = 62;
            this.dgvReceipts.RowTemplate.Height = 28;
            this.dgvReceipts.Size = new System.Drawing.Size(774, 320);
            this.dgvReceipts.TabIndex = 8;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.dgvReceipts);
            this.Controls.Add(this.cmbPaymentStatusFilter);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnDeleteReceipt);
            this.Controls.Add(this.btnUpdatePaymentStatus);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "frmReceipt";
            this.Text = "Reciept Manager";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvReceipts;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}