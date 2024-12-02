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

namespace TVCheck.WinApp
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void GenerateData()
        {
            var firstname = txtFirstName.Text.ToLower();
            var lastname = txtLastName.Text.ToLower();

            txtUsername.Text = $"{firstname}.{lastname}";

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            GenerateData();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                var newuser = new User()
                {
                    isActive = true,
                    Email = txtEmail.Text,
                    ID = InMemoryDB.Users.Count + 1,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Password = txtPassword.Text,
                    UserName = txtUsername.Text
                };
                InMemoryDB.Users.Add(newuser);
                MessageBox.Show(Resources.Get(Keyss.UserAddSuccess),
                    Resources.Get(Keyss.Information),
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private bool ValidateData()
        {
            return Validatorr.ValidateEntry(txtFirstName, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtLastName, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtPassword, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtUsername, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtEmail, err, Resources.Get(Keyss.RequiredField));
        }
    }
}
