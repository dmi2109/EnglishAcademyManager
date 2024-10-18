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
    public partial class frmAddReceipt : Form
    {
        public frmAddReceipt()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string studentID = txtStudentID.Text;
            decimal amount;
            if (!decimal.TryParse(txtAmount.Text, out amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DateTime paymentDate = dtpPaymentDate.Value;
            string description = txtDescription.Text;
            string paymentStatus = cmbPaymentStatus.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(studentID) || string.IsNullOrWhiteSpace(paymentStatus))
            {
                MessageBox.Show("Please fill in all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Tạo một hóa đơn mới
            var newReceipt = new Receipt
            {
                student_id = studentID,
                amount = amount,
                payment_date = paymentDate,
                description = description,
                payment_status = paymentStatus
            };

            // Thêm hóa đơn vào cơ sở dữ liệu
            using (var context = new EnglishAcademyDbContext())
            {
                context.Receipts.Add(newReceipt);
                context.SaveChanges();
            }

            MessageBox.Show("Receipt added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Đóng form sau khi thêm hóa đơn thành công
        }
    }
}
