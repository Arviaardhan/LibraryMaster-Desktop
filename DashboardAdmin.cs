using LibrariesProject;
using Microsoft.VisualBasic.Logging;
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
    public partial class DashboardAdmin : Form
    {
        public String Email { get; set; }
        public String Password { get; set; }

        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.dashboardPanel.Controls.Clear();
            AddBooks databooks = new AddBooks();
            this.dashboardPanel.Controls.Add(databooks);
            databooks.Show();
        }

        private void btnAddBooks_Click(object sender, EventArgs e)
        {
            this.dashboardPanel.Controls.Clear();
            AddBooks databooks = new AddBooks();
            this.dashboardPanel.Controls.Add(databooks);
            databooks.Show();
        }

        private void dashboardPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDataUser_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin Log Out?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
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
