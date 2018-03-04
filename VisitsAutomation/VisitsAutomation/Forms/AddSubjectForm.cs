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
    public partial class AddSubjectForm : Form
    {
        private Lesson selectedLesson;
        private int selectedIndex = 0;
        private DataContext _data;

        public AddSubjectForm()
        {
            InitializeComponent();
            comboBox_Type.SelectedIndex = 0;
            dataGridView_Lessons.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public AddSubjectForm(DataContext data) : this()
        {
            this._data = data;
            LoadLessons();


        }

        private void LoadLessons()
        {
            dataGridView_Lessons.Rows.Clear();
            var lessons = _data.Lessons.OrderBy(t => t.Name).ToList();
            foreach (Lesson lesson in lessons)
            {
                dataGridView_Lessons.Rows.Add(
                        new string[]
                        {
                            lesson.Name,
                            lesson.Type
                        });
            }
            if (lessons.Count > 0)
            {
                selectedLesson = lessons.First();
                SetLesson();
            }

        }

        private void SetLesson()
        {
            if (selectedLesson != null)
            {
                textBox_Name.Text = selectedLesson.Name;
                switch (selectedLesson.Type)
                {
                    case Lesson.PRACTICE:
                        comboBox_Type.SelectedIndex = 0;
                        break;
                    case Lesson.LECTURE:
                        comboBox_Type.SelectedIndex = 1;
                        break;
                    case Lesson.LABORAORY:
                        comboBox_Type.SelectedIndex = 2;
                        break;
                }

            }
            else
            {
                textBox_Name.Text = "";
                comboBox_Type.SelectedIndex = 0;
            }
        }
        

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Name.Text;
            string type = comboBox_Type.SelectedItem.ToString();

            int id = 1;
            if(_data.Lessons.Count>0)
                id = _data.Lessons.Select(t => t.Id).Max() + 1;
            

            Lesson lesson;
            if (selectedLesson == null)
            {
                lesson = new Lesson
                {
                    Id = id,
                    Name = name,
                    Type = type
                };
                var findLessons = _data.Lessons.Where(t => t.Equals(lesson));

                if (findLessons.Count() > 0)
                {
                    MessageBox.Show(
                        "This lesson alredy exist!",
                        "warning",
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning
                        );
                }
                else
                {

                    _data.Lessons.Add(lesson);
                    _data.SaveChanges(DataContext.LESSON);
                    MessageBox.Show("Lesson was added successfully.",
                        "information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadLessons();

                }
            }
            else
            {
                selectedLesson.Name = name;
                selectedLesson.Type = type;

                _data.SaveChanges(DataContext.LESSON);

                LoadLessons();
                MessageBox.Show("Lesson was updated successfully.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }



        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedLesson == null)
                return;

            _data.Schedules.RemoveAll(t => t.LessonId == selectedLesson.Id);
            _data.Lessons.Remove(selectedLesson);
            _data.SaveChanges(DataContext.LESSON);
            dataGridView_Lessons.Rows.RemoveAt(selectedIndex);

            if (selectedIndex > -1 && selectedIndex < _data.Lessons.Count)
            {
                selectedLesson = _data.Lessons.OrderBy(t => t.Name).ToList()[selectedIndex];
            }
            else selectedLesson = null;
            SetLesson();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_Lessons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView_Lessons.CurrentRow.Index;
            if (selectedIndex < _data.Lessons.Count)
            {
                selectedLesson = _data.Lessons
                    .Where(t => t.Name.Equals(dataGridView_Lessons[0, selectedIndex].Value.ToString())
                        && t.Type.Equals(dataGridView_Lessons[ 1, selectedIndex].Value.ToString()))
                    .First();
            }
            else selectedLesson = null;
            SetLesson();
        }
    }
}
