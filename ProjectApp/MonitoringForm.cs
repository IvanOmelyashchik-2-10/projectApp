using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProjectApp
{
    public partial class MonitoringForm : Form
    {
        public MonitoringForm()
        {
            InitializeComponent();
        }

        private void MonitoringForm_Load(object sender, EventArgs e)
        {

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserActionsForm userActionsForm = new UserActionsForm();
            userActionsForm.Show();
        }

        private void buttonStartMonitorig_Click(object sender, EventArgs e)
        {
            DBimages dbim = new DBimages();
            MySqlDataReader sqlDataReader = null;
            MySqlConnection connectionImg = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pictures");
            connectionImg.Open();
            int id = 6;

            while (id > 0)
            {
                Thread.Sleep(1000);
                string request = "SELECT `image` FROM `images` WHERE `id`="+id;

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
        }

        int id = 1;        
        
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
            }
            else
                id = 6;
        }
    }
}
