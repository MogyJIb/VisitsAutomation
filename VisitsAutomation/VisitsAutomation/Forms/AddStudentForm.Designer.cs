namespace VisitsAutomation.Forms
{
    partial class AddStudentForm
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Course = new System.Windows.Forms.TextBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.label_Group = new System.Windows.Forms.Label();
            this.label_Course = new System.Windows.Forms.Label();
            this.label_FullName = new System.Windows.Forms.Label();
            this.textBox_Subgroup = new System.Windows.Forms.TextBox();
            this.label_Subgroup = new System.Windows.Forms.Label();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.Column_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Subgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Delete.Location = new System.Drawing.Point(555, 248);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 26);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FullName,
            this.Column_Course,
            this.Column_Group,
            this.Column_Subgroup});
            this.dataGridView_Students.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.RowHeadersVisible = false;
            this.dataGridView_Students.RowTemplate.Height = 24;
            this.dataGridView_Students.Size = new System.Drawing.Size(430, 310);
            this.dataGridView_Students.TabIndex = 18;
            this.dataGridView_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Students_CellClick);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(462, 248);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 26);
            this.button_Add.TabIndex = 17;
            this.button_Add.Text = "Edit";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Cancel.Location = new System.Drawing.Point(573, 297);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(86, 26);
            this.button_Cancel.TabIndex = 16;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Course
            // 
            this.textBox_Course.Location = new System.Drawing.Point(448, 91);
            this.textBox_Course.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Course.Name = "textBox_Course";
            this.textBox_Course.Size = new System.Drawing.Size(212, 22);
            this.textBox_Course.TabIndex = 14;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(448, 33);
            this.textBox_FullName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(212, 22);
            this.textBox_FullName.TabIndex = 13;
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(448, 129);
            this.label_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(52, 17);
            this.label_Group.TabIndex = 12;
            this.label_Group.Text = "Group:";
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(448, 71);
            this.label_Course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(57, 17);
            this.label_Course.TabIndex = 11;
            this.label_Course.Text = "Course:";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(448, 13);
            this.label_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(73, 17);
            this.label_FullName.TabIndex = 10;
            this.label_FullName.Text = "Full name:";
            // 
            // textBox_Subgroup
            // 
            this.textBox_Subgroup.Location = new System.Drawing.Point(448, 209);
            this.textBox_Subgroup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Subgroup.Name = "textBox_Subgroup";
            this.textBox_Subgroup.Size = new System.Drawing.Size(212, 22);
            this.textBox_Subgroup.TabIndex = 21;
            // 
            // label_Subgroup
            // 
            this.label_Subgroup.AutoSize = true;
            this.label_Subgroup.Location = new System.Drawing.Point(448, 189);
            this.label_Subgroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Subgroup.Name = "label_Subgroup";
            this.label_Subgroup.Size = new System.Drawing.Size(74, 17);
            this.label_Subgroup.TabIndex = 20;
            this.label_Subgroup.Text = "Subgroup:";
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(448, 149);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(212, 24);
            this.comboBox_Group.TabIndex = 22;
            // 
            // Column_FullName
            // 
            this.Column_FullName.HeaderText = "Full name";
            this.Column_FullName.MinimumWidth = 120;
            this.Column_FullName.Name = "Column_FullName";
            this.Column_FullName.ReadOnly = true;
            this.Column_FullName.Width = 120;
            // 
            // Column_Course
            // 
            this.Column_Course.HeaderText = "Course";
            this.Column_Course.MinimumWidth = 60;
            this.Column_Course.Name = "Column_Course";
            this.Column_Course.ReadOnly = true;
            this.Column_Course.Width = 60;
            // 
            // Column_Group
            // 
            this.Column_Group.HeaderText = "Group";
            this.Column_Group.MinimumWidth = 50;
            this.Column_Group.Name = "Column_Group";
            this.Column_Group.Width = 50;
            // 
            // Column_Subgroup
            // 
            this.Column_Subgroup.HeaderText = "Subgroup";
            this.Column_Subgroup.MinimumWidth = 70;
            this.Column_Subgroup.Name = "Column_Subgroup";
            this.Column_Subgroup.ReadOnly = true;
            this.Column_Subgroup.Width = 70;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 330);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.textBox_Subgroup);
            this.Controls.Add(this.label_Subgroup);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Students);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Course);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.label_Course);
            this.Controls.Add(this.label_FullName);
            this.Name = "AddStudentForm";
            this.Text = "AddStudentForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView_Students;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Course;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Label label_Course;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox textBox_Subgroup;
        private System.Windows.Forms.Label label_Subgroup;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Course;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Subgroup;
    }
}