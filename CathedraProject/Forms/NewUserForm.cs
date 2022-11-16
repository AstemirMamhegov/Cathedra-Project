using CathedraProject.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraProject.Forms
{
    public partial class NewUserForm : Form
    {
        private User user;
        private bool change = false;

        public NewUserForm(User user = null)
        {
            InitializeComponent();

            if (user != null)
            {
                this.user = user;

                txtBxLogin.Text = user.Login;
                checkBox1.Checked = user.IsAdmin;
                txtBxPassword.Text = user.Password;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (user == null)
                user = new User();

            user.Login = txtBxLogin.Text;
            if (change)
                user.Password = Helper.GetHash(txtBxPassword.Text);
            user.IsAdmin = checkBox1.Checked;

            DBController.Instance.Update(user);
            DialogResult = DialogResult.OK;
        }

        private void txtBxPassword_TextChanged(object sender, EventArgs e)
        {
            change = true;
        }
    }
}
