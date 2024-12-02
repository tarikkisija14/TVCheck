using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;
using TvCheck.WinApp.Helpers;
using TVCheck.Data;
using TVCheck.Infrastructure;
using TVCheck.WinApp;
using TVCheck.WinApp.Helpers;




namespace TvCheck.WinApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            if (ValidEntry())
            {
                foreach (var user in InMemoryDB.Users)
                {
                    if (user.UserName == username && user.Password == password)
                    {
                        if (user.isActive)
                        {
                            Hide();
                            if (new frmMain().ShowDialog() == DialogResult.OK)
                            {
                                Show();
                            }
                            else
                                Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show(Resources.Get(Keyss.NotActive));
                            return;
                        }
                    }
                    

                }
                MessageBox.Show(Resources.Get(Keyss.UsernameOrPasswordNotValid),
                     Resources.Get(Keyss.Warning),
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
            }
           

        }

        private bool ValidEntry()
        {
            return Validatorr.ValidateEntry(txtUsername, err, Resources.Get(Keyss.RequiredField)) &&
                Validatorr.ValidateEntry(txtPassword, err, Resources.Get(Keyss.RequiredField));
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var register=new frmRegistration();
            register.Show();
        }
    }
}
