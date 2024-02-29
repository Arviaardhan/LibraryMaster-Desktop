namespace LibrariesProject
{
    partial class AddBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBooks));
            btnEdit = new Button();
            btnDelete = new Button();
            btnBrowse = new Button();
            textBoxID = new TextBox();
            label8 = new Label();
            btnInsert = new Button();
            pictureBox1 = new PictureBox();
            comboBoxStatus = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxJudulBuku = new TextBox();
            textBoxPenulis = new TextBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            groupBox1 = new GroupBox();
            btnPrintPdf = new Button();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Goldenrod;
            btnEdit.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.White;
            btnEdit.Location = new Point(532, 526);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 42);
            btnEdit.TabIndex = 42;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Firebrick;
            btnDelete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(380, 526);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 42);
            btnDelete.TabIndex = 41;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = Color.Gray;
            btnBrowse.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBrowse.ForeColor = Color.White;
            btnBrowse.Location = new Point(857, 262);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 49);
            btnBrowse.TabIndex = 40;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // textBoxID
            // 
            textBoxID.BackColor = SystemColors.WindowFrame;
            textBoxID.BorderStyle = BorderStyle.None;
            textBoxID.ForeColor = Color.White;
            textBoxID.Location = new Point(342, 29);
            textBoxID.Name = "textBoxID";
            textBoxID.ReadOnly = true;
            textBoxID.Size = new Size(288, 24);
            textBoxID.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(72, 32);
            label8.Name = "label8";
            label8.Size = new Size(99, 28);
            label8.TabIndex = 38;
            label8.Text = "ID Buku";
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.ForestGreen;
            btnInsert.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnInsert.ForeColor = Color.White;
            btnInsert.Location = new Point(232, 526);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(112, 42);
            btnInsert.TabIndex = 37;
            btnInsert.Text = "INSERT";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(857, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 161);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Items.AddRange(new object[] { "", "Tersedia", "Dipinjam" });
            comboBoxStatus.Location = new Point(342, 370);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(248, 33);
            comboBoxStatus.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(342, 220);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(424, 31);
            dateTimePicker1.TabIndex = 32;
            // 
            // textBoxJudulBuku
            // 
            textBoxJudulBuku.BorderStyle = BorderStyle.FixedSingle;
            textBoxJudulBuku.Location = new Point(342, 153);
            textBoxJudulBuku.Name = "textBoxJudulBuku";
            textBoxJudulBuku.Size = new Size(288, 31);
            textBoxJudulBuku.TabIndex = 31;
            // 
            // textBoxPenulis
            // 
            textBoxPenulis.BorderStyle = BorderStyle.FixedSingle;
            textBoxPenulis.Location = new Point(342, 91);
            textBoxPenulis.Name = "textBoxPenulis";
            textBoxPenulis.Size = new Size(288, 31);
            textBoxPenulis.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(43, 590);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1093, 281);
            dataGridView1.TabIndex = 29;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(857, 32);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(174, 28);
            label7.TabIndex = 28;
            label7.Text = "Gambar Buku";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(72, 373);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(79, 28);
            label6.TabIndex = 27;
            label6.Text = "Status";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(72, 295);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(110, 28);
            label4.TabIndex = 25;
            label4.Text = "Kategori";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 226);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(213, 28);
            label3.TabIndex = 24;
            label3.Text = "Tahun Diterbitkan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 28);
            label2.TabIndex = 23;
            label2.Text = "Judul Buku";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 93);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 22;
            label1.Text = "Nama Penulis";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(28, 30);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(93, 29);
            checkBox1.TabIndex = 43;
            checkBox1.Text = "NOVEL";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(143, 30);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(155, 29);
            checkBox2.TabIndex = 44;
            checkBox2.Text = "ENSIKLOPEDIA";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(335, 27);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(92, 29);
            checkBox3.TabIndex = 45;
            checkBox3.Text = "KOMIK";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox3);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(342, 272);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 77);
            groupBox1.TabIndex = 46;
            groupBox1.TabStop = false;
            // 
            // btnPrintPdf
            // 
            btnPrintPdf.BackColor = Color.LightSeaGreen;
            btnPrintPdf.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintPdf.ForeColor = Color.White;
            btnPrintPdf.Location = new Point(677, 525);
            btnPrintPdf.Name = "btnPrintPdf";
            btnPrintPdf.Size = new Size(163, 43);
            btnPrintPdf.TabIndex = 47;
            btnPrintPdf.Text = "Print PDF";
            btnPrintPdf.UseVisualStyleBackColor = false;
            btnPrintPdf.Click += btnPrintPdf_Click;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // AddBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPrintPdf);
            Controls.Add(groupBox1);
            Controls.Add(btnEdit);
            Controls.Add(btnDelete);
            Controls.Add(btnBrowse);
            Controls.Add(textBoxID);
            Controls.Add(label8);
            Controls.Add(btnInsert);
            Controls.Add(pictureBox1);
            Controls.Add(comboBoxStatus);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxJudulBuku);
            Controls.Add(textBoxPenulis);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddBooks";
            Size = new Size(1178, 900);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEdit;
        private Button btnDelete;
        private Button btnBrowse;
        private TextBox textBoxID;
        private Label label8;
        private Button btnInsert;
        private PictureBox pictureBox1;
        private ComboBox comboBoxStatus;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxJudulBuku;
        private TextBox textBoxPenulis;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private GroupBox groupBox1;
        private Button btnPrintPdf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
