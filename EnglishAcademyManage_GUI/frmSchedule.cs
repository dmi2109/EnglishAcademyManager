using EnglishAcademyManage_BUS;
using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    public partial class frmSchedule : Form
    {
        private readonly ScheduleService scheduleService = new ScheduleService();

        public frmSchedule()
        {
            InitializeComponent();
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.Lavender;
            dgview.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.Lavender;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


        }
        private void LoadWeeklySchedule(DateTime startOfWeek)
        {
            // Khởi tạo DataGridView với các cột tương ứng với các ngày trong tuần
            dgvSchedules.Columns.Clear();
            dgvSchedules.Columns.Add("TimeSlot", "Time Slot");
            dgvSchedules.Columns.Add("Monday", "Monday");
            dgvSchedules.Columns.Add("Tuesday", "Tuesday");
            dgvSchedules.Columns.Add("Wednesday", "Wednesday");
            dgvSchedules.Columns.Add("Thursday", "Thursday");
            dgvSchedules.Columns.Add("Friday", "Friday");
            dgvSchedules.Columns.Add("Saturday", "Saturday");
            dgvSchedules.Columns.Add("Sunday", "Sunday");

            foreach (DataGridViewColumn column in dgvSchedules.Columns)
            {
                column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            dgvSchedules.RowTemplate.Height = 150;
            dgvSchedules.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            // Danh sách các khoảng thời gian (ca học)
            List<string> timeSlots = new List<string>
            {
                "09:00 - 11:00", "10:00 - 12:00", "14:00 - 16:00"
                // Có thể thêm các khoảng thời gian khác
            };

            // Tạo các hàng trong DataGridView cho từng khoảng thời gian
            foreach (var slot in timeSlots)
            {
                dgvSchedules.Rows.Add(slot);
            }

            // Lấy dữ liệu lịch học theo tuần
            var schedules = scheduleService.GetSchedulesByWeek(startOfWeek);

            // Duyệt qua các lịch học và điền vào DataGridView
            foreach (var schedule in schedules)
            {
                int dayOfWeek = (int)schedule.start_time.Value.DayOfWeek;
                dayOfWeek = dayOfWeek == 0 ? 7 : dayOfWeek; // Chuyển đổi về index của DataGridView

                int rowIndex = -1;
                string timeRange = $"{schedule.start_time.Value:HH:mm} - {schedule.end_time.Value:HH:mm}";
                for (int i = 0; i < timeSlots.Count; i++)
                {
                    if (timeSlots[i] == timeRange)
                    {
                        rowIndex = i;
                        break;
                    }
                }

                // Điền dữ liệu vào đúng ô
                if (rowIndex != -1 && dayOfWeek != -1)
                {
                    var cell = dgvSchedules.Rows[rowIndex].Cells[dayOfWeek];
                    cell.Value = $"{schedule.class_id}\n({schedule.room})";

                    // Đổi màu ô có thông tin
                    cell.Style.BackColor = Color.Lavender; // Đổi màu nền thành màu xanh dương nhạt
                    cell.Style.ForeColor = Color.Black; 
                }

            }
        }


        private void frmSchedule_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = dtWeekSelector.Value; // dtpSelectedDate là một DateTimePicker
            DateTime startOfWeek = selectedDate.StartOfWeek(DayOfWeek.Monday);
            LoadWeeklySchedule(startOfWeek);
            setGridViewStyle(dgvSchedules);
            currentWeekStart = selectedDate.StartOfWeek(DayOfWeek.Monday);
        }

        private DateTime currentWeekStart;

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(-7);
            dtWeekSelector.Value = currentWeekStart;
            LoadWeeklySchedule(currentWeekStart);
            dgvSchedules.ClearSelection();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            currentWeekStart = currentWeekStart.AddDays(7);
            dtWeekSelector.Value = currentWeekStart;
            LoadWeeklySchedule(currentWeekStart);
            dgvSchedules.ClearSelection();
        }

        private void dtWeekSelector_ValueChanged(object sender, EventArgs e)
        {
            currentWeekStart = dtWeekSelector.Value.StartOfWeek(DayOfWeek.Monday);
            LoadWeeklySchedule(currentWeekStart);
            dgvSchedules.ClearSelection();
        }
    }
}