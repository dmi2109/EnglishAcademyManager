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
    public partial class frmStudents : Form
    {
        private readonly StudentService studentService = new StudentService();
        public frmStudents()
        {
            InitializeComponent();
        }
        private void BindGrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();
            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.student_id;
                dgvStudent.Rows[index].Cells[1].Value = item.last_name;
                dgvStudent.Rows[index].Cells[2].Value = item.first_name;
                dgvStudent.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvStudent.Rows[index].Cells[3].Value = item.day_of_birth;
                dgvStudent.Rows[index].Cells[4].Value = item.phone;
                dgvStudent.Rows[index].Cells[5].Value = item.email;

                string status = item.Status.HasValue ? (item.Status.Value ? "Active" : "Inactive") : "Unknown";
                dgvStudent.Rows[index].Cells[6].Value = status;

                // Tự động dãn cách theo nội dung của tất cả các dòng
                dgvStudent.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            txtStudentID.Clear();
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
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
            {
                err.SetError(txtStudentID, "Vui lòng nhập mã học viên.");
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
                err.SetError(txtLastName, "Họ và tên đệm học viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
                valid = false;
            }

            // Kiểm tra tên
            if (txtFirstName.Text.Length < 2 || txtFirstName.Text.Length > 100 ||
                !txtFirstName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtFirstName, "Tên học viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
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

        private void frmStudents_Load(object sender, EventArgs e)
        {
            setGridViewStyle(dgvStudent);
            var listStudents = studentService.GetAll();
            BindGrid(listStudents);
        }


        private void UpdateStudentList()
        {
            try
            {
                var listStudent = studentService.GetAll(); // Get students
                BindGrid(listStudent);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            err.Clear();
            if (!ValidateInput()) return;

            // Check if the student already exists
            bool exists = dgvStudent.Rows.Cast<DataGridViewRow>()
                                          .Any(r => r.Cells[0].Value.ToString() == txtStudentID.Text);

            if (!exists)
            {
                try
                {
                    // Create new student object
                    Student newStudent = new Student
                    {
                        student_id = txtStudentID.Text,
                        last_name = txtLastName.Text,
                        first_name = txtFirstName.Text,
                        day_of_birth = dtDateOfBirth.Value,
                        phone = txtPhone.Text,
                        email = txtEmail.Text
                    };

                    // Add new student to the database
                    studentService.AddStudent(newStudent);
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
                MessageBox.Show("Mã số học viên đã tồn tại.");
            }
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                var student = studentService.GetStudentById(txtStudentID.Text); // Get student by ID
                if (student != null)
                {
                    // Update student info
                    student.last_name = txtLastName.Text;
                    student.first_name = txtFirstName.Text;
                    student.day_of_birth = dtDateOfBirth.Value;
                    student.phone = txtPhone.Text;
                    student.email = txtEmail.Text;


                    studentService.UpdateStudent(student); // Update student in database

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
            txtStudentID.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentID.Text))
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
                    var student = studentService.GetStudentById(txtStudentID.Text);
                    if (student != null)
                    {
                        var message = studentService.DeleteStudent(txtStudentID.Text); // Xóa mềm
                        MessageBox.Show(message);
                        UpdateStudentList(); // Cập nhật danh sách học viên sau khi xóa
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

            txtStudentID.Enabled = true;
            btnAdd.Enabled = true;
            ResetInputFields();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
                txtStudentID.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString();
                txtFirstName.Text = row.Cells[2].Value.ToString();
                dtDateOfBirth.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                txtPhone.Text = row.Cells[4].Value.ToString();
                txtEmail.Text = row.Cells[5].Value.ToString();
            }
            txtStudentID.Enabled = false;
            btnAdd.Enabled = false;
        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên sinh viên cần tìm.");
                return;
            }
            string searchValue = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                bool found = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[2].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[6].Value.ToString().ToLower().Contains(searchValue);

                row.Visible = found;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvStudent.Rows)
            {
                row.Visible = true;
            }
        }
    }
}
