using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using VisitsAutomation.Handlers;
using VisitsAutomation.Models;
using VisitsAutomation.Utils;

namespace VisitsAutomation.Forms
{
    public partial class MainForm : Form
    {
        private DataContext _data;
        private Dictionary<Student, Absent> studentAbsents;
        private Dictionary<string, ComboBox> chechBoxs;
        private DateTime selectedDate;
        private int selectedGroupId;

        public MainForm()
        {
            studentAbsents = new Dictionary<Student, Absent>();
            chechBoxs= new Dictionary<string, ComboBox>();
            selectedDate = DateTime.Now;
            selectedGroupId = -1;
           _data = new DataContext();

            InitializeComponent();

            ElementMaker.MakeGroupsTreeView(_data,treeView_Groups,comboBox_Faculty);
        }
        
       
        private void treeView_Groups_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
            var groups = _data.Groups
                .Where(t => t.Name.Equals(treeView_Groups.SelectedNode.Text));
            if(groups.Count()>0)
                ElementMaker.MakeStudentsDataGrid(groups.First().Id, dataGridView_StudentsAbsent,_data);
        }

        private void comboBox_Faculty_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            flowLayoutPanel_Absents.Controls.Clear();
            string selected = comboBox_Faculty.SelectedItem.ToString();
            comboBox_Department.Items.Clear();
            var departments = new HashSet<string>(_data.Groups
                .Where(t => t.FacultyName.Equals(selected))
                .Select(t => t.DepartmentName));
            foreach (var department in departments)
            {
                comboBox_Department.Items.Add(department);
            }


            comboBox_Department.SelectedIndex = 0;
        }

        private void comboBox_Department_SelectedIndexChanged(object sender, System.EventArgs e)
        {

            flowLayoutPanel_Absents.Controls.Clear();
            string selected = comboBox_Department.SelectedItem.ToString();
            comboBox_Group.Items.Clear();
            var groups = new HashSet<string>(_data.Groups
                .Where(t => t.DepartmentName.Equals(selected))
                .Select(t => t.Name));
            foreach (var group in groups)
            {
                comboBox_Group.Items.Add(group);
            }
            comboBox_Group.SelectedIndex = 0;
        }

        private void comboBox_Group_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel_Absents.Controls.Clear();
            string selectedGroup = comboBox_Group.SelectedItem.ToString();
            var group = _data.Groups.Where(t => t.Name.Equals(selectedGroup)).First();
            selectedGroupId = group.Id;

            ElementMaker.MakeSubjectsList(selectedGroupId, selectedDate,listBox_Subjects,_data);
        }

        private void dateTimePicker_ScheduleDate_ValueChanged(object sender, EventArgs e)
        {
            flowLayoutPanel_Absents.Controls.Clear();
            selectedDate = dateTimePicker_ScheduleDate.Value;
            ElementMaker.MakeSubjectsList(selectedGroupId, selectedDate, listBox_Subjects, _data);
        }

        private void listBox_Subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel_Absents.Controls.Clear();
            studentAbsents.Clear();
            chechBoxs.Clear();
            
            int index = listBox_Subjects.SelectedIndex;

           var selectedSchedule = _data.Schedules
                .Where(t => t.GroupId == selectedGroupId && Comparator.Equal(t.Date, selectedDate))
                .OrderBy(t => t.Number)
                .ToList()[index];

            var studentsList = new HashSet<Student>(_data.Students
                .Where(t => t.GroupId == selectedGroupId)
                .OrderBy(t => t.FullName));

            foreach (var student in studentsList)
            {
                var absent = _data.Absents
                    .Where(t => t.ScheduleId == selectedSchedule.Id
                                && t.StudentId == student.Id)
                    .First();
                flowLayoutPanel_Absents.Controls.Add(ElementMaker.CreateContainerLine(student.FullName, absent.Cause,chechBoxs));
                studentAbsents.Add(student,absent);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {           
            foreach (var entry in studentAbsents)
            {
                var absent = entry.Value;
                ComboBox comboBox = chechBoxs[entry.Key.FullName];
                absent.Cause = comboBox.SelectedItem.ToString();
            }
            _data.SaveChanges(DataContext.ABSENT);
        }

        private void groupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGroupForm addGroupForm = new AddGroupForm(_data);
            addGroupForm.ShowDialog();
            

            ElementMaker.MakeGroupsTreeView(_data, treeView_Groups, comboBox_Faculty);
        }

        private void tabPage_Schedule_Click(object sender, EventArgs e)
        {

        }
    }
}
