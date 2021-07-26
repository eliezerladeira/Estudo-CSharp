using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Projeto_ERLDB
{
    public partial class Form1 : Form
    {
        private static MySqlConnection conn;

        static void connect()
        {
            string server = "localhost";
            string database = "ead";
            string user = "root";
            string password = "";
            string port = "3306";
            string sslM = "none";

            string connString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);

            conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("Conexão realizada!");
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message + connString);
            }
        }


        public Form1()
        {
            InitializeComponent();

            connect();
        }
    }
}