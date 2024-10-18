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
    public partial class frmTeachers : Form
    {
        private readonly TeacherService teacherService = new TeacherService();
        public frmTeachers()
        {
            InitializeComponent();
        }
        private void BindGrid(List<Teacher> listTeacher)
        {
            dgvTeacher.Rows.Clear();
            foreach (var item in listTeacher)
            {
                int index = dgvTeacher.Rows.Add();
                dgvTeacher.Rows[index].Cells[0].Value = item.teacher_id;
                dgvTeacher.Rows[index].Cells[1].Value = item.last_name;
                dgvTeacher.Rows[index].Cells[2].Value = item.first_name;
                dgvTeacher.Rows[index].Cells[3].Value = item.phone;
                dgvTeacher.Rows[index].Cells[4].Value = item.email;

                string status = item.Status.HasValue ? (item.Status.Value ? "Active" : "Inactive") : "Unknown";
                dgvTeacher.Rows[index].Cells[5].Value = status;
                // Tự động dãn cách theo nội dung của tất cả các dòng
                dgvTeacher.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            txtTeacherID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private bool ValidateInput()
        {
            bool valid = true;
            err.Clear(); // Xóa các lỗi cũ

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtTeacherID.Text))
            {
                err.SetError(txtTeacherID, "Vui lòng nhập mã giáo viên.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                err.SetError(txtLastName, "Vui lòng nhập họ và tên đệm.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                err.SetError(txtFirstName, "Vui lòng nhập tên.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                err.SetError(txtPhone, "Vui lòng nhập số điện thoại.");
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                err.SetError(txtEmail, "Vui lòng nhập email.");
                valid = false;
            }

            // Kiểm tra số điện thoại (độ dài phải là 10 ký tự và chỉ chứa số)
            if (txtPhone.Text.Length != 10 || !txtPhone.Text.All(char.IsDigit))
            {
                err.SetError(txtPhone, "Số điện thoại không hợp lệ. Số điện thoại phải có 10 chữ số.");
                valid = false;
            }

            // Kiểm tra họ và tên đệm
            if (txtLastName.Text.Length < 2 || txtLastName.Text.Length > 100 ||
                !txtLastName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtLastName, "Họ và tên đệm giáo viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
                valid = false;
            }

            // Kiểm tra tên
            if (txtFirstName.Text.Length < 2 || txtFirstName.Text.Length > 100 ||
                !txtFirstName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtFirstName, "Tên giáo viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
                valid = false;
            }

            // Kiểm tra định dạng email hợp lệ
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtEmail.Text, emailPattern))
            {
                err.SetError(txtEmail, "Email không hợp lệ.");
                valid = false;
            }

            return valid;
        }


        private void UpdateStudentList()
        {
            try
            {
                var listTeacher = teacherService.GetAll(); // Get students
                BindGrid(listTeacher);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvTeacher);
            var listTeacher = teacherService.GetAll();
            BindGrid(listTeacher);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvTeacher.Rows)
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

            foreach (DataGridViewRow row in dgvTeacher.Rows)
            {
                bool found = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[2].Value.ToString().ToLower().Contains(searchValue);

                row.Visible = found;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            bool exists = dgvTeacher.Rows.Cast<DataGridViewRow>()
                                          .Any(r => r.Cells[0].Value.ToString() == txtTeacherID.Text);

            if (!exists)
            {
                try
                {
                    Teacher newTeacher = new Teacher
                    {
                        teacher_id = txtTeacherID.Text,
                        last_name = txtLastName.Text,
                        first_name = txtFirstName.Text,
                        phone = txtPhone.Text,
                        email = txtEmail.Text
                    };

                    // Add new student to the database
                    teacherService.AddTeacher(newTeacher);
                    UpdateStudentList();

                    MessageBox.Show("Thêm mới dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Mã số giáo viên đã tồn tại.");
            }
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                var teacher = teacherService.GetTeacherById(txtTeacherID.Text); // Get student by ID
                if (teacher != null)
                {
                    // Update student info
                    teacher.last_name = txtLastName.Text;
                    teacher.first_name = txtFirstName.Text;
                    teacher.phone = txtPhone.Text;
                    teacher.email = txtEmail.Text;


                    teacherService.UpdateTeacher(teacher); // Update student in database

                    UpdateStudentList();

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
            txtTeacherID.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTeacherID.Text))
            {
                MessageBox.Show("Vui lòng chọn giáo viên cần xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa giáo viên này không?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var teacher = teacherService.GetTeacherById(txtTeacherID.Text);
                    if (teacher != null)
                    {
                        var message = teacherService.DeleteTeacher(txtTeacherID.Text); // Xóa mềm
                        MessageBox.Show(message);
                        UpdateStudentList(); // Cập nhật danh sách giáo viên sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("giáo viên không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            txtTeacherID.Enabled = true;
            btnAdd.Enabled = true;
            ResetInputFields();
        }

        private void dgvTeacher_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTeacher.Rows[e.RowIndex];
                txtTeacherID.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString();
                txtFirstName.Text = row.Cells[2].Value.ToString();
                txtPhone.Text = row.Cells[3].Value.ToString();
                txtEmail.Text = row.Cells[4].Value.ToString();
            }
            txtTeacherID.Enabled = false;
            btnAdd.Enabled = false;
        }
    }
}
