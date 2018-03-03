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
            this.label_Group = new System.Windows.Forms.Label();
            this.label_Department = new System.Windows.Forms.Label();
            this.label_Faculty = new System.Windows.Forms.Label();
            this.textBox_Group = new System.Windows.Forms.TextBox();
            this.textBox_Department = new System.Windows.Forms.TextBox();
            this.textBox_Faculty = new System.Windows.Forms.TextBox();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Group
            // 
            this.label_Group.AutoSize = true;
            this.label_Group.Location = new System.Drawing.Point(50, 32);
            this.label_Group.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Group.Name = "label_Group";
            this.label_Group.Size = new System.Drawing.Size(54, 18);
            this.label_Group.TabIndex = 0;
            this.label_Group.Text = "Group:";
            // 
            // label_Department
            // 
            this.label_Department.AutoSize = true;
            this.label_Department.Location = new System.Drawing.Point(50, 90);
            this.label_Department.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Department.Name = "label_Department";
            this.label_Department.Size = new System.Drawing.Size(90, 18);
            this.label_Department.TabIndex = 1;
            this.label_Department.Text = "Department:";
            // 
            // label_Faculty
            // 
            this.label_Faculty.AutoSize = true;
            this.label_Faculty.Location = new System.Drawing.Point(50, 148);
            this.label_Faculty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Faculty.Name = "label_Faculty";
            this.label_Faculty.Size = new System.Drawing.Size(58, 18);
            this.label_Faculty.TabIndex = 2;
            this.label_Faculty.Text = "Faculty:";
            this.label_Faculty.Click += new System.EventHandler(this.label_Faculty_Click);
            // 
            // textBox_Group
            // 
            this.textBox_Group.Location = new System.Drawing.Point(50, 52);
            this.textBox_Group.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Group.Name = "textBox_Group";
            this.textBox_Group.Size = new System.Drawing.Size(264, 26);
            this.textBox_Group.TabIndex = 3;
            // 
            // textBox_Department
            // 
            this.textBox_Department.Location = new System.Drawing.Point(50, 110);
            this.textBox_Department.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Department.Name = "textBox_Department";
            this.textBox_Department.Size = new System.Drawing.Size(264, 26);
            this.textBox_Department.TabIndex = 4;
            // 
            // textBox_Faculty
            // 
            this.textBox_Faculty.Location = new System.Drawing.Point(50, 168);
            this.textBox_Faculty.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Faculty.Name = "textBox_Faculty";
            this.textBox_Faculty.Size = new System.Drawing.Size(264, 26);
            this.textBox_Faculty.TabIndex = 5;
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Cancel.Location = new System.Drawing.Point(183, 215);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(108, 26);
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
            this.button_Add.Location = new System.Drawing.Point(66, 215);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(108, 26);
            this.button_Add.TabIndex = 7;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(364, 263);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Faculty);
            this.Controls.Add(this.textBox_Department);
            this.Controls.Add(this.textBox_Group);
            this.Controls.Add(this.label_Faculty);
            this.Controls.Add(this.label_Department);
            this.Controls.Add(this.label_Group);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "AddGroupForm";
            this.Text = "AddGroup";
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
    }
}