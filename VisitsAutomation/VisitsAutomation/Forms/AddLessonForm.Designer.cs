namespace VisitsAutomation.Forms
{
    partial class AddLessonForm
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
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Type = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Add
            // 
            this.button_Add.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Add.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button_Add.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_Add.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Add.Location = new System.Drawing.Point(48, 120);
            this.button_Add.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(98, 29);
            this.button_Add.TabIndex = 15;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = false;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button_Cancel.Location = new System.Drawing.Point(191, 120);
            this.button_Cancel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(98, 29);
            this.button_Cancel.TabIndex = 14;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(37, 35);
            this.textBox_Name.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(262, 26);
            this.textBox_Name.TabIndex = 11;
            // 
            // label_Type
            // 
            this.label_Type.AutoSize = true;
            this.label_Type.Location = new System.Drawing.Point(45, 74);
            this.label_Type.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Type.Name = "label_Type";
            this.label_Type.Size = new System.Drawing.Size(42, 18);
            this.label_Type.TabIndex = 9;
            this.label_Type.Text = "Type:";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(37, 13);
            this.label_Name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(50, 18);
            this.label_Name.TabIndex = 8;
            this.label_Name.Text = "Name:";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "practice",
            "lecture",
            "laboratory"});
            this.comboBox_Type.Location = new System.Drawing.Point(94, 74);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(182, 26);
            this.comboBox_Type.TabIndex = 16;
            // 
            // AddLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(252)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(342, 167);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_Type);
            this.Controls.Add(this.label_Name);
            this.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "AddLessonForm";
            this.Text = "AddLessonForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Type;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.ComboBox comboBox_Type;
    }
}