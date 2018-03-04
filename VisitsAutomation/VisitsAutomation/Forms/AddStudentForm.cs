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
    public partial class AddStudentForm : Form
    {     
        private Student selectedStudent;
        private int selectedIndex  = 0;
        private DataContext _data;

        public AddStudentForm()
        {
            InitializeComponent();
            dataGridView_Students.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }


        public AddStudentForm(DataContext data) : this()
        {
            this._data = data;        

            var groups = _data.Groups.OrderBy(t => t.Name).Select(t => t.Name);
            foreach (string group in groups)
                comboBox_Group.Items.Add(group);
            if (groups.Count() > 0)
                comboBox_Group.SelectedIndex = 0;


            LoadStudents();
        }

        private void LoadStudents()
        {
            dataGridView_Students.Rows.Clear();
            var students = _data.Students.OrderBy(t => t.FullName).ToList();
            foreach (Student student in students)
            {
                var group = _data.Groups.Where(t => t.Id == student.GroupId).First();
                dataGridView_Students.Rows.Add(
                        new string[]
                        {
                            student.FullName,
                            student.Course.ToString(),
                            group.Name,
                            student.Subgroup.ToString()

                        });
            }
            if (students.Count > 0)
            {
                selectedStudent = students.First();
                selectedStudent.Group = _data.Groups.Where(t => t.Id == selectedStudent.GroupId).First();
                SetStudent();
            }

        }

        private void SetStudent()
        {
            if (selectedStudent != null)
            {
                textBox_Course.Text = selectedStudent.Course.ToString();
                textBox_FullName.Text = selectedStudent.FullName;
                textBox_Subgroup.Text = selectedStudent.Subgroup.ToString();

                comboBox_Group.SelectedIndex = _data.Groups
                    .OrderBy(t => t.Name)
                    .Select(t => t.Name)
                    .ToList()
                    .IndexOf(selectedStudent.Group.Name);
               
            }
            else
            {
                textBox_Course.Text = "";
                textBox_FullName.Text = "";
                textBox_Subgroup.Text = "";
                comboBox_Group.SelectedIndex = 0;
            }
        }


        private void button_Add_Click(object sender, System.EventArgs e)
        {
            int course = 0, subgroup = 0;
            try
            {
                course = System.Int32.Parse(textBox_Course.Text);
                subgroup = System.Int32.Parse(textBox_Subgroup.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("You enter incorrect number!.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }

            if (_data.Groups.Count <= 0)
            {
                MessageBox.Show("There is no groups!.",
                        "error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                return;
            }          

            string groupName = _data.Groups
                    .OrderBy(t => t.Name)
                    .Select(t => t.Name)
                    .ToList()[comboBox_Group.SelectedIndex];         
         
            var group = _data.Groups
                .Where(t => t.Name.Equals(groupName))
                .First();

            string fullName = textBox_FullName.Text;
        
            int id = 1;
            if (_data.Students.Count > 0)
                id = _data.Students.Select(t => t.Id).Max() + 1;

            Student student;
            if (selectedStudent == null)
            {
                student = new Student
                {
                    Id = id,
                    FullName = fullName,
                    GroupId = group.Id,
                    Subgroup = subgroup,
                    Course = course
                };
                var findStudent = _data.Students.Where(t => t.FullName.Equals(student.FullName));

                if (findStudent.Count() > 0)
                {
                    MessageBox.Show(
                        "This student alredy exist!",
                        "warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                        );
                }
                else
                {
                    _data.Students.Add(student);
                    _data.SaveChanges(DataContext.STUDENT);
                    MessageBox.Show("Student was added successfully.",
                        "information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    LoadStudents();

                }
            }
            else
            {
                selectedStudent.FullName = fullName;
                selectedStudent.GroupId = group.Id;
                selectedStudent.Subgroup = subgroup;
                selectedStudent.Course = course;
                _data.SaveChanges(DataContext.STUDENT);

                LoadStudents();
                MessageBox.Show("Student was updated successfully.",
                    "information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }



        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedStudent == null)
                return;

            _data.Students.Remove(selectedStudent);
            _data.SaveChanges(DataContext.STUDENT);
            dataGridView_Students.Rows.RemoveAt(selectedIndex);

            if (selectedIndex > -1 && selectedIndex < _data.Students.Count)
            {
                selectedStudent = _data.Students.Where(t => t.FullName.Equals(dataGridView_Students[0, selectedIndex].Value.ToString()))
                    .First();
                selectedStudent.Group = _data.Groups.Where(t => t.Id == selectedStudent.GroupId).First();
            }
            else selectedStudent = null;
            SetStudent();

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView_Students.CurrentRow.Index;
            if (selectedIndex < _data.Schedules.Count)
            {
                selectedStudent = _data.Students.Where(t => t.FullName.Equals(dataGridView_Students[0, selectedIndex].Value.ToString()))
                    .First();
                selectedStudent.Group = _data.Groups.Where(t => t.Id == selectedStudent.GroupId).First();
            }
            else selectedStudent = null;
            SetStudent();
        }
    }
}
