namespace LibraryProject
{
    partial class RegisterUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterUser));
            textBoxUsername = new TextBox();
            label5 = new Label();
            btnLoginUser = new Button();
            label4 = new Label();
            btnRegister = new Button();
            cbShowPassword = new CheckBox();
            textBoxPassword = new TextBox();
            label3 = new Label();
            textBoxEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            btnRegisterAdmin = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(848, 179);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(261, 31);
            textBoxUsername.TabIndex = 46;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(843, 116);
            label5.Name = "label5";
            label5.Size = new Size(163, 37);
            label5.TabIndex = 45;
            label5.Text = "Username";
            // 
            // btnLoginUser
            // 
            btnLoginUser.BackgroundImageLayout = ImageLayout.None;
            btnLoginUser.Cursor = Cursors.Hand;
            btnLoginUser.FlatAppearance.BorderSize = 0;
            btnLoginUser.FlatStyle = FlatStyle.Flat;
            btnLoginUser.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginUser.ForeColor = SystemColors.HotTrack;
            btnLoginUser.Location = new Point(1163, 630);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(236, 54);
            btnLoginUser.TabIndex = 44;
            btnLoginUser.Text = "Login User here";
            btnLoginUser.UseVisualStyleBackColor = true;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(845, 645);
            label4.Name = "label4";
            label4.Size = new Size(312, 28);
            label4.TabIndex = 43;
            label4.Text = "Do you have an account?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SaddleBrown;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(985, 544);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(290, 69);
            btnRegister.TabIndex = 42;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(889, 485);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(183, 27);
            cbShowPassword.TabIndex = 41;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(848, 429);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(261, 31);
            textBoxPassword.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(843, 363);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 39;
            label3.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(848, 298);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 31);
            textBoxEmail.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(843, 234);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 37;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SaddleBrown;
            label1.Location = new Point(802, 33);
            label1.Name = "label1";
            label1.Size = new Size(579, 45);
            label1.TabIndex = 36;
            label1.Text = "WELCOME TO LIBRARY MASTER";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 750);
            panel1.TabIndex = 35;
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(888, 697);
            label6.Name = "label6";
            label6.Size = new Size(221, 28);
            label6.TabIndex = 47;
            label6.Text = "Are you a admin?";
            // 
            // btnRegisterAdmin
            // 
            btnRegisterAdmin.BackgroundImageLayout = ImageLayout.None;
            btnRegisterAdmin.Cursor = Cursors.Hand;
            btnRegisterAdmin.FlatAppearance.BorderSize = 0;
            btnRegisterAdmin.FlatStyle = FlatStyle.Flat;
            btnRegisterAdmin.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterAdmin.ForeColor = SystemColors.HotTrack;
            btnRegisterAdmin.Location = new Point(1102, 682);
            btnRegisterAdmin.Name = "btnRegisterAdmin";
            btnRegisterAdmin.Size = new Size(297, 54);
            btnRegisterAdmin.TabIndex = 48;
            btnRegisterAdmin.Text = "Register Admin here";
            btnRegisterAdmin.UseVisualStyleBackColor = true;
            btnRegisterAdmin.Click += btnLoginAdmin_Click;
            // 
            // RegisterUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 750);
            Controls.Add(btnRegisterAdmin);
            Controls.Add(label6);
            Controls.Add(textBoxUsername);
            Controls.Add(label5);
            Controls.Add(btnLoginUser);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(cbShowPassword);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(textBoxEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RegisterUser";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private Label label5;
        private Button btnLoginUser;
        private Label label4;
        private Button btnRegister;
        private CheckBox cbShowPassword;
        private TextBox textBoxPassword;
        private Label label3;
        private TextBox textBoxEmail;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnRegisterAdmin;
    }
}