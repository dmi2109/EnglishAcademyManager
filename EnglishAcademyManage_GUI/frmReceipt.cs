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
                DataPropertyName = "payment_status",  // Liên kết với trường dữ liệu
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
                r.payment_status
            })
            .ToList();


            // Đảm bảo DataGridView không tự động tạo cột
            dgvReceipts.AutoGenerateColumns = false;

            // Cập nhật DataSource
            dgvReceipts.DataSource = null; // Xóa liên kết hiện tại nếu có
            dgvReceipts.DataSource = receipts; // Gán dữ liệu mới
        }



        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchValue = txtSearch.Text;
            string paymentStatusFilter = cmbPaymentStatusFilter.SelectedItem?.ToString();

            // Lấy danh sách biên lai từ dịch vụ
            var receiptsQuery = _receiptService.GetAllReceipts().AsQueryable();

            // Lọc theo giá trị tìm kiếm (tên học sinh hoặc mã biên lai)
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
                    r.payment_status == paymentStatusFilter);
            }

            // Chuyển đổi dữ liệu thành danh sách hiển thị
            var receipts = receiptsQuery.Select(r => new
            {
                r.receipt_id,
                StudentName = r.Student.first_name + " " + r.Student.last_name,
                r.amount,
                r.payment_date,
                r.payment_status
            }).ToList();

            // Cập nhật dữ liệu cho DataGridView
            dgvReceipts.AutoGenerateColumns = false;
            dgvReceipts.DataSource = null;
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

                if (receipt.payment_status == "Completed")
                {
                    receipt.payment_status = "Pending";  
                }
                else if (receipt.payment_status == "Pending")
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
                string receiptId = dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value.ToString();

                _receiptService.DeleteReceipt(receiptId);

                LoadReceipts();
            }
            else
            {
                MessageBox.Show("Please select a receipt to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private PrintDocument printDocument = new PrintDocument();
        private string receiptContent; 

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
                                 $"Employee: {employeeName}\n" +  
                                 $"Student ID: {receipt.student_id}\n" +
                                 $"---------------------------------------\n" +
                                 $"Amount: {receipt.amount} USD\n" +
                                 $"Payment Status: {receipt.payment_status}\n" +
                                 $"---------------------------------------\n" +
                                 $"Description: {receipt.description}\n" +
                                 $"---------------------------------------\n" +
                                 $"Employee Signature: _______________\n";


                printDocument1.PrintPage -= PrintDocument_PrintPage;

                printDocument1.PrintPage += PrintDocument_PrintPage;


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
            e.Graphics.Clear(Color.White); 
            e.Graphics.DrawString(receiptContent, new Font("Arial", 12), Brushes.Black, 50, 50);
        }

        private string CreateReceiptContent(Receipt receipt)
        {
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
            Font titleFont = new Font("Arial", 16, FontStyle.Bold);
            Font contentFont = new Font("Arial", 12);
            float yPos = 50; 
            float leftMargin = e.MarginBounds.Left;

            e.Graphics.DrawString("English Academy Receipt", titleFont, Brushes.Black, leftMargin, yPos);
            yPos += titleFont.GetHeight(e.Graphics) + 10;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;

            e.Graphics.DrawString($"Receipt ID: {dgvReceipts.SelectedRows[0].Cells["receipt_id"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Date: {DateTime.Now.ToShortDateString()}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Employee: {dgvReceipts.SelectedRows[0].Cells["employee"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Student ID: {dgvReceipts.SelectedRows[0].Cells["student_id"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;


            e.Graphics.DrawString($"Amount: {dgvReceipts.SelectedRows[0].Cells["amount"].Value} USD", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 5;
            e.Graphics.DrawString($"Payment Status: {(dgvReceipts.SelectedRows[0].Cells["amount"].Value != null ? "Paid" : "Unpaid")}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, e.MarginBounds.Right, yPos);
            yPos += 20;

            e.Graphics.DrawString($"Description: {dgvReceipts.SelectedRows[0].Cells["description"].Value}", contentFont, Brushes.Black, leftMargin, yPos);
            yPos += contentFont.GetHeight(e.Graphics) + 20;

            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + 200, yPos);
            yPos += 5;
            e.Graphics.DrawString("Employee Signature", contentFont, Brushes.Black, leftMargin, yPos);
        }
    }
}

