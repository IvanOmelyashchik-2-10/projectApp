using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.PasswordBox.AutoSize = false;
            this.PasswordBox.Size = new Size(this.PasswordBox.Size.Width, 50);

            LoginBox.Text = "Enter your login";
            LoginBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Enter";
            PasswordBox.ForeColor = Color.Gray;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

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

        Point lastPoint;
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String UserLogin = LoginBox.Text;
            String UserPass = PasswordBox.Text;

            DB db = new DB();

            DataTable table = new DataTable();
            DataTable table_a = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            UserActionsForm userActionsForm = new UserActionsForm();
            AdminForm adminForm = new AdminForm();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @UL AND `pass` = @UP", db.getConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = UserLogin;
            command.Parameters.Add("@UP", MySqlDbType.VarChar).Value = UserPass;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Authorization was successful!");
                this.Hide();                
                userActionsForm.Show();
            }
            else
                MessageBox.Show("Authorisation Error. Check your login and password.");

            MySqlCommand command_a = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @aUL AND `pass` = @aUP AND `adm` = 1", db.getConnection());
            command_a.Parameters.Add("@aUL", MySqlDbType.VarChar).Value = UserLogin;
            command_a.Parameters.Add("@aUP", MySqlDbType.VarChar).Value = UserPass;
         
            adapter.SelectCommand = command_a;
            adapter.Fill(table_a);

            if (table_a.Rows.Count > 0)
            {
                MessageBox.Show("Authorization as admin was successful!");
                userActionsForm.Hide();
                adminForm.Show();
            }
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "Enter your login")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.ForeColor = Color.Gray;
                LoginBox.Text = "Enter your login";
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Enter")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.Black;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.ForeColor = Color.Gray;
                PasswordBox.Text = "Enter";
            }
        }

        private void ButtonToRegister_MouseEnter(object sender, EventArgs e)
        {
            ButtonToRegister.ForeColor = Color.Blue;
        }

        private void ButtonToRegister_MouseLeave(object sender, EventArgs e)
        {
            ButtonToRegister.ForeColor = Color.Black;
        }

        private void ButtonToRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void ButtonToBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Green;
        }

        private void ButtonToBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Gray;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginBox.Text = "123";
            PasswordBox.Text = "123";
        }
    }
}
