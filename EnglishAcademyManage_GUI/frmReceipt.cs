using EnglishAcademyManage_BUS;
using EnglishAcademyManage_DAL.Entities;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
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
            _receiptService = new ReceiptService(new EnglishAcademyDbContext()); 
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            SetupDataGridViewColumns();
            LoadReceipts();
            
        }
        private void SetupDataGridViewColumns()
        {
            // Xóa các cột cũ nếu cần thiết
            dgvReceipts.Columns.Clear();

            // Thêm cột định nghĩa rõ ràng
            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "receipt_id",
                HeaderText = "Receipt ID",
                DataPropertyName = "receipt_id",  // Liên kết với trường dữ liệu
            });
            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "StudentName",
                HeaderText = "Student Name",
                DataPropertyName = "StudentName",  // Liên kết với trường dữ liệu
            });
            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "amount",
                HeaderText = "Amount",
                DataPropertyName = "amount",  // Liên kết với trường dữ liệu
            });
            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "payment_date",
                HeaderText = "Payment Date",
                DataPropertyName = "payment_date",  // Liên kết với trường dữ liệu
            });
            dgvReceipts.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PaymentStatus",
                HeaderText = "Payment Status",
                DataPropertyName = "PaymentStatus",  // Liên kết với trường dữ liệu
            });
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

            // Không cần xóa hàng trực tiếp
            dgvReceipts.AutoGenerateColumns = false;
            dgvReceipts.DataSource = null; // Xóa liên kết hiện tại
            dgvReceipts.DataSource = receipts; // Gán dữ liệu mới
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            string paymentStatusFilter = cmbPaymentStatusFilter.SelectedItem?.ToString();

            var receiptsQuery = _receiptService.GetAllReceipts().AsQueryable();

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

            var receipts = receiptsQuery.Select(r => new
            {
                r.receipt_id,
                StudentName = r.Student.first_name + " " + r.Student.last_name,
                r.amount,
                r.payment_date,
                PaymentStatus = r.amount.HasValue ? "Paid" : "Unpaid"
            }).ToList();

            dgvReceipts.AutoGenerateColumns = false;
            dgvReceipts.DataSource = null;  // Xóa liên kết hiện tại để đảm bảo không có xung đột
            dgvReceipts.DataSource = receipts;
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
                string receiptId = dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value.ToString();

                var receipt = _receiptService.GetReceiptById(receiptId);

                if (receipt.amount.HasValue)
                {
                    receipt.amount = null;  
                }
                else
                {
                    MessageBox.Show("Receipt is already unpaid.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _receiptService.UpdateReceipt(receipt);

                LoadReceipts();
            }
            else
            {
                MessageBox.Show("Please select a receipt to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btnDeleteReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                // Get the receipt_id as a string (since your receipt_id is of type string)
                string receiptId = dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value.ToString();

                // Assuming _receiptService.DeleteReceipt accepts a string for receipt_id
                _receiptService.DeleteReceipt(receiptId);

                // Reload the receipts to reflect the deletion
                LoadReceipts();
            }
            else
            {
                MessageBox.Show("Please select a receipt to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private PrintDocument printDocument = new PrintDocument();
        private string receiptContent; // Chuỗi chứa nội dung hóa đơn để in

        private void btnPrintReceipt_Click(object sender, EventArgs e)
        {
            if (dgvReceipts.SelectedRows.Count > 0)
            {
                string receiptId = dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value.ToString();
                var receipt = _receiptService.GetReceiptById(receiptId);

                // Lấy tên nhân viên từ thuộc tính Employee
                string employeeName = receipt.Employee != null ? receipt.Employee.first_name + " " + receipt.Employee.last_name : "Unknown";

                // Tạo nội dung hóa đơn
                receiptContent = $"" +
                                 $"English Academy Receipt\n" +
                                 $"---------------------------------------\n" +
                                 $"Receipt ID: {receipt.receipt_id}\n" +
                                 $"Date: {DateTime.Now.ToShortDateString()}\n" +
                                 $"Employee: {employeeName}\n" +  // Hiển thị tên nhân viên
                                 $"Student ID: {receipt.student_id}\n" +
                                 $"---------------------------------------\n" +
                                 $"Amount: {receipt.amount} USD\n" +
                                 $"Payment Status: {receipt.payment_status}\n" +
                                 $"---------------------------------------\n" +
                                 $"Description: {receipt.description}\n" +
                                 $"---------------------------------------\n" +
                                 $"Employee Signature: _______________\n";

                // Hủy đăng ký sự kiện trước đó (nếu có) để tránh in đè
                printDocument1.PrintPage -= PrintDocument_PrintPage;

                printDocument1.PrintPage += PrintDocument_PrintPage;

                // Hiển thị hộp thoại xem trước trước khi in
                PrintPreviewDialog previewDialog = new PrintPreviewDialog
                {
                    Document = printDocument1
                };
                previewDialog.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a receipt to print.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.Clear(Color.White); // Sử dụng màu trắng cho nền
            e.Graphics.DrawString(receiptContent, new Font("Arial", 12), Brushes.Black, 50, 50);
        }

        private string CreateReceiptContent(Receipt receipt)
        {
            // Tạo nội dung hóa đơn từ đối tượng Receipt
            return $"" +
                   $"English Academy Receipt\n" +
                   $"---------------------------------------\n" +
                   $"Receipt ID: {receipt.receipt_id}\n" +
                   $"Date: {DateTime.Now.ToShortDateString()}\n" +
                   $"Amount: {receipt.amount} USD\n" +
                   $"Payment Status: {receipt.payment_status}\n" +
                   $"---------------------------------------\n" +
                   $"Description: {receipt.description}\n" +
                   $"---------------------------------------\n";
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Tạo font và định dạng cho hóa đơn
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            float yPos = 50; // Tọa độ y để bắt đầu in
            float leftMargin = e.MarginBounds.Left;

            // In tiêu đề hóa đơn
            e.Graphics.DrawString("English Academy Receipt", titleFont, Brushes.Black, leftMargin, yPos);
            yPos += titleFont.GetHeight(e.Graphics) + 10;

            // In dòng kẻ ngăn cách
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;

            // In các chi tiết hóa đơn
            e.Graphics.DrawString($"Receipt ID: {dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Employee: {dgvReceipts.SelectedRows[0].Cells["employee"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Student ID: {dgvReceipts.SelectedRows[0].Cells["student_id"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            // In dòng kẻ ngăn cách
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;

            // In thông tin thanh toán
            e.Graphics.DrawString($"Amount: {dgvReceipts.SelectedRows[0].Cells["amount"].Value} USD", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Payment Status: {(dgvReceipts.SelectedRows[0].Cells["amount"].Value != null ? "Paid" : "Unpaid")}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            // In dòng kẻ ngăn cách
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;

            // In mô tả
            e.Graphics.DrawString($"Description: {dgvReceipts.SelectedRows[0].Cells["description"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            // In chữ ký
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 200, yPos);
            yPos += 5;
            e.Graphics.DrawString("Employee Signature", contentFont, Brushes.Black, leftMargin, yPos);
        }

    }
}

