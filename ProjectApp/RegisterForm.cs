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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            NameBox.Text = "name";
            NameBox.ForeColor = Color.Gray;
            SurnameBox.Text = "surname";
            SurnameBox.ForeColor = Color.Gray;
            MailBox.Text = "mail";
            MailBox.ForeColor = Color.Gray;
            AgeBox.Text = "age";
            AgeBox.ForeColor = Color.Gray;
            LoginBox.Text = "login";
            LoginBox.ForeColor = Color.Gray;
            PasswordBox.Text = "Enter";
            PasswordBox.ForeColor = Color.Gray;
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
        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void NameBox_Enter(object sender, EventArgs e)
        {
            if (NameBox.Text == "name")
            {           
                NameBox.Text = "";
                NameBox.ForeColor = Color.Black;
            }
        }

        private void SurnameBox_Enter(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "surname")
            {
                SurnameBox.Text = "";
                SurnameBox.ForeColor = Color.Black;
            }
        }

        private void MailBox_Enter(object sender, EventArgs e)
        {
            if (MailBox.Text == "mail")
            {
                MailBox.Text = "";
                MailBox.ForeColor = Color.Black;
            }
        }

        private void AgeBox_Enter(object sender, EventArgs e)
        {
            if (AgeBox.Text == "age")
            {
                AgeBox.Text = "";
                AgeBox.ForeColor = Color.Black;
            }
        }

        private void LoginBox_Enter(object sender, EventArgs e)
        {
            if (LoginBox.Text == "login")
            {
                LoginBox.Text = "";
                LoginBox.ForeColor = Color.Black;
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

        private void NameBox_Leave(object sender, EventArgs e)
        {
            if (NameBox.Text == "")
            {
                NameBox.ForeColor = Color.Gray;
                NameBox.Text = "name";
            }
        }

        private void SurnameBox_Leave(object sender, EventArgs e)
        {
            if (SurnameBox.Text == "")
            {
                SurnameBox.ForeColor = Color.Gray;
                SurnameBox.Text = "surname";
            }
        }

        private void MailBox_Leave(object sender, EventArgs e)
        {
            if (MailBox.Text == "")
            {
                MailBox.ForeColor = Color.Gray;
                MailBox.Text = "mail";
            }
        }

        private void AgeBox_Leave(object sender, EventArgs e)
        {
            if (AgeBox.Text == "")
            {
                AgeBox.ForeColor = Color.Gray;
                AgeBox.Text = "age";
            }
        }

        private void LoginBox_Leave(object sender, EventArgs e)
        {
            if (LoginBox.Text == "")
            {
                LoginBox.ForeColor = Color.Gray;
                LoginBox.Text = "login";
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

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            if(NameBox.Text == "name")
            {
                MessageBox.Show("What's your name?");
                return;
            }

            if (SurnameBox.Text == "surname")
            {
                MessageBox.Show("What's your surname?");
                return;
            }

            if (MailBox.Text == "mail")
            {
                MessageBox.Show("What's your mail?");
                return;
            }

            if (AgeBox.Text == "age")
            {
                MessageBox.Show("How old are you?");
                return;
            }

            if (LoginBox.Text == "login")
            {
                MessageBox.Show("What's your login?");
                return;
            }

            if (PasswordBox.Text == "password")
            {
                MessageBox.Show("What's your password?");
                return;
            }

            if (checkUser())
                return;

            DB db = new DB();

            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`,`pass`  `name`, `surname`, `mail`, `age`) VALUES (@login,@pass,  @name, @surname, @mail, @age);", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginBox.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordBox.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameBox.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = SurnameBox.Text;
            command.Parameters.Add("@mail", MySqlDbType.VarChar).Value = MailBox.Text;
            command.Parameters.Add("@age", MySqlDbType.Int64).Value = AgeBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Account has been created!");
            else
                MessageBox.Show("Account has not been created =(");

            db.closeConnection();
        }

        public  Boolean checkUser()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @UL", db.getConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = LoginBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("User with this login already exists =(");
                return true;
            }
            else
                return false;
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void ButtonToBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Green;
        }

        private void ButtonToBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Gray;
        }
    }
}