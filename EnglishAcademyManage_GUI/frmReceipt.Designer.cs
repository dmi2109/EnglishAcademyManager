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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSearch.Location = new System.Drawing.Point(3, 3);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(157, 26);
            this.txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSearch.AutoSize = true;
            this.btnSearch.Location = new System.Drawing.Point(329, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(129, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddReceipt.AutoSize = true;
            this.btnAddReceipt.Location = new System.Drawing.Point(464, 3);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(188, 34);
            this.btnAddReceipt.TabIndex = 3;
            this.btnAddReceipt.Text = "Add Receipt";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnUpdatePaymentStatus
            // 
            this.btnUpdatePaymentStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdatePaymentStatus.AutoSize = true;
            this.btnUpdatePaymentStatus.Location = new System.Drawing.Point(464, 43);
            this.btnUpdatePaymentStatus.Name = "btnUpdatePaymentStatus";
            this.btnUpdatePaymentStatus.Size = new System.Drawing.Size(188, 34);
            this.btnUpdatePaymentStatus.TabIndex = 4;
            this.btnUpdatePaymentStatus.Text = "UpdatePaymentStatus";
            this.btnUpdatePaymentStatus.UseVisualStyleBackColor = true;
            this.btnUpdatePaymentStatus.Click += new System.EventHandler(this.btnUpdatePaymentStatus_Click);
            // 
            // btnDeleteReceipt
            // 
            this.btnDeleteReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteReceipt.AutoSize = true;
            this.btnDeleteReceipt.Location = new System.Drawing.Point(658, 3);
            this.btnDeleteReceipt.Name = "btnDeleteReceipt";
            this.btnDeleteReceipt.Size = new System.Drawing.Size(156, 34);
            this.btnDeleteReceipt.TabIndex = 5;
            this.btnDeleteReceipt.Text = "Delete Receipt";
            this.btnDeleteReceipt.UseVisualStyleBackColor = true;
            this.btnDeleteReceipt.Click += new System.EventHandler(this.btnDeleteReceipt_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPrintReceipt.AutoSize = true;
            this.btnPrintReceipt.Location = new System.Drawing.Point(658, 43);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(156, 34);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "Print Receipt ";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // cmbPaymentStatusFilter
            // 
            this.cmbPaymentStatusFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatusFilter.FormattingEnabled = true;
            this.cmbPaymentStatusFilter.Items.AddRange(new object[] {
            "All",
            "Completed",
            "Pending"});
            this.cmbPaymentStatusFilter.Location = new System.Drawing.Point(166, 3);
            this.cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            this.cmbPaymentStatusFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbPaymentStatusFilter.TabIndex = 7;
            // 
            // dgvReceipts
            // 
            this.dgvReceipts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.52387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.74541F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.70624F));
            this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbPaymentStatusFilter, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintReceipt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearch, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnUpdatePaymentStatus, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnDeleteReceipt, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddReceipt, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(817, 80);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvReceipts);
            this.Name = "frmReceipt";
            this.Text = "Reciept Manager";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgvReceipts;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private TableLayoutPanel tableLayoutPanel1;
    }
}