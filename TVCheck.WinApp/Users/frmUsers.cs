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
using TVCheck.WinApp.Helpers;

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
            var choosenUser=dgvUsers.GetRow() as User;

            Form form = null;

            form = new frmUsersAddEdit(choosenUser);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadUsers();
            }

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

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadUsers(InMemoryDB.Users.Where(FilterUsers).ToList());
        }

        private bool FilterUsers(User user)
        {
            var filter = txtSearch.Text.ToLower();

            return user.UserName.ToLower().Contains(filter);


        }
    }
}
