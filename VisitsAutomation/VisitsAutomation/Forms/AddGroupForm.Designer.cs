namespace VisitsAutomation.Forms
{
    partial class AddGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
            this.label_Group = new System.Windows.Forms.Label();
            this.label_Department = new System.Windows.Forms.Label();
            this.label_Faculty = new System.Windows.Forms.Label();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_Faculty = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.dataGridView_Groups = new System.Windows.Forms.DataGridView();
            this.Column_Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Groups)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(491, 22);
            this.label_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 18);
            this.label_Group.TabIndex = 0;
            this.label_Group.Text = "Group:";
            // 
            // label_Department
            // 
            this.label_Department.AutoSize = true;
            this.label_Department.Location = new System.Drawing.Point(491, 79);
            this.label_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(90, 18);
            this.label_Department.TabIndex = 1;
            this.label_Department.Text = "Department:";
            // 
            // label_Faculty
            // 
            this.label_Faculty.AutoSize = true;
            this.label_Faculty.Location = new System.Drawing.Point(491, 129);
            this.label_Faculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Faculty.Name = "label_Faculty";
            this.label_Faculty.Size = new System.Drawing.Size(58, 18);
            this.label_Faculty.TabIndex = 2;
            this.label_Faculty.Text = "Faculty:";
            this.label_Faculty.Click += new System.EventHandler(this.label_Faculty_Click);
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(491, 42);
            this.textBox_Group.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(212, 26);
            this.textBox_Group.TabIndex = 3;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Location = new System.Drawing.Point(491, 99);
            this.textBox_Department.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.Size = new System.Drawing.Size(212, 26);
            this.textBox_Department.TabIndex = 4;
            // 
            // textBox_Faculty
            // 
            this.textBox_Faculty.Location = new System.Drawing.Point(557, 129);
            this.textBox_Faculty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Faculty.Name = "textBox_Faculty";
            this.textBox_Faculty.Size = new System.Drawing.Size(146, 26);
            this.textBox_Faculty.TabIndex = 5;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Cancel.Location = new System.Drawing.Point(617, 222);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(86, 26);
            this.button_Cancel.TabIndex = 6;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(515, 160);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(86, 26);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Edit";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // dataGridView_Groups
            // 
            this.dataGridView_Groups.AllowUserToDeleteRows = false;
            this.dataGridView_Groups.AllowUserToResizeColumns = false;
            this.dataGridView_Groups.AllowUserToResizeRows = false;
            this.dataGridView_Groups.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_Groups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_Groups.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_Groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Groups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Group,
            this.Column_Department,
            this.Column_Faculty});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_Groups.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_Groups.EnableHeadersVisualStyles = false;
            this.dataGridView_Groups.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_Groups.Name = "dataGridView_Groups";
            this.dataGridView_Groups.ReadOnly = true;
            this.dataGridView_Groups.RowHeadersVisible = false;
            this.dataGridView_Groups.RowTemplate.Height = 24;
            this.dataGridView_Groups.Size = new System.Drawing.Size(461, 236);
            this.dataGridView_Groups.TabIndex = 8;
            this.dataGridView_Groups.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Groups_CellClick);
            // 
            // Column_Group
            // 
            this.Column_Group.HeaderText = "Group";
            this.Column_Group.MinimumWidth = 100;
            this.Column_Group.Name = "Column_Group";
            this.Column_Group.ReadOnly = true;
            // 
            // Column_Department
            // 
            this.Column_Department.HeaderText = "Department";
            this.Column_Department.MinimumWidth = 200;
            this.Column_Department.Name = "Column_Department";
            this.Column_Department.ReadOnly = true;
            this.Column_Department.Width = 200;
            // 
            // Column_Faculty
            // 
            this.Column_Faculty.HeaderText = "Faculty";
            this.Column_Faculty.MinimumWidth = 130;
            this.Column_Faculty.Name = "Column_Faculty";
            this.Column_Faculty.ReadOnly = true;
            this.Column_Faculty.Width = 130;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Delete.Location = new System.Drawing.Point(599, 160);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(86, 26);
            this.button_Delete.TabIndex = 9;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(726, 263);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.dataGridView_Groups);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Faculty);
            this.Controls.Add(this.textBox_Department);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.label_Faculty);
            this.Controls.Add(this.label_Department);
            this.Controls.Add(this.label_Group);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximumSize = new System.Drawing.Size(748, 314);
            this.MinimumSize = new System.Drawing.Size(748, 314);
            this.Name = "AddGroupForm";
            this.Text = "Shedule application";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Group;
        private System.Windows.Forms.Label label_Department;
        private System.Windows.Forms.Label label_Faculty;
        private System.Windows.Forms.TextBox textBox_Group;
        private System.Windows.Forms.TextBox textBox_Department;
        private System.Windows.Forms.TextBox textBox_Faculty;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.DataGridView dataGridView_Groups;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Department;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Faculty;
    }
}