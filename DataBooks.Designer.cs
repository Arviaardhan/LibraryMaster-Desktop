namespace LibrariesProject
{
    partial class DataBooks
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
            dataGridView1 = new DataGridView();
            textBoxSearch = new TextBox();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxJudul = new TextBox();
            dateTimePickerPeminjaman = new DateTimePicker();
            dateTimePickerPengembalian = new DateTimePicker();
            btnPinjam = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 124);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(1093, 281);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(751, 59);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(215, 31);
            textBoxSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(992, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 47);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(149, 489);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 3;
            label1.Text = "Judul Buku";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(149, 571);
            label2.Name = "label2";
            label2.Size = new Size(259, 28);
            label2.TabIndex = 4;
            label2.Text = "Tanggal Peminjaman";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(149, 650);
            label3.Name = "label3";
            label3.Size = new Size(283, 28);
            label3.TabIndex = 5;
            label3.Text = "Tanggal Pengembalian";
            // 
            // textBoxJudul
            // 
            textBoxJudul.BackColor = Color.White;
            textBoxJudul.BorderStyle = BorderStyle.FixedSingle;
            textBoxJudul.Location = new Point(532, 486);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.ReadOnly = true;
            textBoxJudul.Size = new Size(288, 31);
            textBoxJudul.TabIndex = 6;
            // 
            // dateTimePickerPeminjaman
            // 
            dateTimePickerPeminjaman.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerPeminjaman.Location = new Point(532, 568);
            dateTimePickerPeminjaman.Name = "dateTimePickerPeminjaman";
            dateTimePickerPeminjaman.Size = new Size(350, 32);
            dateTimePickerPeminjaman.TabIndex = 7;
            dateTimePickerPeminjaman.ValueChanged += dateTimePickerPeminjaman_ValueChanged;
            // 
            // dateTimePickerPengembalian
            // 
            dateTimePickerPengembalian.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePickerPengembalian.Location = new Point(532, 647);
            dateTimePickerPengembalian.Name = "dateTimePickerPengembalian";
            dateTimePickerPengembalian.Size = new Size(350, 32);
            dateTimePickerPengembalian.TabIndex = 8;
            dateTimePickerPengembalian.ValueChanged += dateTimePickerPengembalian_ValueChanged;
            // 
            // btnPinjam
            // 
            btnPinjam.BackColor = Color.Teal;
            btnPinjam.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnPinjam.ForeColor = Color.White;
            btnPinjam.Location = new Point(480, 743);
            btnPinjam.Name = "btnPinjam";
            btnPinjam.Size = new Size(112, 47);
            btnPinjam.TabIndex = 9;
            btnPinjam.Text = "PINJAM";
            btnPinjam.UseVisualStyleBackColor = false;
            btnPinjam.Click += btnPinjam_Click;
            // 
            // DataBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnPinjam);
            Controls.Add(dateTimePickerPengembalian);
            Controls.Add(dateTimePickerPeminjaman);
            Controls.Add(textBoxJudul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(dataGridView1);
            Name = "DataBooks";
            Size = new Size(1178, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBoxSearch;
        private Button btnSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxJudul;
        private DateTimePicker dateTimePickerPeminjaman;
        private DateTimePicker dateTimePickerPengembalian;
        private Button btnPinjam;
    }
}
