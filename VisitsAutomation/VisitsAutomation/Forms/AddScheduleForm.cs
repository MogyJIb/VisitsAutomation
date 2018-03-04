
using System;
using System.Linq;
using System.Windows.Forms;
using VisitsAutomation.Models;

namespace VisitsAutomation.Forms
{
    public partial class AddScheduleForm : Form
    {
        private Schedule selectedSchedule;
        private int selectedIndex = 0;
        private DataContext _data;

        public AddScheduleForm()
        {
            InitializeComponent();
            dataGridView_Schedules.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            comboBox_Day.SelectedIndex = 0;
        }


        public AddScheduleForm(DataContext data) : this()
        {
            this._data = data;

            var lessons = _data.Lessons.OrderBy(t => t.Name);
            foreach (Lesson lesson in lessons)
                comboBox_Lesson.Items.Add(lesson.Name+" ["+lesson.Type+"]");
            if(lessons.Count()>0)
                comboBox_Lesson.SelectedIndex = 0;

            var groups = _data.Groups.OrderBy(t => t.Name).Select(t => t.Name);
            foreach (string group in groups)
                comboBox_Group.Items.Add(group);
            if (groups.Count() > 0)
                comboBox_Group.SelectedIndex = 0;


            LoadSchedules();
        }

        private void LoadSchedules()
        {
            dataGridView_Schedules.Rows.Clear();
            var schedules = _data.Schedules.OrderBy(t => t.GroupId).ToList();
            foreach (Schedule schedule in schedules)
            {
                var lesson = _data.Lessons.Where(t => t.Id == schedule.LessonId).First();
                var group = _data.Groups.Where(t => t.Id == schedule.GroupId).First();
                dataGridView_Schedules.Rows.Add(
                        new string[]
                        {
                            group.Name,
                            schedule.Day.ToString(),
                            schedule.Number.ToString(),
                            lesson.Name
                            
                        });
            }
            if (schedules.Count > 0)
            {
                selectedSchedule = schedules.First();
                selectedSchedule.Lesson = _data.Lessons.Where(t => t.Id == selectedSchedule.LessonId).First();
                selectedSchedule.Group = _data.Groups.Where(t => t.Id == selectedSchedule.GroupId).First();
                SetSchedule();
            }

        }

        private void SetSchedule()
        {
            if (selectedSchedule != null)
            {
                textBox_Number.Text = selectedSchedule.Number.ToString();
                comboBox_Day.SelectedIndex = Models.DayOfWeek.IndexOf(selectedSchedule.Day);

                comboBox_Group.SelectedIndex = _data.Groups
                    .OrderBy(t => t.Name)
                    .Select(t => t.Name)
                    .ToList()
                    .IndexOf(selectedSchedule.Group.Name);

                comboBox_Lesson.SelectedIndex = _data.Lessons
                   .OrderBy(t => t.Name)
                   .Select(t => t.Name + " [" + t.Type + "]")
                   .ToList()
                   .IndexOf(selectedSchedule.Lesson.Name + " [" + selectedSchedule.Lesson.Type + "]");
            }
            else
            {
                textBox_Number.Text = "";
                comboBox_Day.SelectedIndex = 0;
                comboBox_Group.SelectedIndex = 0;
                comboBox_Lesson.SelectedIndex = 0;
            }
        }


