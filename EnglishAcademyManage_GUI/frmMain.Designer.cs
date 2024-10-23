namespace EnglishAcademyManage_GUI
{
    partial class frmMain
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

        private System.Windows.Forms.DataVisualization.Charting.Chart chartGeneralStatistics; // Biểu đồ thống kê tổng quan
        private System.Windows.Forms.TabPage tabPageGeneralStatistics; // Tab cho thống kê tổng quan
        private System.Windows.Forms.TabPage tabPagePayments;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPayments;
        private System.Windows.Forms.TabPage tabPageCourseRegistrations;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartRegistrations;
        private System.Windows.Forms.TabControl tabControl;

        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageGeneralStatistics = new System.Windows.Forms.TabPage();
            this.chartGeneralStatistics = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPagePayments = new System.Windows.Forms.TabPage();
            this.chartPayments = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPageCourseRegistrations = new System.Windows.Forms.TabPage();
            this.chartRegistrations = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl.SuspendLayout();
            this.tabPageGeneralStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralStatistics)).BeginInit();
            this.tabPagePayments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartPayments)).BeginInit();
            this.tabPageCourseRegistrations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartRegistrations)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageGeneralStatistics);
            this.tabControl.Controls.Add(this.tabPagePayments);
            this.tabControl.Controls.Add(this.tabPageCourseRegistrations);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1746, 959);
            this.tabControl.TabIndex = 0;
            // 
            // tabPageGeneralStatistics
            // 
            this.tabPageGeneralStatistics.Controls.Add(this.chartGeneralStatistics);
            this.tabPageGeneralStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageGeneralStatistics.Location = new System.Drawing.Point(4, 38);
            this.tabPageGeneralStatistics.Name = "tabPageGeneralStatistics";
            this.tabPageGeneralStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGeneralStatistics.Size = new System.Drawing.Size(1738, 917);
            this.tabPageGeneralStatistics.TabIndex = 0;
            this.tabPageGeneralStatistics.Text = "Statistics Overview";
            this.tabPageGeneralStatistics.UseVisualStyleBackColor = true;
            // 
            // chartGeneralStatistics
            // 
            this.chartGeneralStatistics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea4.Name = "ChartAreaGeneral";
            this.chartGeneralStatistics.ChartAreas.Add(chartArea4);
            legend4.Name = "LegendGeneral";
            this.chartGeneralStatistics.Legends.Add(legend4);
            this.chartGeneralStatistics.Location = new System.Drawing.Point(20, 20); // Adjusted position
            this.chartGeneralStatistics.Name = "chartGeneralStatistics";
            series4.ChartArea = "ChartAreaGeneral";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "LegendGeneral";
            series4.Name = "SeriesGeneral";
            series4.Points.Add(dataPoint2);
            this.chartGeneralStatistics.Series.Add(series4);
            this.chartGeneralStatistics.Size = new System.Drawing.Size(1698, 870); // Adjusted size
            this.chartGeneralStatistics.TabIndex = 0;
            this.chartGeneralStatistics.Text = "General Statistics Chart";
            // 
            // tabPagePayments
            // 
            this.tabPagePayments.Controls.Add(this.chartPayments);
            this.tabPagePayments.Location = new System.Drawing.Point(4, 38);
            this.tabPagePayments.Name = "tabPagePayments";
            this.tabPagePayments.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePayments.Size = new System.Drawing.Size(1738, 917);
            this.tabPagePayments.TabIndex = 1;
            this.tabPagePayments.Text = "Statistics by Payments";
            this.tabPagePayments.UseVisualStyleBackColor = true;
            // 
            // chartPayments
            // 
            this.chartPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartAreaPayments";
            this.chartPayments.ChartAreas.Add(chartArea5);
            legend5.Name = "LegendPayments";
            this.chartPayments.Legends.Add(legend5);
            this.chartPayments.Location = new System.Drawing.Point(20, 20); // Adjusted position
            this.chartPayments.Name = "chartPayments";
            series5.ChartArea = "ChartAreaPayments";
            series5.Legend = "LegendPayments";
            this.chartPayments.Series.Add(series5);
            this.chartPayments.Size = new System.Drawing.Size(1698, 870); // Adjusted size
            this.chartPayments.TabIndex = 0;
            this.chartPayments.Text = "Payments Chart";
            // 
            // tabPageCourseRegistrations
            // 
            this.tabPageCourseRegistrations.Controls.Add(this.chartRegistrations);
            this.tabPageCourseRegistrations.Location = new System.Drawing.Point(4, 38);
            this.tabPageCourseRegistrations.Name = "tabPageCourseRegistrations";
            this.tabPageCourseRegistrations.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCourseRegistrations.Size = new System.Drawing.Size(1738, 917);
            this.tabPageCourseRegistrations.TabIndex = 2;
            this.tabPageCourseRegistrations.Text = "Statistics by Course Registrations";
            this.tabPageCourseRegistrations.UseVisualStyleBackColor = true;
            // 
            // chartRegistrations
            // 
            this.chartRegistrations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea6.Name = "ChartAreaRegistrations";
            this.chartRegistrations.ChartAreas.Add(chartArea6);
            legend6.Name = "LegendRegistrations";
            this.chartRegistrations.Legends.Add(legend6);
            this.chartRegistrations.Location = new System.Drawing.Point(20, 20); // Adjusted position
            this.chartRegistrations.Name = "chartRegistrations";
            series6.ChartArea = "ChartAreaRegistrations";
            series6.Legend = "LegendRegistrations";
            this.chartRegistrations.Series.Add(series6);
            this.chartRegistrations.Size = new System.Drawing.Size(1698, 870); // Adjusted size
            this.chartRegistrations.TabIndex = 0;
            this.chartRegistrations.Text = "Registrations Chart";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1780, 983); // Adjusted form size
            this.Controls.Add(this.tabControl);
            this.Name = "frmMain";
            this.Text = "English Center Management";
            this.tabControl.ResumeLayout(false);
            this.tabPageGeneralStatistics.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartGeneralStatistics)).EndInit();
            this.tabPagePayments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartPayments)).EndInit();
            this.tabPageCourseRegistrations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartRegistrations)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}
