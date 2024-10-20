using EnglishAcademyManage_BUS;
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
    public partial class frmClasses : Form
    {

        private readonly TeacherService teacherService = new TeacherService();
        private readonly CourseService courseService = new CourseService();
        private readonly ClassService classService = new ClassService();
        public frmClasses()
        {
            InitializeComponent();
        }
        private void FillCourseCombobox(List<Course> listCourses)
        {
            listCourses.Insert(0, new Course());
            this.cmbCourse.DataSource = listCourses ;
            this.cmbCourse.DisplayMember = "course_name";
            this.cmbCourse.ValueMember = "course_id";
        }
        private void FillTeacherCombobox(List<Teacher> listTeachers)
        {
            listTeachers.Insert(0, new Teacher());
            this.cmbTeacher.DataSource = listTeachers;
            this.cmbTeacher.ValueMember = "teacher_id";
            this.cmbTeacher.Format += new ListControlConvertEventHandler(cmbTeacher_Format);
        }
        private void cmbTeacher_Format(object sender, ListControlConvertEventArgs e)
        {
            if (e.ListItem is Teacher teacher)
            {
                e.Value = $"{teacher.last_name} {teacher.first_name}";
            }
        }
        private void BindGrid(List<Class> listclass)
        {
            dgvClass.Rows.Clear();
            foreach (var item in listclass)
            {
                int index = dgvClass.Rows.Add();
                dgvClass.Rows[index].Cells[0].Value = item.class_id;
                dgvClass.Rows[index].Cells[1].Value = item.class_name;
                if (item.Course != null)
                    dgvClass.Rows[index].Cells[2].Value = item.Course.course_name;
                dgvClass.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClass.Rows[index].Cells[3].Value = item.start_date;
                dgvClass.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvClass.Rows[index].Cells[4].Value = item.end_date;
                if (item.Teacher != null)
                    dgvClass.Rows[index].Cells[5].Value = item.Teacher.last_name + " " + item.Teacher.first_name;
                string status = item.Status.HasValue ? (item.Status.Value ? "Active" : "Inactive") : "Unknown";
                dgvClass.Rows[index].Cells[6].Value = status;
                // Tự động dãn cách theo nội dung của tất cả các dòng
                dgvClass.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            }
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
        private void ResetInputFields()
        {
            txtClassID.Clear();
            txtClassName.Clear();
            cmbCourse.SelectedIndex = -1;
            cmbTeacher.SelectedIndex = -1;  
        }
        private bool ValidateInput()
        {
            bool valid = true;
            err.Clear(); // Xóa các lỗi cũ

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtClassID.Text))
            {
                err.SetError(txtClassID, "Vui lòng nhập mã học viên.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                err.SetError(txtClassName, "Vui lòng nhập họ và tên đệm.");
                valid = false;
            }
            
            return valid;
        }
        private void UpdateClassList()
        {
            try
            {
                var listCourse = courseService.GetAll();
                var listClass = classService.GetAll();
                var listTeacher = teacherService.GetAll();
                BindGrid(listClass);
                FillCourseCombobox(listCourse);
                FillTeacherCombobox(listTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvClass);
            var listCourse = courseService.GetAll();
            var listClass = classService.GetAll();
            var listTeacher = teacherService.GetAll();
            BindGrid(listClass);
            FillCourseCombobox(listCourse);
            FillTeacherCombobox(listTeacher);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            bool exists = dgvClass.Rows.Cast<DataGridViewRow>()
                                          .Any(r => r.Cells[0].Value.ToString() == txtClassID.Text);

            if (!exists)
            {
                try
                {
                    Class newClass = new Class
                    {
                        class_id = txtClassID.Text,
                        course_id = cmbCourse.SelectedValue.ToString(),
                        teacher_id = cmbTeacher.SelectedValue.ToString(),
                        class_name = txtClassName.Text,
                        start_date = dtStartDate.Value,
                        end_date = dtEndDate.Value,
                        };

                    classService.AddClass(newClass);
                    UpdateClassList();

                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã lớp học đã tồn tại.");
            }
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                var classes = classService.GetClassById(txtClassID.Text); // Get student by ID
                if (classes != null)
                {
                    // Update student info
                    classes.course_id = cmbCourse.SelectedValue.ToString();
                    classes.teacher_id = cmbTeacher.SelectedValue.ToString();
                    classes.class_name = txtClassName.Text;
                    classes.start_date = dtStartDate.Value;
                    classes.end_date = dtEndDate.Value;


                    classService.UpdateClass(classes); // Update student in database

                    UpdateClassList();

                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Sinh viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetInputFields();
            txtClassID.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void dgvClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClass.Rows[e.RowIndex];
                txtClassID.Text = row.Cells[0].Value.ToString();
                txtClassName.Text = row.Cells[1].Value.ToString();
                cmbCourse.Text = row.Cells[2].Value.ToString();
                dtStartDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                dtEndDate.Value = DateTime.Parse(row.Cells[4].Value.ToString());
                cmbTeacher.Text = row.Cells[5].Value.ToString();
            }
            txtClassID.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtClassID.Text))
            {
                MessageBox.Show("Vui lòng chọn học viên cần xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa học viên này không?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var classes = classService.GetClassById(txtClassID.Text);
                    if (classes != null)
                    {
                        var message = classService.DeleteClass(txtClassID.Text); // Xóa mềm
                        MessageBox.Show(message);
                        UpdateClassList(); // Cập nhật danh sách học viên sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Học viên không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            txtClassID.Enabled = true;
            btnAdd.Enabled = true;
            ResetInputFields();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                row.Visible = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên sinh viên cần tìm.");
                return;
            }
            string searchValue = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvClass.Rows)
            {
                bool found = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[1].Value.ToString().ToLower().Contains(searchValue);
                            

                row.Visible = found;
            }
        }
    }
}
