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
    public partial class DeleteUserForm : Form
    {
        public DeleteUserForm()
        {
            InitializeComponent();

            userLoginBox.Text = "Enter user login";
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command_d = new MySqlCommand($"DELETE FROM `users` WHERE `login` = @uLd", db.getConnection());
            command_d.Parameters.AddWithValue("@uLd", userLoginBox.Text);
            MySqlDataReader dbr;
            db.openConnection();
            dbr = command_d.ExecuteReader();
            MessageBox.Show("Updated");
            db.closeConnection();
        }


        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            if (isUserExist())
                return;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command_i = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uLi", db.getConnection());
            command_i.Parameters.AddWithValue("@uLi", userLoginBox.Text);
            MySqlDataReader drb;
            db.openConnection();
            drb = command_i.ExecuteReader();
            db.closeConnection();

            adapter.SelectCommand = command_i;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                db.openConnection();
                drb = command_i.ExecuteReader();
                drb.Read();
                object id = drb.GetValue(0);
                object login = drb.GetValue(1);
                object name = drb.GetValue(3);
                object surname = drb.GetValue(4);
                object mail = drb.GetValue(5);
                object age = drb.GetValue(6);
                MessageBox.Show(("id:\t" + id + "\nlogin:\t" + login + "\nname:\t" + name + "\nsname:\t" + surname + "\nmail:\t" + mail + "\nage:\t" + age));
                db.closeConnection();
            }
            else
                MessageBox.Show("User not found =(");
        }

        public bool isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = userLoginBox.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                MessageBox.Show("User not found =(");
            return true;
        }
    }
}
