namespace LibraryProject
{
    partial class RegisterAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterAdmin));
            textBoxUsername = new TextBox();
            label5 = new Label();
            btnLoginAdmin = new Button();
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
            btnRegisterUser = new Button();
            btnClose = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxUsername
            // 
            textBoxUsername.BorderStyle = BorderStyle.FixedSingle;
            textBoxUsername.Location = new Point(839, 182);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(261, 31);
            textBoxUsername.TabIndex = 34;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(834, 119);
            label5.Name = "label5";
            label5.Size = new Size(163, 37);
            label5.TabIndex = 33;
            label5.Text = "Username";
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackgroundImageLayout = ImageLayout.None;
            btnLoginAdmin.Cursor = Cursors.Hand;
            btnLoginAdmin.FlatAppearance.BorderSize = 0;
            btnLoginAdmin.FlatStyle = FlatStyle.Flat;
            btnLoginAdmin.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoginAdmin.ForeColor = SystemColors.HotTrack;
            btnLoginAdmin.Location = new Point(1145, 630);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(270, 54);
            btnLoginAdmin.TabIndex = 32;
            btnLoginAdmin.Text = "Login Admin here";
            btnLoginAdmin.UseVisualStyleBackColor = true;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(836, 645);
            label4.Name = "label4";
            label4.Size = new Size(312, 28);
            label4.TabIndex = 31;
            label4.Text = "Do you have an account?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.SaddleBrown;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Century Gothic", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(983, 555);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(290, 69);
            btnRegister.TabIndex = 30;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cbShowPassword
            // 
            cbShowPassword.AutoSize = true;
            cbShowPassword.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            cbShowPassword.Location = new Point(880, 488);
            cbShowPassword.Name = "cbShowPassword";
            cbShowPassword.Size = new Size(183, 27);
            cbShowPassword.TabIndex = 29;
            cbShowPassword.Text = "Show Password";
            cbShowPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Location = new Point(839, 432);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(261, 31);
            textBoxPassword.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(834, 366);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 27;
            label3.Text = "Password";
            // 
            // textBoxEmail
            // 
            textBoxEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxEmail.Location = new Point(839, 301);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(261, 31);
            textBoxEmail.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(834, 237);
            label2.Name = "label2";
            label2.Size = new Size(95, 37);
            label2.TabIndex = 25;
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
            label1.TabIndex = 24;
            label1.Text = "WELCOME TO LIBRARY MASTER";
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(750, 750);
            panel1.TabIndex = 23;
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
            label6.Location = new Point(904, 698);
            label6.Name = "label6";
            label6.Size = new Size(194, 28);
            label6.TabIndex = 35;
            label6.Text = "Are you a user?";
            // 
            // btnRegisterUser
            // 
            btnRegisterUser.BackgroundImageLayout = ImageLayout.None;
            btnRegisterUser.Cursor = Cursors.Hand;
            btnRegisterUser.FlatAppearance.BorderSize = 0;
            btnRegisterUser.FlatStyle = FlatStyle.Flat;
            btnRegisterUser.Font = new Font("Century Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegisterUser.ForeColor = SystemColors.HotTrack;
            btnRegisterUser.Location = new Point(1093, 684);
            btnRegisterUser.Name = "btnRegisterUser";
            btnRegisterUser.Size = new Size(270, 54);
            btnRegisterUser.TabIndex = 36;
            btnRegisterUser.Text = "Register User here";
            btnRegisterUser.UseVisualStyleBackColor = true;
            btnRegisterUser.Click += btnRegisterUser_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1404, 30);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(57, 34);
            btnClose.TabIndex = 37;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // RegisterAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1500, 750);
            Controls.Add(btnClose);
            Controls.Add(btnRegisterUser);
            Controls.Add(label6);
            Controls.Add(textBoxUsername);
            Controls.Add(label5);
            Controls.Add(btnLoginAdmin);
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
            Name = "RegisterAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterAdmin_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxUsername;
        private Label label5;
        private Button btnLoginAdmin;
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
        private Button btnRegisterUser;
        private Button btnClose;
    }
}