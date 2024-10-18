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
                dgvStudent.Rows[index].Cells[3].Value = item.day_of_birth;
                dgvStudent.Rows[index].Cells[4].Value = item.phone;
                dgvStudent.Rows[index].Cells[5].Value = item.email;
            }
        }

        public void setGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.BackgroundColor = Color.White;
            dgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

       

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
