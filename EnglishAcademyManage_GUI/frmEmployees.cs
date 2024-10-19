using EnglishAcademyManage_BUS;
using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    public partial class frmEmployees : Form
    {
        public frmEmployees()
        {
            InitializeComponent();
        }
        private readonly EmployeeService employeeService = new EmployeeService();
        
        private void BindGrid(List<Employee> listEmployees)
        {
            dgvEmployee.Rows.Clear();
            foreach (var item in listEmployees)
            {
                int index = dgvEmployee.Rows.Add();
                dgvEmployee.Rows[index].Cells[0].Value = item.employee_id;
                dgvEmployee.Rows[index].Cells[1].Value = item.last_name;
                dgvEmployee.Rows[index].Cells[2].Value = item.first_name;
                dgvEmployee.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvEmployee.Rows[index].Cells[3].Value = item.hire_date;
                dgvEmployee.Rows[index].Cells[4].Value = item.position;
                dgvEmployee.Rows[index].Cells[5].Value = item.phone;
                dgvEmployee.Rows[index].Cells[6].Value = item.email;
                dgvEmployee.Rows[index].Cells[7].Value = item.salary;
                string status = item.Status.HasValue ? (item.Status.Value ? "Active" : "Inactive") : "Unknown";
                dgvEmployee.Rows[index].Cells[8].Value = status;

                // Tự động dãn cách theo nội dung của tất cả các dòng
                dgvEmployee.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

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
            txtEmloyeeID.Clear();
            txtLastName.Clear();
            txtFirstName.Clear();
            txtSalary.Clear();
            cmbPosition.SelectedIndex = -1;
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private bool ValidateInput()
        {
            bool valid = true;
            err.Clear(); // Xóa các lỗi cũ

            // Kiểm tra các trường bắt buộc
            if (string.IsNullOrWhiteSpace(txtEmloyeeID.Text))
            {
                err.SetError(txtEmloyeeID, "Vui lòng nhập mã nhân viên.");
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
            if (string.IsNullOrWhiteSpace(txtSalary.Text))
            {
                err.SetError(txtSalary, "Vui lòng nhập lương.");
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
                err.SetError(txtLastName, "Họ và tên đệm nhân viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
                valid = false;
            }

            //Kiểm tra lương
            if (!decimal.TryParse(txtSalary.Text, out decimal Salary) || Salary < 0 )
            {
                err.SetError(txtSalary, "Lương không hợp lệ. Vui lòng nhập chỉ chữ số");
                valid = false;
            }
            // Kiểm tra tên
            if (txtFirstName.Text.Length < 2 || txtFirstName.Text.Length > 100 ||
                !txtFirstName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                err.SetError(txtFirstName, "Tên nhân viên không hợp lệ. Vui lòng nhập chỉ chữ cái.");
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


        private void UpdateEmployeeList()
        {
            try
            {
                var listEmlpoyees = employeeService.GetAll();
                BindGrid(listEmlpoyees);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmEmployees_Load(object sender, EventArgs e)
        {

            cmbPosition.Items.Add("Admin");
            cmbPosition.Items.Add("Employee");
            cmbPosition.Items.Add("Manager");
            cmbPosition.Items.Add("Support");
            cmbPosition.Items.Add("Teacher");
            cmbPosition.SelectedIndex = -1;
            setGridViewStyle(dgvEmployee);
            var listStudents = employeeService.GetAll();
            BindGrid(listStudents);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                MessageBox.Show("Vui lòng nhập mã hoặc tên nhân viên cần tìm.");
                return;
            }
            string searchValue = txtSearch.Text.ToLower();

            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                bool found = row.Cells[0].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[2].Value.ToString().ToLower().Contains(searchValue) ||
                             row.Cells[8].Value.ToString().ToLower().Contains(searchValue);

                row.Visible = found;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmloyeeID.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân viên cần xóa.");
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này không?",
                            "Xác nhận xóa",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    var employee = employeeService.GetEmployeeById(txtEmloyeeID.Text);
                    if (employee != null)
                    {
                        var message = employeeService.DeleteEmployee(txtEmloyeeID.Text); // Xóa mềm
                        MessageBox.Show(message);
                        UpdateEmployeeList(); // Cập nhật danh sách nhân viên sau khi xóa
                    }
                    else
                    {
                        MessageBox.Show("Nhân viên không tồn tại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            txtEmloyeeID.Enabled = true;
            btnAdd.Enabled = true;
            ResetInputFields();
        }

        private void btnUpdate_Click(object sender, EventArgs e)

        {
            err.Clear();
            if (!ValidateInput()) return;

            try
            {
                var employee = employeeService.GetEmployeeById(txtEmloyeeID.Text);
                if (employee != null)
                {

                    // Update student info
                    employee.last_name = txtLastName.Text;
                    employee.first_name = txtFirstName.Text;
                    employee.hire_date = dtHireDate.Value;
                    employee.position = cmbPosition.SelectedItem.ToString();
                    employee.phone = txtPhone.Text;
                    employee.email = txtEmail.Text;
                    employee.salary = decimal.Parse(txtSalary.Text);


                    employeeService.UpdateEmployee(employee); // Update student in database

                    UpdateEmployeeList();

                    MessageBox.Show("Sửa dữ liệu thành công!");
                }
                else
                {
                    MessageBox.Show("Nhân viên không tồn tại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ResetInputFields();
            txtEmloyeeID.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            {
                err.Clear();
                if (!ValidateInput()) return;

                // Check if the student already exists
                bool exists = dgvEmployee.Rows.Cast<DataGridViewRow>()
                                              .Any(r => r.Cells[0].Value.ToString() == txtEmloyeeID.Text);

                if (!exists)
                {
                    try
                    {
                        Employee newEmployee = new Employee
                        {
                            employee_id = txtEmloyeeID.Text,
                            last_name = txtLastName.Text,
                            first_name = txtFirstName.Text,
                            hire_date = dtHireDate.Value,
                            phone = txtPhone.Text,
                            salary = decimal.Parse(txtSalary.Text),
                            email = txtEmail.Text,
                            position = cmbPosition.SelectedItem.ToString()
                        };

                        employeeService.AddEmployee(newEmployee);
                        UpdateEmployeeList();

                        MessageBox.Show("Thêm mới dữ liệu thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Mã số nhân viên đã tồn tại.");
                }
                ResetInputFields();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvEmployee.Rows)
            {
                row.Visible = true;
            }
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvEmployee.Rows[e.RowIndex];
                txtEmloyeeID.Text = row.Cells[0].Value.ToString();
                txtLastName.Text = row.Cells[1].Value.ToString();
                txtFirstName.Text = row.Cells[2].Value.ToString();
                dtHireDate.Value = DateTime.Parse(row.Cells[3].Value.ToString());
                cmbPosition.Text = row.Cells[4].Value.ToString();
                txtPhone.Text = row.Cells[5].Value.ToString();
                txtEmail.Text = row.Cells[6].Value.ToString();
                txtSalary.Text = row.Cells[7].Value.ToString();
            }
            txtEmloyeeID.Enabled = false;
            btnAdd.Enabled = false;
        }

    }
}
