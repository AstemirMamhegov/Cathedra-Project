using CathedraProject.Services;
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
    public partial class TeachersForm : Form
    {
        public TeachersForm()
        {
            InitializeComponent();
        }
        private void UpdateGrid()
        {
            var teachers = DBController.Instance.Teachers;

            if (comboBox1.Text != "Все")
            {
                Subject subject = comboBox1.SelectedItem as Subject;

                teachers = teachers.Where(t => t.TeacherSubjects.Any(p => p.Subject == subject)).ToList();
            }
            if (comboBox2.Text != "Все")
            {
                Post post = comboBox2.SelectedItem as Post;
                teachers = teachers.Where(t => t.Post == post).ToList();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = teachers;
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTeacherForm form = new NewTeacherForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                UpdateGrid();
            }
        }

        private void TeachersForm_Load(object sender, EventArgs e)
        {
           

            comboBox1.Items.Add("Все");
            comboBox1.Items.AddRange(DBController.Instance.Subjects.ToArray());
            comboBox1.SelectedIndex = 0;

            comboBox2.Items.Add("Все");
            comboBox2.Items.AddRange(DBController.Instance.Posts.ToArray());
            comboBox2.SelectedIndex = 0;

            UpdateGrid();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Teacher teacher = dataGridView1.SelectedRows[0].DataBoundItem as Teacher;

                NewTeacherForm form = new NewTeacherForm(teacher);
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

                Teacher teacher = dataGridView1.SelectedRows[0].DataBoundItem as Teacher;

                DBController.Instance.Remove(teacher);
                UpdateGrid();
            }
        }

        private void эксельToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                List<Teacher> teachers = (List<Teacher>)dataGridView1.DataSource;

                ExcelManager.ExportTeachers(saveFileDialog1.FileName, teachers);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}

