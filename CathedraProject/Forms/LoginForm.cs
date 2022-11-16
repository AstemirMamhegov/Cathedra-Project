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

namespace CathedraProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (DBController.Instance.Users.Count > 0)
            {
                string login = txtBxLogin.Text;
                string password = Helper.GetHash(txtBxPassword.Text);

                User user = DBController.Instance.Users.FirstOrDefault(t => t.Login == login && t.Password == password);
                if (user == null)
                    MessageBox.Show("Неверный логин или пароль");
                else
                {
                    ApplicationHelper.Instance.IsAdmin = user.IsAdmin;

                    ShowMainForm();
                }
            }
            else
            {
                ApplicationHelper.Instance.IsAdmin = true;

                ShowMainForm();
            }
        }

        private void ShowMainForm()
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            Hide();
            adminForm.FormClosed += AdminForm_FormClosed;
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Close();
        }
    }
}
