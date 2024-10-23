namespace EnglishAcademyManage_GUI
{
    partial class frmClasses
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblClassID = new System.Windows.Forms.Label();
            this.txtClassID = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblCourse = new System.Windows.Forms.Label();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.lblTeacher = new System.Windows.Forms.Label();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.clnStudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.err = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.90352F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.9833F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.82747F));
            this.tableLayoutPanel1.Controls.Add(this.lblClassID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClassID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblClassName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtClassName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStartDate, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtStartDate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtEndDate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEndDate, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblCourse, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbCourse, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTeacher, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbTeacher, 3, 2);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 72);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1078, 116);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // lblClassID
            // 
            this.lblClassID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassID.AutoSize = true;
            this.lblClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClassID.Location = new System.Drawing.Point(4, 0);
            this.lblClassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassID.Name = "lblClassID";
            this.lblClassID.Size = new System.Drawing.Size(184, 38);
            this.lblClassID.TabIndex = 8;
            this.lblClassID.Text = "Mã Lớp Học";
            // 
            // txtClassID
            // 
            this.txtClassID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtClassID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtClassID.Location = new System.Drawing.Point(196, 4);
            this.txtClassID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassID.Name = "txtClassID";
            this.txtClassID.Size = new System.Drawing.Size(325, 28);
            this.txtClassID.TabIndex = 0;
            // 
            // lblClassName
            // 
            this.lblClassName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClassName.AutoSize = true;
            this.lblClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClassName.Location = new System.Drawing.Point(529, 0);
            this.lblClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(145, 38);
            this.lblClassName.TabIndex = 6;
            this.lblClassName.Text = "Tên Lớp";
            // 
            // txtClassName
            // 
            this.txtClassName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtClassName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClassName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtClassName.Location = new System.Drawing.Point(682, 4);
            this.txtClassName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(390, 28);
            this.txtClassName.TabIndex = 1;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStartDate.Location = new System.Drawing.Point(4, 38);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(184, 38);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Ngày Bắt Đầu";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStartDate.Location = new System.Drawing.Point(196, 42);
            this.dtStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(325, 27);
            this.dtStartDate.TabIndex = 15;
            // 
            // dtEndDate
            // 
            this.dtEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dtEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEndDate.Location = new System.Drawing.Point(682, 42);
            this.dtEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtEndDate.Name = "dtEndDate";
            this.dtEndDate.Size = new System.Drawing.Size(390, 27);
            this.dtEndDate.TabIndex = 16;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEndDate.Location = new System.Drawing.Point(529, 38);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(145, 38);
            this.lblEndDate.TabIndex = 17;
            this.lblEndDate.Text = "Ngày Kết Thúc";
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCourse.Location = new System.Drawing.Point(4, 76);
            this.lblCourse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(184, 40);
            this.lblCourse.TabIndex = 18;
            this.lblCourse.Text = "Khóa Học";
            // 
            // cmbCourse
            // 
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Location = new System.Drawing.Point(195, 79);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(327, 30);
            this.cmbCourse.TabIndex = 19;
            // 
            // lblTeacher
            // 
            this.lblTeacher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTeacher.AutoSize = true;
            this.lblTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTeacher.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTeacher.Location = new System.Drawing.Point(529, 76);
            this.lblTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTeacher.Name = "lblTeacher";
            this.lblTeacher.Size = new System.Drawing.Size(145, 40);
            this.lblTeacher.TabIndex = 20;
            this.lblTeacher.Text = "Giáo Viên";
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Location = new System.Drawing.Point(681, 79);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(327, 30);
            this.cmbTeacher.TabIndex = 21;
            this.cmbTeacher.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cmbTeacher_Format);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(957, 205);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 30);
            this.btnSearch.TabIndex = 54;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvClass
            // 
            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnStudentID,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5});
            this.dgvClass.GridColor = System.Drawing.Color.AliceBlue;
            this.dgvClass.Location = new System.Drawing.Point(50, 259);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.RowHeadersWidth = 51;
            this.dgvClass.RowTemplate.Height = 24;
            this.dgvClass.Size = new System.Drawing.Size(1005, 332);
            this.dgvClass.TabIndex = 55;
            this.dgvClass.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellContentClick);
            // 
            // clnStudentID
            // 
            this.clnStudentID.FillWeight = 50F;
            this.clnStudentID.HeaderText = "Mã Lớp Học";
            this.clnStudentID.MinimumWidth = 9;
            this.clnStudentID.Name = "clnStudentID";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 50F;
            this.Column2.HeaderText = "Tên Lớp";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Khóa Học";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Ngày Bắt Đầu";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 50F;
            this.Column4.HeaderText = "Ngày Kết Thúc";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column7
            // 
            this.Column7.FillWeight = 50F;
            this.Column7.HeaderText = "Giáo Viên";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.FillWeight = 40F;
            this.Column5.HeaderText = "Trạng Thái";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(726, 611);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 31);
            this.btnAdd.TabIndex = 50;
            this.btnAdd.TabStop = false;
            this.btnAdd.Text = "Thêm ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSearch.Location = new System.Drawing.Point(736, 207);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(206, 28);
            this.txtSearch.TabIndex = 53;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(867, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 31);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.TabStop = false;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(977, 611);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(78, 30);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // err
            // 
            this.err.ContainerControl = this;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1078, 66);
            this.lblTitle.TabIndex = 60;
            this.lblTitle.Text = "THÔNG TIN LỚP HỌC";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmClasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1078, 651);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvClass);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmClasses";
            this.Text = "frmClasses";
            this.Load += new System.EventHandler(this.frmClasses_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblClassID;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.TextBox txtClassID;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvClass;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.DateTimePicker dtEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ErrorProvider err;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.Label lblTeacher;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblTitle;
    }
}