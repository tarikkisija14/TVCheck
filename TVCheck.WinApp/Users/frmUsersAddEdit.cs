using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TvCheck.WinApp.Helpers;
using TVCheck.Data;
using TVCheck.Infrastructure;
using TVCheck.WinApp.Helpers;

namespace TVCheck.WinApp.Users
{
    public partial class frmUsersAddEdit : Form
    {
        public frmUsersAddEdit()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frmUsersAddEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateEntry())
            {
                User user = new User()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    UserName = txtUsername.Text,
                    Password = txtPassword.Text,
                    RegistrationDate = dtpRegDate.Value,
                    isActive = cbIsActive.Checked,
                    Avatar = pbAvatar.Image
                };
                InMemoryDB.Users.Add(user);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateEntry()
        {
            return Validatorr.ValidateEntry(txtUsername, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtPassword, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtEmail, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtFirstName, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtLastName, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(pbAvatar, err, Resources.Get(Keyss.RequiredField));
        }

        private void btnLoadAvatar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pbAvatar.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            GenerateUsername();
        }

        private void GenerateUsername()
        {
            txtUsername.Text = $"{txtFirstName.Text}.{txtLastName.Text}";
        }

       
    }
}
