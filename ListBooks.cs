using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibrariesProject
{
    public partial class ListBooks : UserControl
    {
        public ListBooks()
        {
            InitializeComponent();
            bind_data();
        }

        SqlConnection comn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=dataBooks;Integrated Security=True");

        private void bind_data()
        {
            SqlCommand cmd = new SqlCommand("SELECT idBuku, judulBuku AS JudulBuku, namaPenerbit AS NamaPenerbit, status AS Status, kategori AS Kategori, gambar AS Gambar, tahunDiterbitkan AS TahunDiterbitkan, tanggalPeminjaman, tanggalPengembalian FROM dataBooks WHERE status = 'Dipinjam'", comn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKembalikan_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedBookID = dataGridView1.SelectedRows[0].Cells["idBuku"].Value.ToString();

                SqlCommand updateCmd = new SqlCommand("UPDATE dataBooks SET status='Tersedia', tanggalPeminjaman=NULL, tanggalPengembalian=NULL WHERE idBuku=@idBuku", comn);
                updateCmd.Parameters.AddWithValue("@idBuku", selectedBookID);
                comn.Open();
                updateCmd.ExecuteNonQuery();
                comn.Close();

                MessageBox.Show("Buku telah berhasil dikembalikan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bind_data();
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dikembalikan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlCommand cmd1 = new SqlCommand("SELECT idBuku, judulBuku AS JudulBuku, namaPenerbit AS NamaPenerbit, status AS Status, kategori AS Kategori, gambar AS Gambar, tahunDiterbitkan AS TahunDiterbitkan FROM dataBooks WHERE judulBuku LIKE @judulBuku + '%'", comn);
            cmd1.Parameters.AddWithValue("@judulBuku", textBoxSearch.Text);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd1;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Poppins", 11);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                textBoxJudul.Text = selectedRow.Cells["JudulBuku"].Value.ToString();

                if (!Convert.IsDBNull(selectedRow.Cells["tanggalPeminjaman"].Value))
                {
                    dateTimePicker1.Value = Convert.ToDateTime(selectedRow.Cells["tanggalPeminjaman"].Value);
                }
                else
                {
                    dateTimePicker1.Value = DateTimePicker.MinimumDateTime;
                }

                if (!Convert.IsDBNull(selectedRow.Cells["tanggalPengembalian"].Value))
                {
                    dateTimePicker2.Value = Convert.ToDateTime(selectedRow.Cells["tanggalPengembalian"].Value);
                }

                if (selectedRow.Cells["Gambar"].Value != null)
                {
                    byte[] imageData = (byte[])selectedRow.Cells["Gambar"].Value;
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        pictureBoxPreview.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pictureBoxPreview.Image = null; // Atur pictureBoxPreview menjadi null jika tidak ada gambar yang tersedia
                }
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
            e.Graphics.DrawImage(imagebmp, 200, 200);
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {

        }
    }
}
