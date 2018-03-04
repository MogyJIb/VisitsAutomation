namespace VisitsAutomation.Forms
{
    partial class AddScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScheduleForm));
            this.label_Group = new System.Windows.Forms.Label();
            this.button_Delete = new System.Windows.Forms.Button();
            this.dataGridView_Schedules = new System.Windows.Forms.DataGridView();
            this.Column_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Lesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Number = new System.Windows.Forms.TextBox();
            this.label_Day = new System.Windows.Forms.Label();
            this.label_Number = new System.Windows.Forms.Label();
            this.label_Lesson = new System.Windows.Forms.Label();
            this.comboBox_Lesson = new System.Windows.Forms.ComboBox();
            this.comboBox_Group = new System.Windows.Forms.ComboBox();
            this.comboBox_Day = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedules)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(375, 135);
            this.label_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 18);
            this.label_Group.TabIndex = 32;
            this.label_Group.Text = "Group:";
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Delete.Location = new System.Drawing.Point(488, 164);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 26);
            this.button_Delete.TabIndex = 31;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // dataGridView_Schedules
            // 
            this.dataGridView_Schedules.AllowUserToDeleteRows = false;
            this.dataGridView_Schedules.AllowUserToResizeColumns = false;
            this.dataGridView_Schedules.AllowUserToResizeRows = false;
            this.dataGridView_Schedules.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Schedules.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Schedules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Schedules.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Group,
            this.Column_Day,
            this.Column_Number,
            this.Column_Lesson});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Schedules.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Schedules.EnableHeadersVisualStyles = false;
            this.dataGridView_Schedules.Location = new System.Drawing.Point(14, 14);
            this.dataGridView_Schedules.Name = "dataGridView_Schedules";
            this.dataGridView_Schedules.RowHeadersVisible = false;
            this.dataGridView_Schedules.RowTemplate.Height = 24;
            this.dataGridView_Schedules.Size = new System.Drawing.Size(340, 239);
            this.dataGridView_Schedules.TabIndex = 30;
            this.dataGridView_Schedules.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Schedules_CellClick);
            // 
            // Column_Group
            // 
            this.Column_Group.HeaderText = "Group";
            this.Column_Group.MinimumWidth = 60;
            this.Column_Group.Name = "Column_Group";
            this.Column_Group.ReadOnly = true;
            this.Column_Group.Width = 60;
            // 
            // Column_Day
            // 
            this.Column_Day.HeaderText = "Day";
            this.Column_Day.MinimumWidth = 90;
            this.Column_Day.Name = "Column_Day";
            this.Column_Day.Width = 90;
            // 
            // Column_Number
            // 
            this.Column_Number.HeaderText = "Number";
            this.Column_Number.MinimumWidth = 60;
            this.Column_Number.Name = "Column_Number";
            this.Column_Number.ReadOnly = true;
            this.Column_Number.Width = 60;
            // 
            // Column_Lesson
            // 
            this.Column_Lesson.HeaderText = "Lesson";
            this.Column_Lesson.MinimumWidth = 100;
            this.Column_Lesson.Name = "Column_Lesson";
            this.Column_Lesson.ReadOnly = true;
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(404, 164);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 26);
            this.button_Add.TabIndex = 29;
            this.button_Add.Text = "Edit";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Cancel.Location = new System.Drawing.Point(504, 227);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(86, 26);
            this.button_Cancel.TabIndex = 28;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // textBox_Number
            // 
            this.textBox_Number.Location = new System.Drawing.Point(449, 51);
            this.textBox_Number.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Number.Name = "textBox_Number";
            this.textBox_Number.Size = new System.Drawing.Size(51, 26);
            this.textBox_Number.TabIndex = 27;
            // 
            // label_Day
            // 
            this.label_Day.AutoSize = true;
            this.label_Day.Location = new System.Drawing.Point(375, 94);
            this.label_Day.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Day.Name = "label_Day";
            this.label_Day.Size = new System.Drawing.Size(37, 18);
            this.label_Day.TabIndex = 25;
            this.label_Day.Text = "Day:";
            // 
            // label_Number
            // 
            this.label_Number.AutoSize = true;
            this.label_Number.Location = new System.Drawing.Point(375, 51);
            this.label_Number.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Number.Name = "label_Number";
            this.label_Number.Size = new System.Drawing.Size(66, 18);
            this.label_Number.TabIndex = 24;
            this.label_Number.Text = "Number:";
            // 
            // label_Lesson
            // 
            this.label_Lesson.AutoSize = true;
            this.label_Lesson.Location = new System.Drawing.Point(375, 20);
            this.label_Lesson.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Lesson.Name = "label_Lesson";
            this.label_Lesson.Size = new System.Drawing.Size(56, 18);
            this.label_Lesson.TabIndex = 23;
            this.label_Lesson.Text = "Lesson:";
            // 
            // comboBox_Lesson
            // 
            this.comboBox_Lesson.FormattingEnabled = true;
            this.comboBox_Lesson.Location = new System.Drawing.Point(435, 20);
            this.comboBox_Lesson.Name = "comboBox_Lesson";
            this.comboBox_Lesson.Size = new System.Drawing.Size(155, 26);
            this.comboBox_Lesson.TabIndex = 35;
            // 
            // comboBox_Group
            // 
            this.comboBox_Group.FormattingEnabled = true;
            this.comboBox_Group.Location = new System.Drawing.Point(435, 132);
            this.comboBox_Group.Name = "comboBox_Group";
            this.comboBox_Group.Size = new System.Drawing.Size(155, 26);
            this.comboBox_Group.TabIndex = 37;
            // 
            // comboBox_Day
            // 
            this.comboBox_Day.FormattingEnabled = true;
            this.comboBox_Day.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.comboBox_Day.Location = new System.Drawing.Point(419, 94);
            this.comboBox_Day.Name = "comboBox_Day";
            this.comboBox_Day.Size = new System.Drawing.Size(171, 26);
            this.comboBox_Day.TabIndex = 38;
            // 
            // AddScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(606, 266);
            this.Controls.Add(this.comboBox_Day);
            this.Controls.Add(this.comboBox_Group);
            this.Controls.Add(this.comboBox_Lesson);
            this.Controls.Add(this.label_Group);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Schedules);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Number);
            this.Controls.Add(this.label_Day);
            this.Controls.Add(this.label_Number);
            this.Controls.Add(this.label_Lesson);
            this.Font = new System.Drawing.Font("Constantia", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(624, 313);
            this.MinimumSize = new System.Drawing.Size(624, 313);
            this.Name = "AddScheduleForm";
            this.Text = "Shedule application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Schedules)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridView dataGridView_Schedules;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Number;
        private System.Windows.Forms.Label label_Day;
        private System.Windows.Forms.Label label_Number;
        private System.Windows.Forms.Label label_Lesson;
        private System.Windows.Forms.ComboBox comboBox_Lesson;
        private System.Windows.Forms.ComboBox comboBox_Group;
        private System.Windows.Forms.ComboBox comboBox_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Lesson;
    }
}