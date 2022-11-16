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
    public partial class NewScienceWorkForm : Form
    {
        public TeacherScienceWork ScienceWork { get; private set; }

        public NewScienceWorkForm(TeacherScienceWork work = null)
        {
            InitializeComponent();

            if (work != null)
            {
                ScienceWork = work;
                txtBxName.Text = work.Name;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ScienceWork == null)
                ScienceWork = new TeacherScienceWork();

            ScienceWork.Name = txtBxName.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
