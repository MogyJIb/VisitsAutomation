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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudentForm));
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView_Students = new System.Windows.Forms.DataGridView();
            this.Column_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Course = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Subgroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Students)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Delete.Location = new System.Drawing.Point(468, 182);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 26);
            this.button_Delete.TabIndex = 19;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView_Students
            // 
            this.dataGridView_Students.AllowUserToDeleteRows = false;
            this.dataGridView_Students.AllowUserToResizeColumns = false;
            this.dataGridView_Students.AllowUserToResizeRows = false;
            this.dataGridView_Students.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Students.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView_Students.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Students.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_FullName,
            this.Column_Course,
            this.Column_Group,
            this.Column_Subgroup});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Students.DefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_Students.EnableHeadersVisualStyles = false;
            this.dataGridView_Students.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Students.Name = "dataGridView_Students";
            this.dataGridView_Students.RowHeadersVisible = false;
            this.dataGridView_Students.RowTemplate.Height = 24;
            this.dataGridView_Students.Size = new System.Drawing.Size(328, 261);
            this.dataGridView_Students.TabIndex = 18;
            this.dataGridView_Students.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Students_CellClick);
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
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(384, 182);
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
            this.button_Cancel.Location = new System.Drawing.Point(486, 247);
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
            this.textBox_Course.Location = new System.Drawing.Point(428, 71);
            this.textBox_Course.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Course.Name = "textBox_Course";
            this.textBox_Course.Size = new System.Drawing.Size(70, 26);
            this.textBox_Course.TabIndex = 14;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(360, 41);
            this.textBox_FullName.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(212, 26);
            this.textBox_FullName.TabIndex = 13;
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(364, 120);
            this.label_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 18);
            this.label_Group.TabIndex = 12;
            this.label_Group.Text = "Group:";
            // 
            // label_Course
            // 
            this.label_Course.AutoSize = true;
            this.label_Course.Location = new System.Drawing.Point(364, 71);
            this.label_Course.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Course.Name = "label_Course";
            this.label_Course.Size = new System.Drawing.Size(58, 18);
            this.label_Course.TabIndex = 11;
            this.label_Course.Text = "Course:";
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(364, 21);
            this.label_FullName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(77, 18);
            this.label_FullName.TabIndex = 10;
            this.label_FullName.Text = "Full name:";
            // 
            // textBox_Subgroup
            // 
            this.textBox_Subgroup.Location = new System.Drawing.Point(448, 151);
            this.textBox_Subgroup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Subgroup.Name = "textBox_Subgroup";
            this.textBox_Subgroup.Size = new System.Drawing.Size(50, 26);
            this.textBox_Subgroup.TabIndex = 21;
            // 
            // label_Subgroup
            // 
            this.label_Subgroup.AutoSize = true;
            this.label_Subgroup.Location = new System.Drawing.Point(364, 149);
            this.label_Subgroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Subgroup.Name = "label_Subgroup";
            this.label_Subgroup.Size = new System.Drawing.Size(76, 18);
            this.label_Subgroup.TabIndex = 20;
            this.label_Subgroup.Text = "Subgroup:";
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.BackColor = System.Drawing.Color.White;
            this.comboBox_Group.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Group.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(428, 120);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(144, 26);
            this.comboBox_Group.TabIndex = 22;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(592, 284);
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
            this.Font = new System.Drawing.Font("Constantia", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(614, 335);
            this.MinimumSize = new System.Drawing.Size(614, 335);
            this.Name = "AddStudentForm";
            this.Text = "Shedule application";
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