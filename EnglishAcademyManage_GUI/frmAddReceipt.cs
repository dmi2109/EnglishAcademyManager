using EnglishAcademyManage_DAL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnglishAcademyManage_GUI
{
    public partial class frmAddReceipt : Form
    {
        public frmAddReceipt()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            decimal amount;

            // Validate the amount input
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime paymentDate = dtpPaymentDate.Value; // Get the selected payment date
            string description = txtDescription.Text; // Get the description from input
            string paymentStatus = cmbPaymentStatus.SelectedItem?.ToString(); // Get the selected payment status

            // Validate required fields
            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(paymentStatus))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedEmployee = cmbEmployee.SelectedItem; // Get the selected employee
            if (selectedEmployee == null)
            {
                MessageBox.Show("Please select an employee.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string employeeId = ((dynamic)selectedEmployee).EmployeeId; // Get the employee ID from the selected item

            // Tạo ID hóa đơn theo định dạng "REC" và số tự động tăng
            string receiptId = GenerateReceiptId();

            // Create a new receipt
            var newReceipt = new Receipt
            {
                receipt_id = receiptId, // Set the generated unique receipt_id
                student_id = studentID,
                amount = amount,
                payment_date = paymentDate,
                description = description,
                payment_status = paymentStatus,
                employee_id = employeeId // Set the selected employee ID
            };

            // Add the receipt to the database
            using (var context = new EnglishAcademyDbContext())
            {
                try
                {
                    context.Receipts.Add(newReceipt); // Add the new receipt to the context
                    context.SaveChanges(); // Save changes to the database
                    MessageBox.Show("Receipt added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Close the form after successfully adding the receipt
                }
                catch (DbEntityValidationException dbEx)
                {
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            MessageBox.Show($"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage}", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while saving the receipt: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Phương thức để tạo ID hóa đơn
        private string GenerateReceiptId()
        {
            using (var context = new EnglishAcademyDbContext())
            {
                // Lấy số ID hóa đơn lớn nhất hiện tại
                var lastReceipt = context.Receipts
                                          .OrderByDescending(r => r.receipt_id)
                                          .FirstOrDefault();

                int newIdNumber = 1; // Mặc định là 1
                if (lastReceipt != null)
                {
                    // Trích xuất số từ ID hóa đơn cuối cùng
                    string lastId = lastReceipt.receipt_id;
                    if (lastId.StartsWith("REC"))
                    {
                        // Lấy phần số từ ID và tăng lên 1
                        string numberPart = lastId.Substring(3); // Lấy số từ ID, bỏ "REC"
                        if (int.TryParse(numberPart, out int lastNumber))
                        {
                            newIdNumber = lastNumber + 1; // Tăng số lên 1
                        }
                    }
                }

                // Tạo ID mới theo định dạng "REC" và số mới
                return $"REC{newIdNumber.ToString("D3")}"; // Ví dụ: "REC001", "REC002", ...
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult dialogResult = MessageBox.Show(
                "Are you sure you want to cancel?", // Message
                "Cancel Confirmation",              // Title
                MessageBoxButtons.YesNo,             // Buttons (Yes and No)
                MessageBoxIcon.Question);            // Icon (Question mark)

            // Check the user's response
            if (dialogResult == DialogResult.Yes)
            {
                this.Close(); // Close the form if the user clicks Yes
            }
            // No action if the user clicks No, form remains open
        }

        private EnglishAcademyDbContext dbContext = new EnglishAcademyDbContext();

        private void LoadEmployees()
        {
            try
            {
                using (dbContext = new EnglishAcademyDbContext())
                {
                    var employees = dbContext.Employees
                                             .Select(e => new
                                             {
                                                 EmployeeId = e.employee_id, 
                                                 FullName = e.first_name + " " + e.last_name 
                                             })
                                             .ToList();

                    cmbEmployee.DataSource = employees;
                    cmbEmployee.DisplayMember = "FullName"; // Show employee names
                    cmbEmployee.ValueMember = "EmployeeId"; // Use EmployeeId as value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading employees: {ex.Message}");
            }
        }


    }
}
