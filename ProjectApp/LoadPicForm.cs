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
    public partial class LoadPicForm : Form
    {
        string imgLoc = "";
        public LoadPicForm()
        {
            InitializeComponent();
        }

        private void ButtonToBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserActionsForm userActionsForm = new UserActionsForm();
            userActionsForm.Show();
        }

        private void ButtonToBack_MouseEnter(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Green;
        }

        private void ButtonToBack_MouseLeave(object sender, EventArgs e)
        {
            ButtonToBack.ForeColor = Color.Gray;
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

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();

                ofd.Filter = "Imagine Files(*.BMP;*.JPG;*GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All file (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = ofd.FileName.ToString();
                    pictureBox.ImageLocation = imgLoc;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            DBimages dbim = new DBimages();
            dbim.openConnection();

            byte[] image = null;
            FileStream fileStream = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            image = binaryReader.ReadBytes((int)fileStream.Length);

            MySqlCommand command = new MySqlCommand("INSERT INTO `images` (`image`) VALUES (@image);", dbim.getConnection());
            command.Parameters.Add(new MySqlParameter("@image", image));

            command.ExecuteNonQuery();
            MessageBox.Show("File has been attached!");
        }
    }
}
