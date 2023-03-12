using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System.Data;
using System;

namespace Mart
{
    public partial class Form1 : Form
    {
        private MySqlCommand cmd;
        private DataSet ds;
        private MySqlDataAdapter da;
        private MySqlDataReader rd;

        connections koneksi = new connections();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            MySqlConnection koneksi = connections.getConnection();
            koneksi.Open();

            cmd = new MySqlCommand("Select * from login where username='" + txt_username.Text + "' and password='" + txt_password.Text + "'", koneksi);
            rd = cmd.ExecuteReader();
            rd.Read();
            if (rd.HasRows)
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau passwordmu salah, ulang lagi😓😓");
            }
        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}