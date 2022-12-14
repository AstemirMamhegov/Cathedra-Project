using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CathedraProject
{
    public partial class CountriesForm : Form
    {
        public CountriesForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = DBController.Instance.Countries;
        }

        private void CountriesForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewCountryForm form = new NewCountryForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Country country = dataGridView1.SelectedRows[0].DataBoundItem as Country;

                NewCountryForm form = new NewCountryForm(country);
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
                Country country = dataGridView1.SelectedRows[0].DataBoundItem as Country;

                try
                {
                    DBController.Instance.Remove(country);
                    UpdateGrid();
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show("Невозможно удалить объект. Так как он используется");
                }
            }
        }
    }
}
