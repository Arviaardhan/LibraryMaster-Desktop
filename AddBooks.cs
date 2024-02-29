using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrariesProject
{
    public partial class AddBooks : UserControl
    {
        public AddBooks()
        {
            InitializeComponent();
            bind_data();
        }

        SqlConnection comn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=dataBooks;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT idBuku, judulBuku AS JudulBuku, namaPenerbit AS NamaPenerbit, status AS Status, kategori AS Kategori, gambar AS Gambar, tahunDiterbitkan AS TahunDiterbitkan FROM dataBooks", comn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            dt.Clear();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11);
        }

        private void ClearInputControls()
        {
            textBoxPenulis.Text = "";
            textBoxJudulBuku.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBoxStatus.Text = "";
            pictureBox1.Image = null;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            bool isImageInserted = pictureBox1.Image != null;

            if (string.IsNullOrWhiteSpace(textBoxPenulis.Text) ||
                string.IsNullOrWhiteSpace(textBoxJudulBuku.Text) ||
                string.IsNullOrWhiteSpace(dateTimePicker1.Text) ||
                /*groupBox1.Controls.OfType<RadioButton>().Count(r => r.Checked) == 0 ||*/
                string.IsNullOrWhiteSpace(comboBoxStatus.Text) ||
                !isImageInserted)
            {
                MessageBox.Show("Harap lengkapi semua kolom.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            byte[] imageBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
                imageBytes = ms.ToArray();
            }

            string selectedCategories = "";

            if (checkBox1.Checked)
            {
                selectedCategories += checkBox1.Text + ", ";
            }

            if (checkBox2.Checked)
            {
                selectedCategories += checkBox2.Text + ", ";
            }

            if (checkBox3.Checked)
            {
                selectedCategories += checkBox3.Text + ", ";
            }

            // Cek apakah ada kategori yang dipilih
            if (string.IsNullOrEmpty(selectedCategories))
            {
                MessageBox.Show("Harap pilih setidaknya satu kategori.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlCommand cmd2 = new SqlCommand("INSERT INTO dataBooks (judulBuku, namaPenerbit, status, kategori, gambar, tahunDiterbitkan) VALUES (@judulBuku, @namaPenerbit, @status, @kategori, @gambar, @tahunDiterbitkan)", comn);
            cmd2.Parameters.AddWithValue("@namaPenerbit", textBoxPenulis.Text);
            cmd2.Parameters.AddWithValue("@judulBuku", textBoxJudulBuku.Text);
            cmd2.Parameters.AddWithValue("@tahunDiterbitkan", dateTimePicker1.Text);
            cmd2.Parameters.AddWithValue("@kategori", selectedCategories);
            cmd2.Parameters.AddWithValue("@status", comboBoxStatus.Text);
            cmd2.Parameters.AddWithValue("@gambar", imageBytes);

            try
            {
                comn.Open();
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Data sudah tertambah.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bind_data();
                ClearInputControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                comn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0 && index < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBoxID.Text = selectedRow.Cells[0].Value.ToString();
                textBoxJudulBuku.Text = selectedRow.Cells[1].Value.ToString();
                textBoxPenulis.Text = selectedRow.Cells[2].Value.ToString();
                comboBoxStatus.Text = selectedRow.Cells[3].Value.ToString();
                string selectedCategory = selectedRow.Cells[4].Value.ToString();
                dateTimePicker1.Text = selectedRow.Cells[6].Value.ToString();

                if (selectedCategory.Contains(checkBox1.Text))
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }

                if (selectedCategory.Contains(checkBox2.Text))
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }

                if (selectedCategory.Contains(checkBox3.Text))
                {
                    checkBox3.Checked = true;
                }
                else
                {
                    checkBox3.Checked = false;
                }


                byte[] imageBytes = selectedRow.Cells[5].Value as byte[];
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                else
                {
                    pictureBox1.Image = null;
                    MessageBox.Show("Data yang dipilih kosong.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg; *.jpeg; *.png; *.bmp|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                SqlCommand cmd4 = new SqlCommand("DELETE FROM dataBooks WHERE idBuku=@idBuku", comn);
                cmd4.Parameters.AddWithValue("@idBuku", textBoxID.Text);
                comn.Open();
                cmd4.ExecuteNonQuery();
                comn.Close();
                bind_data();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string selectedCategories = "";

            // Menambahkan kategori ke variabel selectedCategories jika checkbox terkait dicentang
            if (checkBox1.Checked)
            {
                selectedCategories += checkBox1.Text + ", ";
            }

            if (checkBox2.Checked)
            {
                selectedCategories += checkBox2.Text + ", ";
            }

            if (checkBox3.Checked)
            {
                selectedCategories += checkBox3.Text + ", ";
            }

            SqlCommand cmd3 = new SqlCommand("UPDATE dataBooks SET judulBuku=@judulBuku, namaPenerbit=@namaPenerbit, status=@status, kategori=@kategori, tahunDiterbitkan=@tahunDiterbitkan WHERE idBuku=@idBuku", comn);
            cmd3.Parameters.AddWithValue("@judulBuku", textBoxJudulBuku.Text);
            cmd3.Parameters.AddWithValue("@namaPenerbit", textBoxPenulis.Text);
            cmd3.Parameters.AddWithValue("@status", comboBoxStatus.Text);
            cmd3.Parameters.AddWithValue("@kategori", selectedCategories);
            cmd3.Parameters.AddWithValue("@tahunDiterbitkan", dateTimePicker1.Text);
            cmd3.Parameters.AddWithValue("@idBuku", textBoxID.Text);

            try
            {
                comn.Open();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("Data sudah diperbarui.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bind_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                comn.Close();
            }
        }

        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap imagebmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(imagebmp, new Rectangle(0, 0, imagebmp.Width, imagebmp.Height));
            e.Graphics.DrawImage(imagebmp, 120, 20);
        }
    }
}
