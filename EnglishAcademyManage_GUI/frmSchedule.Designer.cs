namespace EnglishAcademyManage_GUI
{
    partial class frmSchedule
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
            this.dtWeekSelector = new System.Windows.Forms.DateTimePicker();
            this.dgvSchedules = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtWeekSelector
            // 
            this.dtWeekSelector.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtWeekSelector.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtWeekSelector.Location = new System.Drawing.Point(196, 92);
            this.dtWeekSelector.Name = "dtWeekSelector";
            this.dtWeekSelector.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dtWeekSelector.Size = new System.Drawing.Size(669, 28);
            this.dtWeekSelector.TabIndex = 1;
            this.dtWeekSelector.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.dtWeekSelector.ValueChanged += new System.EventHandler(this.dtWeekSelector_ValueChanged);
            // 
            // dgvSchedules
            // 
            this.dgvSchedules.AllowUserToAddRows = false;
            this.dgvSchedules.AllowUserToDeleteRows = false;
            this.dgvSchedules.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSchedules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSchedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSchedules.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvSchedules.Location = new System.Drawing.Point(29, 178);
            this.dgvSchedules.Name = "dgvSchedules";
            this.dgvSchedules.RowHeadersWidth = 51;
            this.dgvSchedules.RowTemplate.Height = 24;
            this.dgvSchedules.Size = new System.Drawing.Size(1005, 445);
            this.dgvSchedules.TabIndex = 56;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.08015F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.00093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91892F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnPrevious, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtWeekSelector, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnNext, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.57143F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.42857F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1072, 140);
            this.tableLayoutPanel1.TabIndex = 57;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(3, 92);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(142, 43);
            this.btnPrevious.TabIndex = 3;
            this.btnPrevious.Text = "Tuần trước";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(927, 92);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 45);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Tuần sau";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(196, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(669, 89);
            this.lblTitle.TabIndex = 58;
            this.lblTitle.Text = "THỜI KHÓA BIỂU";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1078, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgvSchedules);
            this.Name = "frmSchedule";
            this.Text = "frmSchedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSchedules)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtWeekSelector;
        private System.Windows.Forms.DataGridView dgvSchedules;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label lblTitle;
    }
}