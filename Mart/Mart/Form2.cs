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
using Mysqlx.Session;
using System.IO;

namespace Mart
{
    public partial class Form2 : Form
    {

        int i = 0;

        MySqlConnection koneksi = connections.getConnection();
        DataTable dataTable = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }
        public void resetIncrement()
        {
            MySqlScript script = new MySqlScript(koneksi, "SET @Id_produk := 0; UPDATE produk SET Id_produk = @Id_produk := (@Id_produk+1); " +
                "ALTER TABLE produk AUTO_INCREMENT = 1;");

            script.Execute();
        }
        public DataTable getDataProduct()
        {
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM produk", koneksi))
            {
                koneksi.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;

        }
        public void filldataTable()
        {
            dataGridView.DataSource = getDataProduct();
        }
        private void btn_new_Click(object sender, EventArgs e)
        {
            byte[] imageData;
            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                imageData = ms.ToArray();
            }
            MySqlCommand cmd;

            try
            {
                resetIncrement();

                cmd = koneksi.CreateCommand();
                cmd.CommandText = "insert into produk (kode_produk, nama_produk, harga_produk, satuan_produk, jumlah_produk, images) VALUE (@kode_produk, @nama_produk, @harga_produk, @satuan_produk, @jumlah_produk, @images)";
                cmd.Parameters.AddWithValue("@kode_produk", txt_kode.Text);
                cmd.Parameters.AddWithValue("@nama_produk", txt_nama.Text);
                cmd.Parameters.AddWithValue("@harga_produk", txt_harga.Text);
                cmd.Parameters.AddWithValue("@satuan_produk", txt_satuan.Text);
                cmd.Parameters.AddWithValue("@jumlah_produk", txt_jumlah.Text);
                cmd.Parameters.AddWithValue("@images", imageData);

                cmd.ExecuteNonQuery();
                koneksi.Close();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error karena = " + ex);
            }
        }
        public void searchData(string ValueToFind)
        {
            string searchQuery = "SELECT * FROM produk WHERE CONCAT (kode_produk, nama_produk, harga_produk, satuan_produk, jumlah_produk) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, koneksi);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView.DataSource = table;
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            searchData(txt_search.Text);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox.Image.Save(ms, pictureBox.Image.RawFormat);
            byte[] img = ms.ToArray();

            MySqlCommand cmd;
            // mengecek apakah ada field yang kosong
            if ((txt_id.Text == string.Empty || txt_kode.Text == string.Empty || txt_nama.Text == string.Empty || txt_harga.Text == string.Empty || txt_satuan.Text == string.Empty || txt_jumlah.Text == string.Empty))
            {
                MessageBox.Show("Tolong isi semua field !", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cmd = koneksi.CreateCommand();
                cmd.CommandText = "UPDATE produk SET kode_produk=@kode_produk, nama_produk=@nama_produk, harga_produk=@harga_produk, satuan_produk=@satuan_produk, jumlah_produk=@jumlah_produk, images=@images where id_produk=@id_produk";
                cmd.Parameters.AddWithValue("@id_produk", txt_id.Text);
                cmd.Parameters.AddWithValue("@kode_produk", txt_kode.Text);
                cmd.Parameters.AddWithValue("@nama_produk", txt_nama.Text);
                cmd.Parameters.AddWithValue("@harga_produk", txt_harga.Text);
                cmd.Parameters.AddWithValue("@satuan_produk", txt_satuan.Text);
                cmd.Parameters.AddWithValue("@jumlah_produk", txt_jumlah.Text);
                cmd.Parameters.AddWithValue("@images", img);
                cmd.ExecuteNonQuery();

                i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("yipiyey data berhasil diupdate nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("yaahh data belom berhasil diupdate T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                koneksi.Close();
                filldataTable();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            resetIncrement();
            //mengkonversi type data int jadi toint32 agar tidak eror d c#
            int Id_produk = Convert.ToInt32(dataGridView.CurrentCell.RowIndex.ToString());

            MySqlCommand cmd;
            cmd = koneksi.CreateCommand();
            //menghapus data yg ada di tabel produk dmn id produknya  di ambil dri @id_produk yg d msukan di txt_id
            cmd.CommandText = "DELETE FROM `produk` WHERE Id_produk=@Id_produk";
            cmd.Parameters.AddWithValue("@Id_produk", txt_id.Text);
            i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                MessageBox.Show("Yey Data berhasil dihapus nich :)", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("yaahh data belum berhasil dihapus T_T", "CRUD", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            koneksi.Close();
            filldataTable();
        }

        private void btn_image_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(openFileDialog.FileName);
                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_harga_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_jumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            filldataTable();
            //supaya form 2 bs menampilkan data yg ad d tabel produk
        }
    }
}