        private void button_Add_Click(object sender, System.EventArgs e)
        {
            int number = 0;
            try
            {
                number = System.Int32.Parse(textBox_Number.Text);
            }
            catch(System.Exception ex)
            {
                MessageBox.Show("You enter incorrect number!.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }
             
            if(_data.Groups.Count <= 0)
            {
                MessageBox.Show("There is no groups!.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            if (_data.Lessons.Count <= 0)
            {
                MessageBox.Show("There is no lessons!.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            string groupName = _data.Groups
                    .OrderBy(t => t.Name)
                    .Select(t => t.Name)
                    .ToList()[comboBox_Group.SelectedIndex];
            string lessonFullName = _data.Lessons
                    .OrderBy(t => t.Name)
                    .Select(t => t.Name + " [" + t.Type + "]")
                    .ToList()[comboBox_Lesson.SelectedIndex];

            string lessonName = lessonFullName.Split(' ')[0];
            string lessonType = lessonFullName.Split(' ')[1].Replace('[',' ').Replace(']',' ').Trim();

            var group = _data.Groups
                .Where(t => t.Name.Equals(groupName))
                .First();

            var lesson = _data.Lessons
                .Where(t => t.Name.Equals(lessonName) && t.Type.Equals(lessonType))
                .First();

            var day = comboBox_Day.SelectedItem.ToString();

            int id = 1;
            if (_data.Schedules.Count > 0)
                id = _data.Schedules.Select(t => t.Id).Max() + 1;


            Schedule schedule;
            if (selectedSchedule == null)
            {
                schedule = new Schedule
                {
                    Id = id,
                    LessonId = lesson.Id,
                    GroupId = group.Id,
                    Day = day,
                    Number = number
                };
                var findSchedule = _data.Schedules.Where(t => t.Equals(schedule));

                if (findSchedule.Count() > 0)
                {
                    MessageBox.Show(
                        "This shedule alredy exist!",
                        "warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    _data.Schedules.Add(schedule);
                    _data.SaveChanges(DataContext.SCHEDULE);
                    MessageBox.Show("Lesson was added successfully.",
                        "information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadSchedules();

                }
            }
            else
            {
                    selectedSchedule.LessonId = lesson.Id;
                selectedSchedule.GroupId = group.Id;
                selectedSchedule.Day = day;
                selectedSchedule.Number = number;

                _data.SaveChanges(DataContext.SCHEDULE);

                LoadSchedules();
                MessageBox.Show("Lesson was updated successfully.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }



        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedSchedule == null)
                return;

            _data.Schedules.Remove(selectedSchedule);
            _data.SaveChanges(DataContext.SCHEDULE);
            dataGridView_Schedules.Rows.RemoveAt(selectedIndex);

            if (selectedIndex > -1 && selectedIndex < _data.Schedules.Count)
            {
                string grName = dataGridView_Schedules[0, selectedIndex].Value.ToString();
                var groupInGrid = _data.Groups.Where(t => t.Name.Equals(grName)).First();

                selectedSchedule = _data.Schedules.Where(t => t.Day.Equals(dataGridView_Schedules[1, selectedIndex].Value.ToString())
               && t.Number == Int32.Parse(dataGridView_Schedules[2, selectedIndex].Value.ToString())
               && t.GroupId == groupInGrid.Id)
                   .First();
                selectedSchedule.Lesson = _data.Lessons.Where(t => t.Id == selectedSchedule.LessonId).First();
                selectedSchedule.Group = _data.Groups.Where(t => t.Id == selectedSchedule.GroupId).First();
            }
            else selectedSchedule = null;
            SetSchedule();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView_Schedules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView_Schedules.CurrentRow.Index;
            if (selectedIndex < _data.Schedules.Count)
            {
                string grName = dataGridView_Schedules[0, selectedIndex].Value.ToString();
                var groupInGrid = _data.Groups.Where(t => t.Name.Equals(grName)).First();

                selectedSchedule = _data.Schedules.Where(t => t.Day.Equals(dataGridView_Schedules[1, selectedIndex].Value.ToString())
               && t.Number == Int32.Parse(dataGridView_Schedules[2, selectedIndex].Value.ToString())
               && t.GroupId == groupInGrid.Id)
                   .First();
                selectedSchedule.Lesson = _data.Lessons.Where(t => t.Id == selectedSchedule.LessonId).First();
                selectedSchedule.Group = _data.Groups.Where(t => t.Id == selectedSchedule.GroupId).First();
            }
            else selectedSchedule = null;
            SetSchedule();
        }
    }
}
