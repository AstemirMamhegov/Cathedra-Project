namespace CathedraProject
{
    partial class NewTeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTeacherForm));
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtBxLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBxMiddleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBxAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.txtBxEducation = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnDeleteQualif = new System.Windows.Forms.Button();
            this.btnEditQualif = new System.Windows.Forms.Button();
            this.btnAddQualif = new System.Windows.Forms.Button();
            this.btnDeleteScienceWork = new System.Windows.Forms.Button();
            this.btnEditScienceWork = new System.Windows.Forms.Button();
            this.btnAddScienceWork = new System.Windows.Forms.Button();
            this.txtBxAcademicRank = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBxAcademicDegree = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherSubjectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDRegDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherScienceWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScienceWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(887, 700);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 36);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "ОК";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(997, 700);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 36);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtBxLastName
            // 
            this.txtBxLastName.Location = new System.Drawing.Point(189, 50);
            this.txtBxLastName.Name = "txtBxLastName";
            this.txtBxLastName.Size = new System.Drawing.Size(345, 26);
            this.txtBxLastName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Фамилия";
            // 
            // txtBxFirstName
            // 
            this.txtBxFirstName.Location = new System.Drawing.Point(189, 82);
            this.txtBxFirstName.Name = "txtBxFirstName";
            this.txtBxFirstName.Size = new System.Drawing.Size(345, 26);
            this.txtBxFirstName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Имя";
            // 
            // txtBxMiddleName
            // 
            this.txtBxMiddleName.Location = new System.Drawing.Point(189, 114);
            this.txtBxMiddleName.Name = "txtBxMiddleName";
            this.txtBxMiddleName.Size = new System.Drawing.Size(345, 26);
            this.txtBxMiddleName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Отчество";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(756, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(345, 26);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(593, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата рождения";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(756, 79);
            this.maskedTextBox1.Mask = "(999) 000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(345, 26);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(593, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Телефон";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Должность";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(189, 210);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(345, 27);
            this.comboBox1.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 246);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 25;
            this.label7.Text = "Ставка";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 2;
            this.numericUpDown1.Location = new System.Drawing.Point(189, 244);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(345, 26);
            this.numericUpDown1.TabIndex = 7;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(756, 114);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(345, 26);
            this.txtBxEmail.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(593, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Email";
            // 
            // txtBxAddress
            // 
            this.txtBxAddress.Location = new System.Drawing.Point(189, 146);
            this.txtBxAddress.Name = "txtBxAddress";
            this.txtBxAddress.ReadOnly = true;
            this.txtBxAddress.Size = new System.Drawing.Size(345, 26);
            this.txtBxAddress.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Адрес";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(540, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(42, 391);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(629, 287);
            this.tabControl1.TabIndex = 36;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnRemoveSubject);
            this.tabPage1.Controls.Add(this.btnEditSubject);
            this.tabPage1.Controls.Add(this.btnAddSubject);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(621, 255);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Предметы";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subjectDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherSubjectBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 184);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnDeleteQualif);
            this.tabPage2.Controls.Add(this.btnEditQualif);
            this.tabPage2.Controls.Add(this.btnAddQualif);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(621, 255);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Квалификация";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDRegDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.hoursDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.qualificationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(23, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(574, 184);
            this.dataGridView2.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDeleteScienceWork);
            this.tabPage3.Controls.Add(this.btnEditScienceWork);
            this.tabPage3.Controls.Add(this.btnAddScienceWork);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(621, 255);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Научные работы";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.teacherScienceWorkBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(22, 52);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(578, 184);
            this.dataGridView3.TabIndex = 4;
            // 
            // txtBxEducation
            // 
            this.txtBxEducation.Location = new System.Drawing.Point(756, 149);
            this.txtBxEducation.Multiline = true;
            this.txtBxEducation.Name = "txtBxEducation";
            this.txtBxEducation.Size = new System.Drawing.Size(345, 104);
            this.txtBxEducation.TabIndex = 75;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(593, 152);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 84);
            this.label17.TabIndex = 76;
            this.label17.Text = "Образование (какое учебное заведение было окончено, когда и где)";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(189, 276);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(345, 26);
            this.numericUpDown2.TabIndex = 77;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 19);
            this.label10.TabIndex = 78;
            this.label10.Text = "Стаж работы";
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.BackgroundImage = global::CathedraProject.Properties.Resources.delete;
            this.btnRemoveSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRemoveSubject.Location = new System.Drawing.Point(88, 17);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(30, 30);
            this.btnRemoveSubject.TabIndex = 3;
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.BackgroundImage = global::CathedraProject.Properties.Resources.edit3;
            this.btnEditSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditSubject.Location = new System.Drawing.Point(52, 17);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(30, 30);
            this.btnEditSubject.TabIndex = 2;
            this.btnEditSubject.UseVisualStyleBackColor = true;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.BackgroundImage = global::CathedraProject.Properties.Resources.add;
            this.btnAddSubject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddSubject.Location = new System.Drawing.Point(16, 17);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(30, 30);
            this.btnAddSubject.TabIndex = 1;
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // btnDeleteQualif
            // 
            this.btnDeleteQualif.BackgroundImage = global::CathedraProject.Properties.Resources.delete;
            this.btnDeleteQualif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteQualif.Location = new System.Drawing.Point(95, 15);
            this.btnDeleteQualif.Name = "btnDeleteQualif";
            this.btnDeleteQualif.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteQualif.TabIndex = 7;
            this.btnDeleteQualif.UseVisualStyleBackColor = true;
            this.btnDeleteQualif.Click += new System.EventHandler(this.btnDeleteQualif_Click);
            // 
            // btnEditQualif
            // 
            this.btnEditQualif.BackgroundImage = global::CathedraProject.Properties.Resources.edit3;
            this.btnEditQualif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditQualif.Location = new System.Drawing.Point(59, 15);
            this.btnEditQualif.Name = "btnEditQualif";
            this.btnEditQualif.Size = new System.Drawing.Size(30, 30);
            this.btnEditQualif.TabIndex = 6;
            this.btnEditQualif.UseVisualStyleBackColor = true;
            this.btnEditQualif.Click += new System.EventHandler(this.btnEditQualif_Click);
            // 
            // btnAddQualif
            // 
            this.btnAddQualif.BackgroundImage = global::CathedraProject.Properties.Resources.add;
            this.btnAddQualif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddQualif.Location = new System.Drawing.Point(23, 15);
            this.btnAddQualif.Name = "btnAddQualif";
            this.btnAddQualif.Size = new System.Drawing.Size(30, 30);
            this.btnAddQualif.TabIndex = 5;
            this.btnAddQualif.UseVisualStyleBackColor = true;
            this.btnAddQualif.Click += new System.EventHandler(this.btnAddQualif_Click);
            // 
            // btnDeleteScienceWork
            // 
            this.btnDeleteScienceWork.BackgroundImage = global::CathedraProject.Properties.Resources.delete;
            this.btnDeleteScienceWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteScienceWork.Location = new System.Drawing.Point(94, 16);
            this.btnDeleteScienceWork.Name = "btnDeleteScienceWork";
            this.btnDeleteScienceWork.Size = new System.Drawing.Size(30, 30);
            this.btnDeleteScienceWork.TabIndex = 7;
            this.btnDeleteScienceWork.UseVisualStyleBackColor = true;
            this.btnDeleteScienceWork.Click += new System.EventHandler(this.btnDeleteScienceWork_Click);
            // 
            // btnEditScienceWork
            // 
            this.btnEditScienceWork.BackgroundImage = global::CathedraProject.Properties.Resources.edit3;
            this.btnEditScienceWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEditScienceWork.Location = new System.Drawing.Point(58, 16);
            this.btnEditScienceWork.Name = "btnEditScienceWork";
            this.btnEditScienceWork.Size = new System.Drawing.Size(30, 30);
            this.btnEditScienceWork.TabIndex = 6;
            this.btnEditScienceWork.UseVisualStyleBackColor = true;
            this.btnEditScienceWork.Click += new System.EventHandler(this.btnEditScienceWork_Click);
            // 
            // btnAddScienceWork
            // 
            this.btnAddScienceWork.BackgroundImage = global::CathedraProject.Properties.Resources.add;
            this.btnAddScienceWork.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddScienceWork.Location = new System.Drawing.Point(22, 16);
            this.btnAddScienceWork.Name = "btnAddScienceWork";
            this.btnAddScienceWork.Size = new System.Drawing.Size(30, 30);
            this.btnAddScienceWork.TabIndex = 5;
            this.btnAddScienceWork.UseVisualStyleBackColor = true;
            this.btnAddScienceWork.Click += new System.EventHandler(this.btnAddScienceWork_Click);
            // 
            // txtBxAcademicRank
            // 
            this.txtBxAcademicRank.Location = new System.Drawing.Point(189, 308);
            this.txtBxAcademicRank.Name = "txtBxAcademicRank";
            this.txtBxAcademicRank.Size = new System.Drawing.Size(345, 26);
            this.txtBxAcademicRank.TabIndex = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 311);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 19);
            this.label11.TabIndex = 79;
            this.label11.Text = "Ученое звание";
            // 
            // txtBxAcademicDegree
            // 
            this.txtBxAcademicDegree.Location = new System.Drawing.Point(189, 340);
            this.txtBxAcademicDegree.Name = "txtBxAcademicDegree";
            this.txtBxAcademicDegree.Size = new System.Drawing.Size(345, 26);
            this.txtBxAcademicDegree.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(38, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 81;
            this.label12.Text = "Ученая степень";
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "Предмет";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn
            // 
            this.hoursDataGridViewTextBoxColumn.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn.HeaderText = "Часы";
            this.hoursDataGridViewTextBoxColumn.Name = "hoursDataGridViewTextBoxColumn";
            this.hoursDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherSubjectBindingSource
            // 
            this.teacherSubjectBindingSource.DataSource = typeof(CathedraProject.Model.TeacherSubject);
            // 
            // iDRegDataGridViewTextBoxColumn
            // 
            this.iDRegDataGridViewTextBoxColumn.DataPropertyName = "IDReg";
            this.iDRegDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.iDRegDataGridViewTextBoxColumn.Name = "iDRegDataGridViewTextBoxColumn";
            this.iDRegDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursDataGridViewTextBoxColumn1
            // 
            this.hoursDataGridViewTextBoxColumn1.DataPropertyName = "Hours";
            this.hoursDataGridViewTextBoxColumn1.HeaderText = "Часы";
            this.hoursDataGridViewTextBoxColumn1.Name = "hoursDataGridViewTextBoxColumn1";
            this.hoursDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataSource = typeof(CathedraProject.Model.Qualification);
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Наименование";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            this.nameDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // teacherScienceWorkBindingSource
            // 
            this.teacherScienceWorkBindingSource.DataSource = typeof(CathedraProject.Model.TeacherScienceWork);
            // 
            // NewTeacherForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1123, 748);
            this.Controls.Add(this.txtBxAcademicDegree);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBxAcademicRank);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBxEducation);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBxAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtBxMiddleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxFirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtBxLastName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NewTeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Преподаватель";
            this.Load += new System.EventHandler(this.NewTeacherForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSubjectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherScienceWorkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtBxLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBxFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBxMiddleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBxAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBxEducation;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnDeleteQualif;
        private System.Windows.Forms.Button btnEditQualif;
        private System.Windows.Forms.Button btnAddQualif;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnDeleteScienceWork;
        private System.Windows.Forms.Button btnEditScienceWork;
        private System.Windows.Forms.Button btnAddScienceWork;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource teacherSubjectBindingSource;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource teacherScienceWorkBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDRegDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBxAcademicRank;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBxAcademicDegree;
        private System.Windows.Forms.Label label12;
    }
}