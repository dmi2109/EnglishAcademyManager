using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnglishAcademyManage_DAL.Entities; 


namespace EnglishAcademyManage_GUI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }
        private void InitializeCustomComponents()
        {
            this.Text = "Login";
            this.Size = new Size(600, 400); 
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 
            this.FormBorderStyle = FormBorderStyle.FixedDialog; 

            
            Panel logoPanel = new Panel
            {
                Size = new Size(250, 250), 
                Location = new Point(20, 20), 
                BackColor = Color.LightGray, 
                BorderStyle = BorderStyle.FixedSingle
            };

            PictureBox logoPictureBox = new PictureBox
            {
                Image = Image.FromFile("C:\\Users\\KyMinh\\Desktop\\EnglishAcademyManager\\EnglishAcademyManage_GUI\\Images\\ISELogin.jpg"), 
                SizeMode = PictureBoxSizeMode.Zoom, 
                Size = new Size(250, 250), 
                Location = new Point(0, 0)
            };

            logoPanel.Controls.Add(logoPictureBox);

            this.Controls.Add(logoPanel);

            SiticoneButton titleButton = new SiticoneButton
            {
                Text = "Login",
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                Location = new Point(300, 20), 
                Size = new Size(200, 40), 
                BorderRadius = 10, 
                FillColor = Color.Transparent,
                ForeColor = Color.Black,
                HoverState = { FillColor = Color.Transparent } 
            };

            titleButton.Click += (s, e) => { /* No action needed on click */ };
            this.Controls.Add(titleButton);

            
            SiticoneTextBox usernameTextBox = new SiticoneTextBox
            {
                PlaceholderText = "Username",
                Size = new Size(250, 40),
                Location = new Point(300, 80),
                BorderRadius = 8,
                BorderColor = Color.Gray,
                PlaceholderForeColor = Color.Gray,
                ForeColor = Color.Black,
            };
            this.Controls.Add(usernameTextBox);

            string eyeOpenIconPath = "C:\\Users\\KyMinh\\Desktop\\EnglishAcademyManager\\EnglishAcademyManage_GUI\\Images\\eye_open.png"; 
            string eyeClosedIconPath = "C:\\Users\\KyMinh\\Desktop\\EnglishAcademyManager\\EnglishAcademyManage_GUI\\Images\\eye_closed.png"; 

            
            SiticoneTextBox passwordTextBox = new SiticoneTextBox
            {
                PlaceholderText = "Password",
                Size = new Size(250, 40),
                Location = new Point(300, 130),
                BorderRadius = 8,
                BorderColor = Color.Gray,
                PlaceholderForeColor = Color.Gray,
                ForeColor = Color.Black,
                UseSystemPasswordChar = true,
                IconRight = Image.FromFile(eyeClosedIconPath), 
                IconRightSize = new Size(20, 20)
            };

            bool isPasswordVisible = false;
            passwordTextBox.IconRightClick += (s, e) =>
            {
                isPasswordVisible = !isPasswordVisible;
                passwordTextBox.UseSystemPasswordChar = !isPasswordVisible;

                passwordTextBox.IconRight = isPasswordVisible
                    ? Image.FromFile(eyeOpenIconPath) 
                    : Image.FromFile(eyeClosedIconPath); 
            };
            this.Controls.Add(passwordTextBox);

            SiticoneComboBox roleComboBox = new SiticoneComboBox
            {
                Size = new Size(250, 40),
                Location = new Point(300, 180),
                BorderRadius = 8,
                ForeColor = Color.Black
            };
            roleComboBox.Items.AddRange(new string[] { "Administrator", "Employee", "Teacher", "Student" });
            roleComboBox.SelectedIndex = 0;
            this.Controls.Add(roleComboBox);

            SiticoneCheckBox rememberCheckBox = new SiticoneCheckBox
            {
                Text = "Remember password",
                Location = new Point(300, 230),
                AutoSize = true,
                ForeColor = Color.Black 
            };
            this.Controls.Add(rememberCheckBox);

            SiticoneButton loginButton = new SiticoneButton
            {
                Text = "Login",
                Size = new Size(100, 40),
                Location = new Point(300, 270),
                BorderRadius = 10,
                FillColor = Color.Blue,
                ForeColor = Color.White,
                HoverState = { FillColor = Color.DarkBlue } 
            };
            loginButton.Click += (s, e) =>
            {
                string username = usernameTextBox.Text.Trim();
                string password = passwordTextBox.Text.Trim();
                string selectedRole = roleComboBox.SelectedItem?.ToString().Trim();

                using (var context = new EnglishAcademyDbContext())
                {
                    var account = context.Accounts
                        .Where(a => a.login.Equals(username, StringComparison.OrdinalIgnoreCase)
                                    && a.password == password
                                    && a.role.Equals(selectedRole, StringComparison.OrdinalIgnoreCase)
                                    && a.is_active == true)
                        .FirstOrDefault();

                    if (account != null)
                    {
                        MessageBox.Show($"Login successful with role: {selectedRole}");
                        frmEnglishAcademyManage mainForm = new frmEnglishAcademyManage(selectedRole);
                        mainForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };
            this.Controls.Add(loginButton);

            SiticoneButton forgotPasswordButton = new SiticoneButton
            {
                Text = "Forgot password?",
                Size = new Size(130, 30),
                Location = new Point(420, 230),
                BorderRadius = 10,
                FillColor = Color.Transparent,
                ForeColor = Color.Blue,
                HoverState = { FillColor = Color.LightBlue } 
            };
            forgotPasswordButton.Click += (s, e) =>
            {
                MessageBox.Show("Please contact the administrator to retrieve your password.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            };
            this.Controls.Add(forgotPasswordButton);

            SiticoneButton exitButton = new SiticoneButton
            {
                Text = "Exit",
                Size = new Size(100, 40),
                Location = new Point(420, 270),
                BorderRadius = 10,
                FillColor = Color.BlueViolet,
                ForeColor = Color.White,
                HoverState = { FillColor = Color.DarkRed } 
            };
            exitButton.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (result == DialogResult.OK)
                {
                    this.Close(); 
                }
            };
            this.Controls.Add(exitButton);
        } 
    }
}
