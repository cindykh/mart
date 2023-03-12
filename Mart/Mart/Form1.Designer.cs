namespace Mart
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label2 = new Label();
            label1 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            buttonLogin = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(134, 111);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cooper Black", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(134, 165);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 2;
            label1.Text = "Password";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(287, 108);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(259, 31);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(287, 165);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(259, 31);
            txt_password.TabIndex = 4;
            txt_password.TextChanged += txt_password_TextChanged;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.RosyBrown;
            buttonLogin.Font = new Font("Times New Roman", 11F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(177, 253);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(112, 41);
            buttonLogin.TabIndex = 5;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Snap ITC", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Brown;
            label3.Location = new Point(205, 9);
            label3.Name = "label3";
            label3.Size = new Size(271, 57);
            label3.TabIndex = 6;
            label3.Text = "fruitmart";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(673, 396);
            Controls.Add(label3);
            Controls.Add(buttonLogin);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button buttonLogin;
        private Label label3;
    }
}