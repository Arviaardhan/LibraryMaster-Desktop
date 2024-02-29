using System.Data;
using System.Data.SqlClient;

namespace LibraryProject
{
    public partial class RegisterAdmin : Form
    {
        public RegisterAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterAdmin_Load(object sender, EventArgs e)
        {

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

                    LoginAdmin loginForm = new LoginAdmin();
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

        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms["Register"] as RegisterUser) == null)
            {
                RegisterUser baru = new RegisterUser();
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