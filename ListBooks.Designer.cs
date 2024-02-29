namespace LibrariesProject
{
    partial class ListBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListBooks));
            dataGridView1 = new DataGridView();
            btnKembalikan = new Button();
            btnSearch = new Button();
            textBoxSearch = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            textBoxJudul = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument2 = new System.Drawing.Printing.PrintDocument();
            label4 = new Label();
            pictureBoxPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
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
            // btnKembalikan
            // 
            btnKembalikan.BackColor = Color.ForestGreen;
            btnKembalikan.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnKembalikan.ForeColor = Color.White;
            btnKembalikan.Location = new Point(464, 749);
            btnKembalikan.Name = "btnKembalikan";
            btnKembalikan.Size = new Size(163, 43);
            btnKembalikan.TabIndex = 1;
            btnKembalikan.Text = "KEMBALIKAN";
            btnKembalikan.UseVisualStyleBackColor = false;
            btnKembalikan.Click += btnKembalikan_Click;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.Font = new Font("Century Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(992, 50);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(112, 47);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.BorderStyle = BorderStyle.FixedSingle;
            textBoxSearch.Location = new Point(751, 59);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(215, 31);
            textBoxSearch.TabIndex = 3;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(476, 628);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(350, 32);
            dateTimePicker2.TabIndex = 14;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(476, 549);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(350, 32);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // textBoxJudul
            // 
            textBoxJudul.BackColor = Color.White;
            textBoxJudul.BorderStyle = BorderStyle.FixedSingle;
            textBoxJudul.Location = new Point(476, 467);
            textBoxJudul.Name = "textBoxJudul";
            textBoxJudul.ReadOnly = true;
            textBoxJudul.Size = new Size(288, 31);
            textBoxJudul.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(93, 631);
            label3.Name = "label3";
            label3.Size = new Size(283, 28);
            label3.TabIndex = 11;
            label3.Text = "Tanggal Pengembalian";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(93, 552);
            label2.Name = "label2";
            label2.Size = new Size(259, 28);
            label2.TabIndex = 10;
            label2.Text = "Tanggal Peminjaman";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(93, 470);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 9;
            label1.Text = "Judul Buku";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(940, 470);
            label4.Name = "label4";
            label4.Size = new Size(164, 28);
            label4.TabIndex = 15;
            label4.Text = "Preview Buku";
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.Location = new Point(920, 520);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(211, 176);
            pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPreview.TabIndex = 16;
            pictureBoxPreview.TabStop = false;
            pictureBoxPreview.Click += pictureBoxPreview_Click;
            // 
            // ListBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(pictureBoxPreview);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxJudul);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(btnKembalikan);
            Controls.Add(dataGridView1);
            Name = "ListBooks";
            Size = new Size(1178, 900);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnKembalikan;
        private Button btnSearch;
        private TextBox textBoxSearch;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox textBoxJudul;
        private Label label3;
        private Label label2;
        private Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private Label label4;
        private PictureBox pictureBoxPreview;
    }
}
