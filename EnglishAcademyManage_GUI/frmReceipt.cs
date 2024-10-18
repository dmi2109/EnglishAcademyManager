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
    public partial class frmReceipt : Form
    {
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddReceipt;
        private System.Windows.Forms.Button btnUpdatePaymentStatus;
        private System.Windows.Forms.Button btnDeleteReceipt;
        private System.Windows.Forms.Button btnPrintReceipt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbPaymentStatusFilter;

        private ReceiptService _receiptService;
        public frmReceipt()
        {
            InitializeComponent();
            _receiptService = new ReceiptService(new EnglishAcademyDbContext()); // Khởi tạo ReceiptService
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            LoadReceipts();
        }

        private void LoadReceipts()
        {
            var receipts = _receiptService.GetAllReceipts()
                .Select(r => new
                {
                    r.receipt_id,
                    StudentName = r.Student.first_name + " " + r.Student.last_name,
                    CourseNames = r.Student.Registrations
                        .Select(reg => reg.Course.course_name)
                        .FirstOrDefault() ?? "Not yet registered",
                    r.payment_date,
                    r.amount,
                    PaymentStatus = r.amount.HasValue ? "Paid" : "Unpaid"
                })
                .ToList();

            dgvReceipts.DataSource = receipts;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            string paymentStatusFilter = cmbPaymentStatusFilter.SelectedItem?.ToString();

            var receiptsQuery = _receiptService.GetAllReceipts().AsQueryable(); // Bắt đầu truy vấn

            // Lọc theo tên học sinh hoặc mã hóa đơn
            if (!string.IsNullOrEmpty(searchValue))
            {
                receiptsQuery = receiptsQuery.Where(r =>
                    r.Student.first_name.Contains(searchValue) ||
                    r.receipt_id.ToString().Contains(searchValue));
            }

            // Lọc theo trạng thái thanh toán
            if (!string.IsNullOrEmpty(paymentStatusFilter))
            {
                receiptsQuery = receiptsQuery.Where(r =>
                    paymentStatusFilter == "All" ||
                    (paymentStatusFilter == "Paid" ? r.amount.HasValue : !r.amount.HasValue));
            }

            // Cập nhật DataGridView
            dgvReceipts.DataSource = receiptsQuery.Select(r => new
            {
                r.receipt_id,
                StudentName = r.Student.first_name + " " + r.Student.last_name,
                r.amount,
                r.payment_date,
                PaymentStatus = r.amount.HasValue ? "Paid" : "Unpaid"
            }).ToList();
        }

        private void btnAddReceipt_Click(object sender, EventArgs e)
        {
            frmAddReceipt addReceiptForm = new frmAddReceipt();
            addReceiptForm.ShowDialog();
            LoadReceipts();
        }

        private void btnUpdatePaymentStatus_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                int receiptId = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value);
                var receipt = _receiptService.GetReceiptById(receiptId);

                // Chuyển đổi giữa thanh toán và chưa thanh toán
                receipt.amount = receipt.amount.HasValue ? null : receipt.amount;

                _receiptService.UpdateReceipt(receipt);
                LoadReceipts();
            }
        }

        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                int receiptId = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value);
                _receiptService.DeleteReceipt(receiptId);
                LoadReceipts();
            }
        }

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                int receiptId = Convert.ToInt32(dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value);
                // Xử lý in hóa đơn tại đây (có thể mở form in hoặc gọi thư viện in)
            }
        }
    }
}

