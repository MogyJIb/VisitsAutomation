namespace VisitsAutomation.Forms
{
    partial class MainForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referenceBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Informaion = new System.Windows.Forms.TabPage();
            this.dataGridView_StudentsAbsent = new System.Windows.Forms.DataGridView();
            this.column_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Absents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView_Groups = new System.Windows.Forms.TreeView();
            this.tabPage_Schedule = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_Save = new System.Windows.Forms.Button();
            this.flowLayoutPanel_Absents = new System.Windows.Forms.FlowLayoutPanel();
            this.comboBox_Faculty = new System.Windows.Forms.ComboBox();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.comboBox_Department = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_ScheduleDate = new System.Windows.Forms.DateTimePicker();
            this.listBox_Subjects = new System.Windows.Forms.ListBox();
            this.menuStrip.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage_Informaion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentsAbsent)).BeginInit();
            this.tabPage_Schedule.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repotsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.referenceBooksToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(822, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // repotsToolStripMenuItem
            // 
            this.repotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absentListToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.repotsToolStripMenuItem.Name = "repotsToolStripMenuItem";
            this.repotsToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.repotsToolStripMenuItem.Text = "Reports";
            // 
            // absentListToolStripMenuItem
            // 
            this.absentListToolStripMenuItem.Name = "absentListToolStripMenuItem";
            this.absentListToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.absentListToolStripMenuItem.Text = "Absent list";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.subjectToolStripMenuItem,
            this.lessonToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // groupToolStripMenuItem
            // 
            this.groupToolStripMenuItem.Name = "groupToolStripMenuItem";
            this.groupToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.groupToolStripMenuItem.Text = "Group";
            this.groupToolStripMenuItem.Click += new System.EventHandler(this.groupToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.studentToolStripMenuItem.Text = "Student";
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.subjectToolStripMenuItem.Text = "Subject";
            // 
            // lessonToolStripMenuItem
            // 
            this.lessonToolStripMenuItem.Name = "lessonToolStripMenuItem";
            this.lessonToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lessonToolStripMenuItem.Text = "Lesson";
            this.lessonToolStripMenuItem.Click += new System.EventHandler(this.lessonToolStripMenuItem_Click);
            // 
            // referenceBooksToolStripMenuItem
            // 
            this.referenceBooksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absentsToolStripMenuItem,
            this.studensToolStripMenuItem,
            this.groupsToolStripMenuItem,
            this.departmentsToolStripMenuItem});
            this.referenceBooksToolStripMenuItem.Name = "referenceBooksToolStripMenuItem";
            this.referenceBooksToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.referenceBooksToolStripMenuItem.Text = "Reference books";
            // 
            // absentsToolStripMenuItem
            // 
            this.absentsToolStripMenuItem.Name = "absentsToolStripMenuItem";
            this.absentsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.absentsToolStripMenuItem.Text = "Absents";
            // 
            // studensToolStripMenuItem
            // 
            this.studensToolStripMenuItem.Name = "studensToolStripMenuItem";
            this.studensToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.studensToolStripMenuItem.Text = "Studens";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // departmentsToolStripMenuItem
            // 
            this.departmentsToolStripMenuItem.Name = "departmentsToolStripMenuItem";
            this.departmentsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.departmentsToolStripMenuItem.Text = "Departments";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Informaion);
            this.tabControl_Main.Controls.Add(this.tabPage_Schedule);
            this.tabControl_Main.Location = new System.Drawing.Point(12, 31);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(798, 394);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Informaion
            // 
            this.tabPage_Informaion.Controls.Add(this.dataGridView_StudentsAbsent);
            this.tabPage_Informaion.Controls.Add(this.treeView_Groups);
            this.tabPage_Informaion.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Informaion.Name = "tabPage_Informaion";
            this.tabPage_Informaion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Informaion.Size = new System.Drawing.Size(790, 365);
            this.tabPage_Informaion.TabIndex = 0;
            this.tabPage_Informaion.Text = "Information";
            this.tabPage_Informaion.UseVisualStyleBackColor = true;
            // 
            // dataGridView_StudentsAbsent
            // 
            this.dataGridView_StudentsAbsent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_StudentsAbsent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_StudentsAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentsAbsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_FullName,
            this.column_Course,
            this.column_Absents});
            this.dataGridView_StudentsAbsent.Enabled = false;
            this.dataGridView_StudentsAbsent.Location = new System.Drawing.Point(208, 6);
            this.dataGridView_StudentsAbsent.Name = "dataGridView_StudentsAbsent";
            this.dataGridView_StudentsAbsent.ReadOnly = true;
            this.dataGridView_StudentsAbsent.RowHeadersVisible = false;
            this.dataGridView_StudentsAbsent.RowTemplate.Height = 24;
            this.dataGridView_StudentsAbsent.Size = new System.Drawing.Size(576, 353);
            this.dataGridView_StudentsAbsent.TabIndex = 2;
            // 
            // column_FullName
            // 
            this.column_FullName.HeaderText = "Full name";
            this.column_FullName.Name = "column_FullName";
            this.column_FullName.ReadOnly = true;
            this.column_FullName.Width = 209;
            // 
            // column_Course
            // 
            this.column_Course.HeaderText = "Course";
            this.column_Course.Name = "column_Course";
            this.column_Course.ReadOnly = true;
            this.column_Course.Width = 110;
            // 
            // column_Absents
            // 
            this.column_Absents.HeaderText = "Count absents";
            this.column_Absents.Name = "column_Absents";
            this.column_Absents.ReadOnly = true;
            this.column_Absents.Width = 110;
            // 
            // treeView_Groups
            // 
            this.treeView_Groups.Location = new System.Drawing.Point(6, 6);
            this.treeView_Groups.Name = "treeView_Groups";
            this.treeView_Groups.Size = new System.Drawing.Size(196, 353);
            this.treeView_Groups.TabIndex = 0;
            this.treeView_Groups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Groups_AfterSelect);
            // 
            // tabPage_Schedule
            // 
            this.tabPage_Schedule.Controls.Add(this.splitContainer1);
            this.tabPage_Schedule.Controls.Add(this.button_Save);
            this.tabPage_Schedule.Controls.Add(this.flowLayoutPanel_Absents);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Faculty);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Group);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Department);
            this.tabPage_Schedule.Controls.Add(this.dateTimePicker_ScheduleDate);
            this.tabPage_Schedule.Controls.Add(this.listBox_Subjects);
            this.tabPage_Schedule.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Schedule.Name = "tabPage_Schedule";
            this.tabPage_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Schedule.Size = new System.Drawing.Size(790, 365);
            this.tabPage_Schedule.TabIndex = 1;
            this.tabPage_Schedule.Text = "Schedule";
            this.tabPage_Schedule.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(310, 22);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1MinSize = 190;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(463, 35);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Absent";
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(150, 320);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(109, 29);
            this.button_Save.TabIndex = 0;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // flowLayoutPanel_Absents
            // 
            this.flowLayoutPanel_Absents.AutoScroll = true;
            this.flowLayoutPanel_Absents.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel_Absents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_Absents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Absents.Location = new System.Drawing.Point(310, 58);
            this.flowLayoutPanel_Absents.Name = "flowLayoutPanel_Absents";
            this.flowLayoutPanel_Absents.Size = new System.Drawing.Size(463, 291);
            this.flowLayoutPanel_Absents.TabIndex = 5;
            this.flowLayoutPanel_Absents.WrapContents = false;
            // 
            // comboBox_Faculty
            // 
            this.comboBox_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Faculty.FormattingEnabled = true;
            this.comboBox_Faculty.Location = new System.Drawing.Point(57, 58);
            this.comboBox_Faculty.Name = "comboBox_Faculty";
            this.comboBox_Faculty.Size = new System.Drawing.Size(155, 24);
            this.comboBox_Faculty.TabIndex = 4;
            this.comboBox_Faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox_Faculty_SelectedIndexChanged);
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Group.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(57, 138);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(121, 24);
            this.comboBox_Group.TabIndex = 3;
            this.comboBox_Group.SelectedIndexChanged += new System.EventHandler(this.comboBox_Group_SelectedIndexChanged);
            // 
            // comboBox_Department
            // 
            this.comboBox_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Department.FormattingEnabled = true;
            this.comboBox_Department.Location = new System.Drawing.Point(57, 98);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(177, 24);
            this.comboBox_Department.TabIndex = 2;
            this.comboBox_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox_Department_SelectedIndexChanged);
            // 
            // dateTimePicker_ScheduleDate
            // 
            this.dateTimePicker_ScheduleDate.Location = new System.Drawing.Point(42, 22);
            this.dateTimePicker_ScheduleDate.Name = "dateTimePicker_ScheduleDate";
            this.dateTimePicker_ScheduleDate.Size = new System.Drawing.Size(196, 22);
            this.dateTimePicker_ScheduleDate.TabIndex = 1;
            this.dateTimePicker_ScheduleDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ScheduleDate_ValueChanged);
            // 
            // listBox_Subjects
            // 
            this.listBox_Subjects.FormattingEnabled = true;
            this.listBox_Subjects.ItemHeight = 16;
            this.listBox_Subjects.Location = new System.Drawing.Point(21, 182);
            this.listBox_Subjects.Name = "listBox_Subjects";
            this.listBox_Subjects.Size = new System.Drawing.Size(251, 132);
            this.listBox_Subjects.TabIndex = 0;
            this.listBox_Subjects.SelectedIndexChanged += new System.EventHandler(this.listBox_Subjects_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 437);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(840, 484);
            this.MinimumSize = new System.Drawing.Size(840, 484);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage_Informaion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_StudentsAbsent)).EndInit();
            this.tabPage_Schedule.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem repotsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem referenceBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departmentsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage_Informaion;
        private System.Windows.Forms.TabPage tabPage_Schedule;
        private System.Windows.Forms.TreeView treeView_Groups;
        private System.Windows.Forms.DataGridView dataGridView_StudentsAbsent;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn column_Absents;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ScheduleDate;
        private System.Windows.Forms.ListBox listBox_Subjects;
        private System.Windows.Forms.ComboBox comboBox_Faculty;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.ComboBox comboBox_Department;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel_Absents;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}