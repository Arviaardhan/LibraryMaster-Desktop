using LibrariesProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryProject
{
    public partial class DashboardUser : Form
    {
        public DashboardUser()
        {
            InitializeComponent();
        }

        private void btnDataBooks_Click(object sender, EventArgs e)
        {
            this.dashboardPanel.Controls.Clear();
            DataBooks databooks = new DataBooks();
            this.dashboardPanel.Controls.Add(databooks);
            databooks.Show();
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardUser_Load(object sender, EventArgs e)
        {
            this.dashboardPanel.Controls.Clear();
            DataBooks databooks = new DataBooks();
            this.dashboardPanel.Controls.Add(databooks);
            databooks.Show();
        }

        private void btnListBook_Click(object sender, EventArgs e)
        {
            this.dashboardPanel.Controls.Clear();
            ListBooks databooks = new ListBooks();
            this.dashboardPanel.Controls.Add(databooks);
            databooks.Show();
        }

        private void sidePanel1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin Log Out?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
