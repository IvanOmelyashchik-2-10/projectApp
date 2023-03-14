using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectApp
{
    public partial class AdminMonitoringForm : Form
    {
        public AdminMonitoringForm()
        {
            InitializeComponent();
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminForm adminForm  = new AdminForm();
            adminForm.Show();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int id = 1;

        private void buttonDeleteAd_Click(object sender, EventArgs e)
        {
            DBimages dbim = new DBimages();
            MySqlDataReader sqlDataReader = null;
            MySqlConnection connectionImg = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pictures");
            connectionImg.Open();

            DialogResult dialog = MessageBox.Show("Do you really want to delete this picture?", "", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                MySqlCommand command_d = new MySqlCommand($"DELETE FROM `images` WHERE `id` = @iID", dbim.getConnection());
                command_d.Parameters.AddWithValue("@iId", id-1);
                MySqlDataReader dbrim;
                dbim.openConnection();
                dbrim = command_d.ExecuteReader();
                MessageBox.Show("Updated");
                dbim.closeConnection();
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (id <= 5)
            {
                DBimages dbim = new DBimages();
                MySqlDataReader sqlDataReader = null;
                MySqlConnection connectionImg = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pictures");
                connectionImg.Open();

                string request = "SELECT image FROM `images` WHERE id=" + id;

                MySqlCommand sqlCommand = new MySqlCommand(request, connectionImg);

                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    byte[] image = (byte[])(sqlDataReader[0]);
                    if (image == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(image);
                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                }
                sqlDataReader.Close();
                id++;
            }
            else
                id = 1;
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            if (id >= 1)
            {
                id--;
                DBimages dbim = new DBimages();
                MySqlDataReader sqlDataReader = null;
                MySqlConnection connectionImg = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pictures");
                connectionImg.Open();

                string request = "SELECT image FROM `images` WHERE id=" + id;

                MySqlCommand sqlCommand = new MySqlCommand(request, connectionImg);

                sqlDataReader = sqlCommand.ExecuteReader();
                sqlDataReader.Read();

                if (sqlDataReader.HasRows)
                {
                    byte[] image = (byte[])(sqlDataReader[0]);
                    if (image == null)
                        pictureBox1.Image = null;
                    else
                    {
                        MemoryStream memoryStream = new MemoryStream(image);
                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                }
                sqlDataReader.Close();
                id--;
            }
            else
                id = 6;
        }       
    }
}
