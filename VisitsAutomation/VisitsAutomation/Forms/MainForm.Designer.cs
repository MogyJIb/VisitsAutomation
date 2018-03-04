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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.repotsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.absentListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lessonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage_Informaion = new System.Windows.Forms.TabPage();
            this.dataGridView_StudentsAbsent = new System.Windows.Forms.DataGridView();
            this.column_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column_Absents = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treeView_Groups = new System.Windows.Forms.TreeView();
            this.tabPage_Schedule = new System.Windows.Forms.TabPage();
            this.button_Save = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.menuStrip.Font = new System.Drawing.Font("Constantia", 9F);
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.repotsToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(618, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menu";
            // 
            // repotsToolStripMenuItem
            // 
            this.repotsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.absentListToolStripMenuItem,
            this.scheduleToolStripMenuItem});
            this.repotsToolStripMenuItem.Name = "repotsToolStripMenuItem";
            this.repotsToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.repotsToolStripMenuItem.Text = "Reports";
            // 
            // absentListToolStripMenuItem
            // 
            this.absentListToolStripMenuItem.Name = "absentListToolStripMenuItem";
            this.absentListToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
            this.absentListToolStripMenuItem.Text = "Absent list";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(150, 26);
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
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 22);
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
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // subjectToolStripMenuItem
            // 
            this.subjectToolStripMenuItem.Name = "subjectToolStripMenuItem";
            this.subjectToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.subjectToolStripMenuItem.Text = "Subject";
            this.subjectToolStripMenuItem.Click += new System.EventHandler(this.subjectToolStripMenuItem_Click);
            // 
            // lessonToolStripMenuItem
            // 
            this.lessonToolStripMenuItem.Name = "lessonToolStripMenuItem";
            this.lessonToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.lessonToolStripMenuItem.Text = "Lesson";
            this.lessonToolStripMenuItem.Click += new System.EventHandler(this.lessonToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(51, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage_Informaion);
            this.tabControl_Main.Controls.Add(this.tabPage_Schedule);
            this.tabControl_Main.Location = new System.Drawing.Point(0, 29);
            this.tabControl_Main.Multiline = true;
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(619, 276);
            this.tabControl_Main.TabIndex = 1;
            // 
            // tabPage_Informaion
            // 
            this.tabPage_Informaion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.tabPage_Informaion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Informaion.Controls.Add(this.dataGridView_StudentsAbsent);
            this.tabPage_Informaion.Controls.Add(this.treeView_Groups);
            this.tabPage_Informaion.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Informaion.Name = "tabPage_Informaion";
            this.tabPage_Informaion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Informaion.Size = new System.Drawing.Size(611, 245);
            this.tabPage_Informaion.TabIndex = 0;
            this.tabPage_Informaion.Text = "Information";
            // 
            // dataGridView_StudentsAbsent
            // 
            this.dataGridView_StudentsAbsent.AllowUserToAddRows = false;
            this.dataGridView_StudentsAbsent.AllowUserToDeleteRows = false;
            this.dataGridView_StudentsAbsent.AllowUserToResizeColumns = false;
            this.dataGridView_StudentsAbsent.AllowUserToResizeRows = false;
            this.dataGridView_StudentsAbsent.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_StudentsAbsent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_StudentsAbsent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_StudentsAbsent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_StudentsAbsent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column_FullName,
            this.column_Course,
            this.column_Absents});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_StudentsAbsent.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_StudentsAbsent.EnableHeadersVisualStyles = false;
            this.dataGridView_StudentsAbsent.Location = new System.Drawing.Point(157, 7);
            this.dataGridView_StudentsAbsent.Name = "dataGridView_StudentsAbsent";
            this.dataGridView_StudentsAbsent.ReadOnly = true;
            this.dataGridView_StudentsAbsent.RowHeadersVisible = false;
            this.dataGridView_StudentsAbsent.RowTemplate.Height = 24;
            this.dataGridView_StudentsAbsent.Size = new System.Drawing.Size(445, 228);
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
            this.treeView_Groups.Location = new System.Drawing.Point(7, 7);
            this.treeView_Groups.Name = "treeView_Groups";
            this.treeView_Groups.Size = new System.Drawing.Size(144, 228);
            this.treeView_Groups.TabIndex = 0;
            this.treeView_Groups.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_Groups_AfterSelect);
            // 
            // tabPage_Schedule
            // 
            this.tabPage_Schedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.tabPage_Schedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage_Schedule.Controls.Add(this.button_Save);
            this.tabPage_Schedule.Controls.Add(this.splitContainer1);
            this.tabPage_Schedule.Controls.Add(this.flowLayoutPanel_Absents);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Faculty);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Group);
            this.tabPage_Schedule.Controls.Add(this.comboBox_Department);
            this.tabPage_Schedule.Controls.Add(this.dateTimePicker_ScheduleDate);
            this.tabPage_Schedule.Controls.Add(this.listBox_Subjects);
            this.tabPage_Schedule.Location = new System.Drawing.Point(4, 27);
            this.tabPage_Schedule.Name = "tabPage_Schedule";
            this.tabPage_Schedule.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Schedule.Size = new System.Drawing.Size(611, 245);
            this.tabPage_Schedule.TabIndex = 1;
            this.tabPage_Schedule.Text = "Schedule";
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Save.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Save.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Save.Location = new System.Drawing.Point(505, 207);
            this.button_Save.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(86, 26);
            this.button_Save.TabIndex = 18;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(214, 7);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1MinSize = 190;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Size = new System.Drawing.Size(390, 21);
            this.splitContainer1.SplitterDistance = 190;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Absent";
            // 
            // flowLayoutPanel_Absents
            // 
            this.flowLayoutPanel_Absents.AutoScroll = true;
            this.flowLayoutPanel_Absents.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel_Absents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flowLayoutPanel_Absents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel_Absents.Location = new System.Drawing.Point(214, 27);
            this.flowLayoutPanel_Absents.Name = "flowLayoutPanel_Absents";
            this.flowLayoutPanel_Absents.Size = new System.Drawing.Size(390, 214);
            this.flowLayoutPanel_Absents.TabIndex = 5;
            this.flowLayoutPanel_Absents.WrapContents = false;
            // 
            // comboBox_Faculty
            // 
            this.comboBox_Faculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Faculty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Faculty.FormattingEnabled = true;
            this.comboBox_Faculty.Location = new System.Drawing.Point(17, 6);
            this.comboBox_Faculty.Name = "comboBox_Faculty";
            this.comboBox_Faculty.Size = new System.Drawing.Size(98, 26);
            this.comboBox_Faculty.TabIndex = 4;
            this.comboBox_Faculty.SelectedIndexChanged += new System.EventHandler(this.comboBox_Faculty_SelectedIndexChanged);
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(18, 70);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(136, 26);
            this.comboBox_Group.TabIndex = 3;
            this.comboBox_Group.SelectedIndexChanged += new System.EventHandler(this.comboBox_Group_SelectedIndexChanged);
            // 
            // comboBox_Department
            // 
            this.comboBox_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Department.FormattingEnabled = true;
            this.comboBox_Department.Location = new System.Drawing.Point(18, 38);
            this.comboBox_Department.Name = "comboBox_Department";
            this.comboBox_Department.Size = new System.Drawing.Size(153, 26);
            this.comboBox_Department.TabIndex = 2;
            this.comboBox_Department.SelectedIndexChanged += new System.EventHandler(this.comboBox_Department_SelectedIndexChanged);
            // 
            // dateTimePicker_ScheduleDate
            // 
            this.dateTimePicker_ScheduleDate.Location = new System.Drawing.Point(32, 102);
            this.dateTimePicker_ScheduleDate.Name = "dateTimePicker_ScheduleDate";
            this.dateTimePicker_ScheduleDate.Size = new System.Drawing.Size(153, 26);
            this.dateTimePicker_ScheduleDate.TabIndex = 1;
            this.dateTimePicker_ScheduleDate.ValueChanged += new System.EventHandler(this.dateTimePicker_ScheduleDate_ValueChanged);
            // 
            // listBox_Subjects
            // 
            this.listBox_Subjects.FormattingEnabled = true;
            this.listBox_Subjects.ItemHeight = 18;
            this.listBox_Subjects.Location = new System.Drawing.Point(7, 150);
            this.listBox_Subjects.Name = "listBox_Subjects";
            this.listBox_Subjects.Size = new System.Drawing.Size(198, 94);
            this.listBox_Subjects.TabIndex = 0;
            this.listBox_Subjects.SelectedIndexChanged += new System.EventHandler(this.listBox_Subjects_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(618, 301);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Constantia", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximumSize = new System.Drawing.Size(640, 352);
            this.MinimumSize = new System.Drawing.Size(640, 352);
            this.Name = "MainForm";
            this.Text = "Shedule application";
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
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem absentListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
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
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lessonToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_Save;
    }
}