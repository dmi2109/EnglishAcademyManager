using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace EnglishAcademyManage_GUI
{
    public partial class frmMain : Form
    {
        private readonly EnglishAcademyDbContext _context;

        public frmMain()
        {
            InitializeComponent();
            _context = new EnglishAcademyDbContext();
            LoadGeneralStatisticsChart();
            LoadRegistrationChart();
            LoadPaymentChart();
            
        }

        private void LoadRegistrationChart()
        {
            try
            {
                // Query for the number of registrations by course
                var query = from r in _context.Registrations
                            group r by r.course_id into g
                            select new
                            {
                                CourseId = g.Key,
                                TotalRegistrations = g.Count()
                            };

                // Check if there is any data
                if (!query.Any())
                {
                    MessageBox.Show("No data available for course registrations.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Setup the registrations chart
                chartRegistrations.Series.Clear();
                Series series = new Series("Total Registrations")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Blue 
                };

                foreach (var item in query.ToList())
                {
                    series.Points.AddXY(item.CourseId, item.TotalRegistrations);
                }

                // Add data point labels
                foreach (var point in series.Points)
                {
                    point.Label = point.YValues[0].ToString(); 
                }

                // Thiết lập font cho nhãn
                series.Font = new Font("Arial", 14, FontStyle.Bold); // Điều chỉnh kích thước và kiểu chữ

                chartRegistrations.Series.Add(series);
                chartRegistrations.ChartAreas[0].AxisX.Title = "Course ID";
                chartRegistrations.ChartAreas[0].AxisY.Title = "Total Registrations";
                chartRegistrations.Titles.Clear();
                chartRegistrations.Titles.Add("Statistics of Course Registrations");
                chartRegistrations.ChartAreas[0].AxisX.Interval = 1; 
                chartRegistrations.ChartAreas[0].AxisY.IsStartedFromZero = true; 
                chartRegistrations.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray; 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading registration data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPaymentChart()
        {
            try
            {
                // Query for the total payments by student from the Receipt table
                var query = from r in _context.Receipts
                            group r by r.student_id into g
                            select new
                            {
                                StudentId = g.Key,
                                TotalPayments = g.Sum(x => x.amount) 
                            };

                // Check if there is any data
                if (!query.Any())
                {
                    MessageBox.Show("No data available for payments.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Setup the payments chart
                chartPayments.Series.Clear();
                Series series = new Series("Total Payments")
                {
                    ChartType = SeriesChartType.Column,
                    Color = Color.Green 
                };

                foreach (var item in query.ToList())
                {
                    series.Points.AddXY(item.StudentId, item.TotalPayments);
                }

                // Add data point labels
                foreach (var point in series.Points)
                {
                    point.Label = point.YValues[0].ToString("C");
                }

                // Thiết lập font cho nhãn
                series.Font = new Font("Arial", 14, FontStyle.Bold); // Điều chỉnh kích thước và kiểu chữ

                chartPayments.Series.Add(series);
                chartPayments.ChartAreas[0].AxisX.Title = "Student ID";
                chartPayments.ChartAreas[0].AxisY.Title = "Total Payments";
                chartPayments.Titles.Clear();
                chartPayments.Titles.Add("Statistics of Payments by Students");
                chartPayments.ChartAreas[0].AxisX.Interval = 1; 
                chartPayments.ChartAreas[0].AxisY.IsStartedFromZero = true; 
                chartPayments.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading payment data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadGeneralStatisticsChart()
        {
            try
            {
                // Lấy số liệu thống kê
                int studentCount = _context.Students.Count();
                int teacherCount = _context.Teachers.Count();
                int classCount = _context.Classes.Count();

                // Thiết lập biểu đồ
                chartGeneralStatistics.Series.Clear();
                Series series = new Series("Statistics")
                {
                    ChartType = SeriesChartType.Pie, 
                    Color = Color.Green
                };

                // Thêm dữ liệu vào biểu đồ với nhãn
                series.Points.Add(new DataPoint
                {
                    AxisLabel = "Học viên",
                    YValues = new double[] { studentCount },
                    LegendText = "Học viên",
                    Label = studentCount.ToString() 
                });

                series.Points.Add(new DataPoint
                {
                    AxisLabel = "Giáo viên",
                    YValues = new double[] { teacherCount },
                    LegendText = "Giáo viên",
                    Label = teacherCount.ToString() 
                });

                series.Points.Add(new DataPoint
                {
                    AxisLabel = "Lớp học",
                    YValues = new double[] { classCount },
                    LegendText = "Lớp học",
                    Label = classCount.ToString() 
                });

                // Thiết lập font cho nhãn
                series.Font = new Font("Arial", 14, FontStyle.Bold); // Điều chỉnh kích thước và kiểu chữ

                chartGeneralStatistics.Series.Add(series);
                chartGeneralStatistics.Titles.Clear();
                chartGeneralStatistics.Titles.Add("Statistics of General Academy");
 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi tải biểu đồ thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    }
}
