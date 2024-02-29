namespace LibraryProject
{
    partial class LoginUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUser));
            btnAdmin = new Button();
            label4 = new Label();
            btnLogin = new Button();
            cbShowPassword = new CheckBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAdmin
            // 
            btnAdmin.BackgroundImageLayout = ImageLayout.None;
            btnAdmin.Cursor = Cursors.Hand;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = SystemColors.HotTrack;
            btnAdmin.Location = new Point(1107, 655);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(270, 54);
            btnAdmin.TabIndex = 20;
            btnAdmin.Text = "Login Admin here";
            btnAdmin.UseVisualStyleBackColor = true;
            btnAdmin.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(895, 670);
            label4.Name = "label4";
            label4.Size = new Size(221, 28);
            label4.TabIndex = 19;
            label4.Text = "Are you a admin?";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SaddleBrown;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(983, 555);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 69);
            btnLogin.TabIndex = 18;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(891, 451);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(183, 27);
            cbShowPassword.TabIndex = 17;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(850, 395);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(261, 31);
            textBoxPassword.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(845, 329);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(850, 226);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 31);
            textBoxEmail.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(845, 162);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 13;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(798, 30);
            label1.Name = "label1";
            label1.Size = new Size(579, 45);
            label1.TabIndex = 12;
            label1.Text = "WELCOME TO LIBRARY MASTER";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 750);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(750, 750);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1409, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 34);
            btnClose.TabIndex = 21;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // LoginUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 750);
            Controls.Add(btnClose);
            Controls.Add(btnAdmin);
            Controls.Add(label4);
            Controls.Add(btnLogin);
            Controls.Add(cbShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginUser";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdmin;
        private Label label4;
        private Button btnLogin;
        private CheckBox cbShowPassword;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button btnClose;
    }
}