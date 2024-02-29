namespace LibraryProject
{
    partial class LoginAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginAdmin));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPassword = new TextBox();
            cbShowPassword = new CheckBox();
            btnLogin = new Button();
            label4 = new Label();
            btnLoginUser = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 750);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(798, 60);
            label1.Name = "label1";
            label1.Size = new Size(579, 45);
            label1.TabIndex = 2;
            label1.Text = "WELCOME TO LIBRARY MASTER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(829, 187);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 3;
            label2.Text = "Email";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(829, 248);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 31);
            textBoxEmail.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(829, 342);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(829, 402);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(261, 31);
            textBoxPassword.TabIndex = 6;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(870, 454);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(183, 27);
            cbShowPassword.TabIndex = 7;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            cbShowPassword.CheckedChanged += cbShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SaddleBrown;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(978, 557);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 69);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(912, 672);
            label4.Name = "label4";
            label4.Size = new Size(194, 28);
            label4.TabIndex = 9;
            label4.Text = "Are you a user?";
            // 
            // btnLoginUser
            // 
            btnLoginUser.BackgroundImageLayout = ImageLayout.None;
            btnLoginUser.Cursor = Cursors.Hand;
            btnLoginUser.FlatAppearance.BorderSize = 0;
            btnLoginUser.FlatStyle = FlatStyle.Flat;
            btnLoginUser.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginUser.ForeColor = SystemColors.HotTrack;
            btnLoginUser.Location = new Point(1102, 657);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(238, 54);
            btnLoginUser.TabIndex = 10;
            btnLoginUser.Text = "Login User here";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1401, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 34);
            btnClose.TabIndex = 11;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // LoginAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1500, 750);
            Controls.Add(btnClose);
            Controls.Add(btnLoginUser);
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
            Name = "LoginAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPassword;
        private CheckBox cbShowPassword;
        private Button btnLogin;
        private Label label4;
        private Button btnLoginUser;
        private Button btnClose;
    }
}