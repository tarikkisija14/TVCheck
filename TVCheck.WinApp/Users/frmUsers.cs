using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVCheck.Data;
using TVCheck.Infrastructure;

namespace TVCheck.WinApp.Users
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
            dgvUsers.AutoGenerateColumns = false;
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers(List<User> users = null)
        {
            dgvUsers.DataSource = null;
            dgvUsers.DataSource = users ?? InMemoryDB.Users;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (new frmUsersAddEdit().ShowDialog() == DialogResult.OK)
            {

               LoadUsers();

            }
        }
    }
}
