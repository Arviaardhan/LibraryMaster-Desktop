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
    public partial class DataBooks : UserControl
    {
        public DataBooks()
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnPinjam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string selectedBookID = dataGridView1.SelectedRows[0].Cells["idBuku"].Value.ToString();

                DateTime tanggalPeminjaman = dateTimePickerPeminjaman.Value.Date;
                DateTime tanggalPengembalian = dateTimePickerPengembalian.Value.Date;

                SqlCommand cmd = new SqlCommand("UPDATE dataBooks SET status='Dipinjam', tanggalPeminjaman=@tanggalPeminjaman, tanggalPengembalian=@tanggalPengembalian WHERE idBuku=@idBuku", comn);
                cmd.Parameters.AddWithValue("@idBuku", selectedBookID);
                cmd.Parameters.AddWithValue("@tanggalPeminjaman", tanggalPeminjaman);
                cmd.Parameters.AddWithValue("@tanggalPengembalian", tanggalPengembalian);
                comn.Open();
                cmd.ExecuteNonQuery();
                comn.Close();

                MessageBox.Show("Buku telah berhasil dipinjam.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                bind_data();
            }
            else
            {
                MessageBox.Show("Pilih buku yang ingin dipinjam.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index;
            index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBoxJudul.Text = selectedRow.Cells[1].Value.ToString();
        }

        private void dateTimePickerPeminjaman_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePickerPengembalian_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
