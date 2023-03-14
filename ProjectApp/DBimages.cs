using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectApp
{
    class DBimages
    {
        MySqlConnection connectionImg = new MySqlConnection("server=localhost;port=3306;username=root;password=root;database=pictures");

        public void openConnection()
        {
            if (connectionImg.State == System.Data.ConnectionState.Closed)
                connectionImg.Open();
        }

        public void closeConnection()
        {
            if (connectionImg.State == System.Data.ConnectionState.Open)
                connectionImg.Close();
        }

        public MySqlConnection getConnection()
        {
            return connectionImg;
        }
    }
}
