using Microsoft.VisualBasic.Logging;
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
    public partial class RegisterUser : Form
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection("Data Source=LOQ-RV;Initial Catalog=loginLibrary;Integrated Security=True"))
            {
                conn.Open();

                SqlCommand checkEmailCmd = new SqlCommand("SELECT COUNT(*) FROM loginLibrary WHERE email = @email", conn);
                checkEmailCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                int emailCount = (int)checkEmailCmd.ExecuteScalar();

                if (emailCount > 0)
                {
                    MessageBox.Show("Email sudah digunakan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand insertCmd = new SqlCommand("INSERT INTO loginLibrary (email, password) VALUES (@email, @password)", conn);
                    insertCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    insertCmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    insertCmd.ExecuteNonQuery();

                    MessageBox.Show("Registrasi berhasil.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    textBoxEmail.Text = "";
                    textBoxPassword.Text = "";
                    this.Hide();

                    LoginUser loginForm = new LoginUser();
                    loginForm.Show();
                }
            }
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Register"] as LoginAdmin) == null)
            {
                LoginAdmin baru = new LoginAdmin();
                baru.Show();
                this.Hide();
            }
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
    }
}
