using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    public partial class frmCourse : Form
    {
        private EnglishAcademyDbContext _context;
        private int pageNumber = 1;
        private int pageSize = 10;
        private List<Course> _deletedCourses = new List<Course>();


        public frmCourse()
        {
            InitializeComponent();
            _context = new EnglishAcademyDbContext();
            LoadCourses();
        }

        private void LoadCourses()
        {
            try
            {
                var courses = _context.Courses
                                .OrderBy(c => c.course_id) 
                                .Skip((pageNumber - 1) * pageSize)
                                .Take(pageSize)
                                .Select(c => new
                                {
                                    c.course_id,
                                    c.course_name,
                                    c.level,
                                    c.fee
                                })
                                .ToList();

                dgvCourses.DataSource = courses;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tải dữ liệu: " + ex.Message);
            }
        }



        //private void LoadLevels()
        //{
        //    using (var context = new EnglishAcademyDbContext()) 
        //    {
        //        var levels = context.levels.Select(l => l.LevelName).ToList(); 
        //        cmbLevel.DataSource = levels; 
        //    }
        //}

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text) || string.IsNullOrWhiteSpace(txtCourseName.Text) ||
                string.IsNullOrWhiteSpace(cmbLevel.Text) || string.IsNullOrWhiteSpace(txtFee.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var context = new EnglishAcademyDbContext()) 
            {
                var courseId = txtCourseID.Text;
                var course = context.Courses.SingleOrDefault(c => c.course_id == courseId);

                if (course != null)
                {
                    course.course_name = txtCourseName.Text;
                    course.level = cmbLevel.SelectedItem.ToString();
                    course.fee = decimal.Parse(txtFee.Text);

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCourses(); 
                }
                else
                {
                    MessageBox.Show("Khóa học không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text))
            {
                MessageBox.Show("Vui lòng chọn khóa học để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var courseId = txtCourseID.Text;
            var course = _context.Courses.SingleOrDefault(c => c.course_id == courseId);

            if (course != null)
            {
                // Gọi hàm AddToDeletedCourses để lưu khóa học bị xóa vào danh sách tạm
                AddToDeletedCourses(course);

                _context.Courses.Remove(course);
                _context.SaveChanges();
                MessageBox.Show("Xóa khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCourses(); // Tải lại danh sách khóa học

                // Hiển thị thông báo hỏi có muốn hoàn tác hành động xóa không
                if (MessageBox.Show("Bạn có muốn hoàn tác việc xóa này?", "Hoàn tác xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UndoDelete();
                }
            }
            else
            {
                MessageBox.Show("Khóa học không tồn tại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void UndoDelete()
        {
            if (_deletedCourses.Any())
            {
                // Lấy khóa học cuối cùng bị xóa ra khỏi danh sách tạm
                var lastDeletedCourse = _deletedCourses.Last();

                // Thêm lại khóa học vào cơ sở dữ liệu
                _context.Courses.Add(lastDeletedCourse);
                _context.SaveChanges();

                // Xóa khóa học khỏi danh sách tạm
                _deletedCourses.Remove(lastDeletedCourse);

                MessageBox.Show("Khóa học đã được hoàn tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Tải lại danh sách khóa học
                LoadCourses();
            }
            else
            {
                MessageBox.Show("Không có khóa học nào để hoàn tác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddToDeletedCourses(Course course)
        {
            _deletedCourses.Add(course);
            if (_deletedCourses.Count > 10) 
            {
                _deletedCourses.RemoveAt(0);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCourseID.Text) || string.IsNullOrWhiteSpace(txtCourseName.Text) ||
                string.IsNullOrWhiteSpace(cmbLevel.Text) || string.IsNullOrWhiteSpace(txtFee.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin khóa học!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newCourse = new Course
                {
                    course_id = txtCourseID.Text,
                    course_name = txtCourseName.Text,
                    level = cmbLevel.SelectedItem.ToString(),
                    fee = decimal.Parse(txtFee.Text)
                };

                _context.Courses.Add(newCourse);
                _context.SaveChanges();

                MessageBox.Show("Thêm khóa học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadCourses();
                dgvCourses.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm khóa học: " + ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchKeyword = txtSearch.Text.Trim();
            var selectedLevel = cmbLevelSearch.SelectedItem?.ToString();

            try
            {
                var searchResults = _context.Courses
                                            .Where(c => (string.IsNullOrEmpty(searchKeyword) || c.course_name.Contains(searchKeyword) || c.course_id.Contains(searchKeyword))
                                                        && (selectedLevel == "All" || c.level == selectedLevel)) 
                                            .Select(c => new
                                            {
                                                c.course_id,
                                                c.course_name,
                                                c.level,
                                                c.fee
                                            })
                                            .ToList();

                if (searchResults.Any())
                {
                    dgvCourses.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khóa học nào phù hợp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvCourses.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvCourses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvCourses.Rows[e.RowIndex];

                txtCourseID.Text = row.Cells["course_id"].Value.ToString();
                txtCourseName.Text = row.Cells["course_name"].Value.ToString();
                cmbLevel.SelectedItem = row.Cells["level"].Value.ToString();
                txtFee.Text = row.Cells["fee"].Value.ToString();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                LoadCourses();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageNumber++;
            LoadCourses();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            try
            {
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                var workbook = excelApp.Workbooks.Add();
                var worksheet = workbook.Sheets[1];

                // Header
                worksheet.Cells[1, 1] = "Mã khóa học";
                worksheet.Cells[1, 2] = "Tên khóa học";
                worksheet.Cells[1, 3] = "Cấp độ";
                worksheet.Cells[1, 4] = "Học phí";

                // Dữ liệu
                for (int i = 0; i < dgvCourses.Rows.Count; i++)
                {
                    worksheet.Cells[i + 2, 1] = dgvCourses.Rows[i].Cells["course_id"].Value;
                    worksheet.Cells[i + 2, 2] = dgvCourses.Rows[i].Cells["course_name"].Value;
                    worksheet.Cells[i + 2, 3] = dgvCourses.Rows[i].Cells["level"].Value;
                    worksheet.Cells[i + 2, 4] = dgvCourses.Rows[i].Cells["fee"].Value;
                }

                workbook.SaveAs("DanhSachKhoaHoc.xlsx");
                workbook.Close();
                excelApp.Quit();

                MessageBox.Show("Xuất dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi xuất dữ liệu: " + ex.Message);
            }
        }
    }

}
