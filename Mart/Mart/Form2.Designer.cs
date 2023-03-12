namespace Mart
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            btn_image = new Button();
            txt_jumlah = new TextBox();
            label6 = new Label();
            txt_satuan = new TextBox();
            label5 = new Label();
            txt_harga = new TextBox();
            label4 = new Label();
            txt_nama = new TextBox();
            label3 = new Label();
            txt_kode = new TextBox();
            label2 = new Label();
            txt_id = new TextBox();
            label1 = new Label();
            pictureBox = new PictureBox();
            txt_search = new TextBox();
            label7 = new Label();
            btn_new = new Button();
            btn_edit = new Button();
            btn_delete = new Button();
            dataGridView = new DataGridView();
            label8 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(btn_image);
            panel1.Controls.Add(txt_jumlah);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txt_satuan);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txt_harga);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txt_nama);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_kode);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_id);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(12, 72);
            panel1.Name = "panel1";
            panel1.Size = new Size(1058, 339);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btn_image
            // 
            btn_image.BackColor = Color.RosyBrown;
            btn_image.Location = new Point(71, 265);
            btn_image.Name = "btn_image";
            btn_image.Size = new Size(112, 34);
            btn_image.TabIndex = 13;
            btn_image.Text = "Image";
            btn_image.UseVisualStyleBackColor = false;
            btn_image.Click += btn_image_Click;
            // 
            // txt_jumlah
            // 
            txt_jumlah.Location = new Point(514, 285);
            txt_jumlah.Name = "txt_jumlah";
            txt_jumlah.Size = new Size(385, 31);
            txt_jumlah.TabIndex = 12;
            txt_jumlah.TextChanged += txt_jumlah_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.RosyBrown;
            label6.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(329, 287);
            label6.Name = "label6";
            label6.Size = new Size(127, 29);
            label6.TabIndex = 11;
            label6.Text = "Jumlah Produk";
            label6.Click += label6_Click;
            // 
            // txt_satuan
            // 
            txt_satuan.Location = new Point(514, 229);
            txt_satuan.Name = "txt_satuan";
            txt_satuan.Size = new Size(385, 31);
            txt_satuan.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.RosyBrown;
            label5.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(329, 229);
            label5.Name = "label5";
            label5.Size = new Size(127, 29);
            label5.TabIndex = 9;
            label5.Text = "Satuan Produk";
            // 
            // txt_harga
            // 
            txt_harga.Location = new Point(514, 181);
            txt_harga.Name = "txt_harga";
            txt_harga.Size = new Size(385, 31);
            txt_harga.TabIndex = 8;
            txt_harga.TextChanged += txt_harga_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.RosyBrown;
            label4.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(329, 181);
            label4.Name = "label4";
            label4.Size = new Size(120, 29);
            label4.TabIndex = 7;
            label4.Text = "Harga Produk";
            // 
            // txt_nama
            // 
            txt_nama.Location = new Point(514, 131);
            txt_nama.Name = "txt_nama";
            txt_nama.Size = new Size(385, 31);
            txt_nama.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.RosyBrown;
            label3.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(329, 131);
            label3.Name = "label3";
            label3.Size = new Size(119, 29);
            label3.TabIndex = 5;
            label3.Text = "Nama Produk";
            // 
            // txt_kode
            // 
            txt_kode.Location = new Point(514, 80);
            txt_kode.Name = "txt_kode";
            txt_kode.Size = new Size(385, 31);
            txt_kode.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.RosyBrown;
            label2.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(329, 80);
            label2.Name = "label2";
            label2.Size = new Size(111, 29);
            label2.TabIndex = 3;
            label2.Text = "Kode Produk";
            label2.Click += label2_Click;
            // 
            // txt_id
            // 
            txt_id.Location = new Point(514, 26);
            txt_id.Name = "txt_id";
            txt_id.Size = new Size(385, 31);
            txt_id.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RosyBrown;
            label1.Font = new Font("Sitka Banner", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 28);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 1;
            label1.Text = "ID Produk";
            label1.Click += label1_Click;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.RosyBrown;
            pictureBox.BorderStyle = BorderStyle.Fixed3D;
            pictureBox.Location = new Point(18, 13);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(233, 221);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(134, 417);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(385, 31);
            txt_search.TabIndex = 15;
            txt_search.TextChanged += txt_search_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.RosyBrown;
            label7.Location = new Point(30, 423);
            label7.Name = "label7";
            label7.Size = new Size(64, 25);
            label7.TabIndex = 14;
            label7.Text = "Search";
            label7.Click += label7_Click;
            // 
            // btn_new
            // 
            btn_new.BackColor = Color.RosyBrown;
            btn_new.Location = new Point(584, 414);
            btn_new.Name = "btn_new";
            btn_new.Size = new Size(112, 34);
            btn_new.TabIndex = 14;
            btn_new.Text = "New";
            btn_new.UseVisualStyleBackColor = false;
            btn_new.Click += btn_new_Click;
            // 
            // btn_edit
            // 
            btn_edit.BackColor = Color.RosyBrown;
            btn_edit.Location = new Point(740, 414);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new Size(112, 34);
            btn_edit.TabIndex = 16;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = false;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.RosyBrown;
            btn_delete.Location = new Point(895, 414);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(112, 34);
            btn_delete.TabIndex = 17;
            btn_delete.Text = "Delete";
            btn_delete.UseVisualStyleBackColor = false;
            btn_delete.Click += btn_delete_Click;
            // 
            // dataGridView
            // 
            dataGridView.BackgroundColor = Color.DarkSalmon;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 475);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.RowTemplate.Height = 33;
            dataGridView.Size = new Size(995, 260);
            dataGridView.TabIndex = 18;
            dataGridView.KeyDown += dataGridView_KeyDown;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Showcard Gothic", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Chocolate;
            label8.Location = new Point(83, 9);
            label8.Name = "label8";
            label8.Size = new Size(270, 54);
            label8.TabIndex = 19;
            label8.Text = "FRUITMART";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(209, 75, 152);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1082, 751);
            Controls.Add(label8);
            Controls.Add(dataGridView);
            Controls.Add(btn_delete);
            Controls.Add(btn_edit);
            Controls.Add(btn_new);
            Controls.Add(txt_search);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btn_image;
        private TextBox txt_jumlah;
        private Label label6;
        private TextBox txt_satuan;
        private Label label5;
        private TextBox txt_harga;
        private Label label4;
        private TextBox txt_nama;
        private Label label3;
        private TextBox txt_kode;
        private Label label2;
        private TextBox txt_id;
        private Label label1;
        private PictureBox pictureBox;
        private TextBox txt_search;
        private Label label7;
        private Button btn_new;
        private Button btn_edit;
        private Button btn_delete;
        private DataGridView dataGridView;
        private Label label8;
    }
}