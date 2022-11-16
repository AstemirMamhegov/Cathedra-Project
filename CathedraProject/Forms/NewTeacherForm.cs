using CathedraProject.Forms;
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
    public partial class NewTeacherForm : Form
    {
        private Address address;
        private Teacher teacher;
        private List<TeacherSubject> subjects = new List<TeacherSubject>();
        private List<Qualification> qualifications = new List<Qualification>();
        private List<TeacherScienceWork> scienceWorks = new List<TeacherScienceWork>();

        public NewTeacherForm(Teacher teacher = null)
        {
            InitializeComponent();

            comboBox1.DataSource = DBController.Instance.Posts;

            if (teacher != null)
            {
                this.teacher = teacher;
                address = teacher.Address;

                txtBxAddress.Text = address?.ToString();
                txtBxEmail.Text = teacher.Email;
                txtBxFirstName.Text = teacher.FirstName;
                txtBxLastName.Text = teacher.LastName;
                txtBxMiddleName.Text = teacher.MiddleName;
                dateTimePicker1.Value = teacher.Birthday;
                maskedTextBox1.Text = teacher.Phone;
                numericUpDown1.Value = (decimal)teacher.Rate;
                comboBox1.SelectedItem = teacher.Post;
                numericUpDown2.Value = teacher.Experience;
                txtBxAcademicDegree.Text = teacher.AcademicDegree;
                txtBxAcademicRank.Text = teacher.AcademicRank;
                subjects = teacher.TeacherSubjects;
                qualifications = teacher.Qualifications;
                scienceWorks = teacher.Works;

                UpdateSubjects();
                UpdateQualifications();
                UpdateScienceWorks();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddressForm form = new AddressForm(address);
            if (form.ShowDialog() == DialogResult.OK)
            {
                address = form.Address;

                txtBxAddress.Text = address.ToString();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (teacher == null)
                teacher = new Teacher();

            teacher.LastName = txtBxLastName.Text;
            teacher.MiddleName = txtBxMiddleName.Text;
            teacher.FirstName = txtBxFirstName.Text;
            teacher.Address = address;
            teacher.Birthday = dateTimePicker1.Value;
            teacher.Email = txtBxEmail.Text;
            teacher.Phone = maskedTextBox1.Text;
            teacher.Post = comboBox1.SelectedItem as Post;
            teacher.Rate = (double)numericUpDown1.Value;
            teacher.Experience = (int)numericUpDown2.Value;
            teacher.AcademicDegree = txtBxAcademicDegree.Text;
            teacher.AcademicRank = txtBxAcademicRank.Text;
            teacher.TeacherSubjects = subjects;
            teacher.Qualifications = qualifications;
            teacher.Works = scienceWorks;

            DBController.Instance.Update(teacher);
            DialogResult = DialogResult.OK;
        }

        private void NewTeacherForm_Load(object sender, EventArgs e)
        {

        }

        private void UpdateSubjects()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = subjects;
        }

        private void UpdateQualifications()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = qualifications;
        }

        private void UpdateScienceWorks()
        {
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = scienceWorks;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            NewTeacherSubjectForm form = new NewTeacherSubjectForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                subjects.Add(form.Subject);

                UpdateSubjects();
            }
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TeacherSubject teacherSubject = dataGridView1.SelectedRows[0].DataBoundItem as TeacherSubject;

                NewTeacherSubjectForm form = new NewTeacherSubjectForm(teacherSubject);
                if (form.ShowDialog() == DialogResult.OK)
                    UpdateSubjects();
            }
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TeacherSubject teacherSubject = dataGridView1.SelectedRows[0].DataBoundItem as TeacherSubject;
                subjects.Remove(teacherSubject);
                UpdateSubjects();
            }
        }

        private void btnAddQualif_Click(object sender, EventArgs e)
        {
            TeacherQualifForm form = new TeacherQualifForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                qualifications.Add(form.Qualification);

                UpdateQualifications();
            }
        }

        private void btnEditQualif_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Qualification qualification = dataGridView2.SelectedRows[0].DataBoundItem as Qualification;

                TeacherQualifForm form = new TeacherQualifForm(qualification);
                if (form.ShowDialog() == DialogResult.OK)
                    UpdateQualifications();
            }
        }

        private void btnDeleteQualif_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                Qualification qualification = dataGridView2.SelectedRows[0].DataBoundItem as Qualification;
                qualifications.Remove(qualification);
                UpdateQualifications();
            }
        }

        private void btnAddScienceWork_Click(object sender, EventArgs e)
        {
            NewScienceWorkForm form = new NewScienceWorkForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                scienceWorks.Add(form.ScienceWork);

                UpdateScienceWorks();
            }
        }

        private void btnEditScienceWork_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                TeacherScienceWork scienceWork = dataGridView3.SelectedRows[0].DataBoundItem as TeacherScienceWork;

                NewScienceWorkForm form = new NewScienceWorkForm(scienceWork);
                if (form.ShowDialog() == DialogResult.OK)
                    UpdateScienceWorks();
            }
        }

        private void btnDeleteScienceWork_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                TeacherScienceWork scienceWork = dataGridView3.SelectedRows[0].DataBoundItem as TeacherScienceWork;
                scienceWorks.Remove(scienceWork);
                UpdateScienceWorks();
            }
        }
    }
}
