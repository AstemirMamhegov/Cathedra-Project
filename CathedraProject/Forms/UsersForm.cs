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
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Users;
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewUserForm form = new NewUserForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                User user = dataGridView1.SelectedRows[0].DataBoundItem as User;

                NewUserForm form = new NewUserForm(user);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    UpdateGrid();
                }
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                User user = dataGridView1.SelectedRows[0].DataBoundItem as User;

                DBController.Instance.Remove(user);
                UpdateGrid();
            }
        }
    }
}
