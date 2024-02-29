using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LibraryProject
{
    public partial class LoginAdmin : Form
    {
        public LoginAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=loginLibrary;Integrated Security=True");
            conn.Open();
            string query = "SELECT COUNT(*) FROM loginLibrary WHERE email=@email AND password=@password";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
            cmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            if (count > 0)
            {
                MessageBox.Show("Login Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DashboardAdmin dashboardForm = new DashboardAdmin();
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

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Register"] as LoginUser) == null)
            {
                LoginUser baru = new LoginUser();
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
