using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitsAutomation.Models;

namespace VisitsAutomation.Forms
{
    public partial class AddLessonForm : Form
    {
        private DataContext _data;

        public AddLessonForm()
        {
            InitializeComponent();
            comboBox_Type.SelectedIndex = 0;
        }

        public AddLessonForm(DataContext data) : this()
        {
            this._data = data;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string type = comboBox_Type.SelectedItem.ToString();

            int id = _data.Lessons.Count + 1;

            Lesson lesson = new Lesson
            {
                Id = id,
                Name = name,
                Type = type
            };

            var findLessons = _data.Lessons.Where(t => t.Equals(lesson));

            if (findLessons.Count() > 0)
            {
                MessageBox.Show("This lesson alredy exist!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _data.Lessons.Add(lesson);
                _data.SaveChanges(DataContext.LESSON);

                MessageBox.Show("Lesson was added successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
