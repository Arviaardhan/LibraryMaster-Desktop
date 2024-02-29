namespace LibraryProject
{
    partial class DashboardUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardUser));
            panel1 = new Panel();
            btnListBook = new Button();
            pictureBox3 = new PictureBox();
            btnDataBooks = new Button();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            dashboardPanel = new Panel();
            btnClose = new Button();
            btnLogOut = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(btnClose);
            panel1.Controls.Add(btnListBook);
            panel1.Controls.Add(btnLogOut);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(btnDataBooks);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 900);
            panel1.TabIndex = 0;
            // 
            // btnListBook
            // 
            btnListBook.FlatAppearance.BorderSize = 0;
            btnListBook.FlatStyle = FlatStyle.Flat;
            btnListBook.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnListBook.ForeColor = Color.White;
            btnListBook.Location = new Point(126, 510);
            btnListBook.Name = "btnListBook";
            btnListBook.Size = new Size(191, 70);
            btnListBook.TabIndex = 9;
            btnListBook.Text = "List Books";
            btnListBook.UseVisualStyleBackColor = true;
            btnListBook.Click += btnListBook_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(55, 523);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(44, 44);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // btnDataBooks
            // 
            btnDataBooks.FlatAppearance.BorderSize = 0;
            btnDataBooks.FlatStyle = FlatStyle.Flat;
            btnDataBooks.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnDataBooks.ForeColor = Color.White;
            btnDataBooks.Location = new Point(126, 391);
            btnDataBooks.Name = "btnDataBooks";
            btnDataBooks.Size = new Size(191, 70);
            btnDataBooks.TabIndex = 6;
            btnDataBooks.Text = "Data Books";
            btnDataBooks.UseVisualStyleBackColor = true;
            btnDataBooks.Click += btnDataBooks_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 271);
            label1.Name = "label1";
            label1.Size = new Size(212, 37);
            label1.TabIndex = 3;
            label1.Text = "LibraryMaster";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(55, 406);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 258);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // dashboardPanel
            // 
            dashboardPanel.Dock = DockStyle.Fill;
            dashboardPanel.Location = new Point(432, 0);
            dashboardPanel.Name = "dashboardPanel";
            dashboardPanel.Size = new Size(1178, 900);
            dashboardPanel.TabIndex = 1;
            dashboardPanel.Paint += dashboardPanel_Paint;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.FlatAppearance.BorderSize = 3;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(126, 794);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(191, 70);
            btnClose.TabIndex = 7;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Red;
            btnLogOut.FlatAppearance.BorderSize = 3;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Century Gothic", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = Color.White;
            btnLogOut.Location = new Point(126, 698);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(191, 70);
            btnLogOut.TabIndex = 6;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // DashboardUser
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1610, 900);
            Controls.Add(dashboardPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DashboardUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardUser";
            Load += DashboardUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnDataBooks;
        private PictureBox pictureBox2;
        private Panel dashboardPanel;
        private PictureBox pictureBox3;
        private Button btnListBook;
        private Button btnClose;
        private Button btnLogOut;
    }
}