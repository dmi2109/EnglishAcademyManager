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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvReceipts = new Siticone.Desktop.UI.WinForms.SiticoneDataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAddReceipt = new System.Windows.Forms.Button();
            this.btnUpdatePaymentStatus = new System.Windows.Forms.Button();
            this.btnDeleteReceipt = new System.Windows.Forms.Button();
            this.btnPrintReceipt = new System.Windows.Forms.Button();
            this.cmbPaymentStatusFilter = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceipts
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvReceipts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceipts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvReceipts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceipts.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvReceipts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipts.Location = new System.Drawing.Point(20, 100);
            this.dgvReceipts.Name = "dgvReceipts";
            this.dgvReceipts.RowHeadersVisible = false;
            this.dgvReceipts.RowHeadersWidth = 62;
            this.dgvReceipts.Size = new System.Drawing.Size(760, 300);
            this.dgvReceipts.TabIndex = 0;
            this.dgvReceipts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceipts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvReceipts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvReceipts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvReceipts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvReceipts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceipts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvReceipts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReceipts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceipts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvReceipts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceipts.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvReceipts.ThemeStyle.ReadOnly = false;
            this.dgvReceipts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvReceipts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReceipts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvReceipts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvReceipts.ThemeStyle.RowsStyle.Height = 22;
            this.dgvReceipts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvReceipts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnSearch.Location = new System.Drawing.Point(410, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAddReceipt
            // 
            this.btnAddReceipt.Location = new System.Drawing.Point(540, 20);
            this.btnAddReceipt.Name = "btnAddReceipt";
            this.btnAddReceipt.Size = new System.Drawing.Size(120, 23);
            this.btnAddReceipt.TabIndex = 3;
            this.btnAddReceipt.Text = "Thêm hóa đơn";
            this.btnAddReceipt.UseVisualStyleBackColor = true;
            this.btnAddReceipt.Click += new System.EventHandler(this.btnAddReceipt_Click);
            // 
            // btnUpdatePaymentStatus
            // 
            this.btnUpdatePaymentStatus.Location = new System.Drawing.Point(540, 60);
            this.btnUpdatePaymentStatus.Name = "btnUpdatePaymentStatus";
            this.btnUpdatePaymentStatus.Size = new System.Drawing.Size(120, 23);
            this.btnUpdatePaymentStatus.TabIndex = 4;
            this.btnUpdatePaymentStatus.Text = "Cập nhật thanh toán";
            this.btnUpdatePaymentStatus.UseVisualStyleBackColor = true;
            this.btnUpdatePaymentStatus.Click += new System.EventHandler(this.btnUpdatePaymentStatus_Click);
            // 
            // btnDeleteReceipt
            // 
            this.btnDeleteReceipt.Location = new System.Drawing.Point(680, 20);
            this.btnDeleteReceipt.Name = "btnDeleteReceipt";
            this.btnDeleteReceipt.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteReceipt.TabIndex = 5;
            this.btnDeleteReceipt.Text = "Xóa hóa đơn";
            this.btnDeleteReceipt.UseVisualStyleBackColor = true;
            this.btnDeleteReceipt.Click += new System.EventHandler(this.btnDeleteReceipt_Click);
            // 
            // btnPrintReceipt
            // 
            this.btnPrintReceipt.Location = new System.Drawing.Point(680, 60);
            this.btnPrintReceipt.Name = "btnPrintReceipt";
            this.btnPrintReceipt.Size = new System.Drawing.Size(100, 23);
            this.btnPrintReceipt.TabIndex = 6;
            this.btnPrintReceipt.Text = "In hóa đơn";
            this.btnPrintReceipt.UseVisualStyleBackColor = true;
            this.btnPrintReceipt.Click += new System.EventHandler(this.btnPrintReceipt_Click);
            // 
            // cmbPaymentStatusFilter
            // 
            this.cmbPaymentStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentStatusFilter.FormattingEnabled = true;
            this.cmbPaymentStatusFilter.Items.AddRange(new object[] {
            "Tất cả",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cmbPaymentStatusFilter.Location = new System.Drawing.Point(240, 20);
            this.cmbPaymentStatusFilter.Name = "cmbPaymentStatusFilter";
            this.cmbPaymentStatusFilter.Size = new System.Drawing.Size(150, 28);
            this.cmbPaymentStatusFilter.TabIndex = 7;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 467);
            this.Controls.Add(this.cmbPaymentStatusFilter);
            this.Controls.Add(this.btnPrintReceipt);
            this.Controls.Add(this.btnDeleteReceipt);
            this.Controls.Add(this.btnUpdatePaymentStatus);
            this.Controls.Add(this.btnAddReceipt);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvReceipts);
            this.BackColor = System.Drawing.Color.Lavender;
            this.Name = "frmReceipt";
            this.Text = "Quản lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmReceipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceipts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Siticone.Desktop.UI.WinForms.SiticoneDataGridView dgvReceipts;
    }
}