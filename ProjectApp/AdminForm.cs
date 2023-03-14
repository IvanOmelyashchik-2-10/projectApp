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
    public partial class AdminForm : Form
    {
        public AdminForm()
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

        private void ButtonToBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Green;
        }

        private void ButtonToBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Gray;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Red;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Gray;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void CheckUsersButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeleteUserForm deleteUserForm = new DeleteUserForm();
            deleteUserForm.Show();
        }

        private void MonitoringAdButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMonitoringForm adminMonitoringForm = new AdminMonitoringForm();
            adminMonitoringForm.Show();
        }
    }
}