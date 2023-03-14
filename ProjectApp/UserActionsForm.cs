using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class UserActionsForm : Form
    {
        public UserActionsForm()
        {
            InitializeComponent();
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Gray;
        }

        private void ButtonToBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Green;
        }

        private void ButtonToBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Gray;
        }

        private void LoadAdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoadPicForm loadPicForm = new LoadPicForm();
            loadPicForm.Show();
        }

        private void LogAdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void UserActionsForm_Load(object sender, EventArgs e)
        {

        }

        private void MonitoringAdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonitoringForm monitoringForm = new MonitoringForm();
            monitoringForm.Show();
        }
    }
}