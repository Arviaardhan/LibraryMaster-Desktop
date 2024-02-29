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

namespace LibraryProject
{
    public partial class LoginUser : Form
    {
        public LoginUser()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=loginUser;Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM loginUser WHERE email=@email AND password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardUser dashboardForm = new DashboardUser();
                dashboardForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Error Login", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = cbShowPassword.Checked ? '\0' : '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Login"] as LoginAdmin) == null)
            {
                LoginAdmin baru = new LoginAdmin();
                baru.Show();
                this.Hide();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin keluar?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Menutup aplikasi jika pengguna memilih "Yes"
                Application.Exit();
            }
        }
    }
}
