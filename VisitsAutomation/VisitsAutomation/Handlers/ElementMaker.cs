using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisitsAutomation.Models;
using VisitsAutomation.Utils;

namespace VisitsAutomation.Handlers
{
    public class ElementMaker
    {
        public static SplitContainer CreateContainerLine(string name, string absent, Dictionary<string,ComboBox> chechBoxs)
        {
            SplitContainer container = new SplitContainer();
            container.Name = "SplitContainer_" + name;
            container.Size = new System.Drawing.Size(300, 22);
            container.Panel1MinSize = 170;
            container.Margin += new Padding(20, 10, 0, 0);

            Label label = new Label();
            label.Text = name;
            label.Name = "label_" + name;
            container.Panel1.Controls.Add(label);

            ComboBox checkedList = new ComboBox();
            checkedList.Name = "comboBox_" + name;
            checkedList.DropDownStyle = ComboBoxStyle.DropDownList;
            checkedList.FlatStyle = FlatStyle.Popup;
            checkedList.Margin = new Padding(0, 0, 0, 0);
            checkedList.Items.AddRange(new string[] { Absent.PRESENT, Absent.ABSENT, Absent.CAUSE });
            switch (absent)
            {
                case Absent.ABSENT:
                    checkedList.SelectedIndex = 1;
                    break;
                case Absent.CAUSE:
                    checkedList.SelectedIndex = 2;
                    break;
                default:
                    checkedList.SelectedIndex = 0;
                    break;
            }
            container.Panel2.Controls.Add(checkedList);

            chechBoxs.Add(name, checkedList);
            return container;
        }

        public static void MakeSubjectsList(int groupId, DateTime date, ListBox listBox,DataContext _data)
        {
            listBox.Items.Clear();

            var subjects = _data.Schedules
                .Where(t => t.GroupId == groupId && Comparator.Equal(t.Date, date))
                .OrderBy(t => t.Number)
                .ToList();

            foreach (var subject in subjects)
            {
                var lesson = _data.Lessons
                    .Where(t => t.Id == subject.LessonId)
                    .First();
                listBox.Items.Add(subject.Number + ". " + lesson.Name);
            }

            if (listBox.Items.Count > 0)
                listBox.SelectedIndex = 0;
        }

        public static void MakeStudentsDataGrid(int groupId,DataGridView dataGrid, DataContext _data)
        {
            dataGrid.Rows.Clear();

            var studentsList = new HashSet<Student>(_data.Students.OrderBy(t => t.FullName));

            int countAbsents = 0;
            foreach (var student in studentsList)
            {
                if (student.GroupId == groupId)
                {
                    countAbsents = _data.Absents
                        .Where(t => t.StudentId == student.Id && !t.Cause.Equals(Absent.PRESENT))
                        .ToList()
                        .Count;

                    dataGrid.Rows.Add(
                        new string[]
                        {
                            student.FullName,
                            student.Course.ToString(),
                            countAbsents.ToString()
                        });
                }
            }

        }

        public static void MakeGroupsTreeView(DataContext _data,TreeView treeView,ComboBox comboBox)
        {
            comboBox.Items.Clear();
            treeView.Nodes.Clear();

            var faculties = new HashSet<string>(_data.Groups.Select(t => t.FacultyName));

            foreach (var faculty in faculties)
            {
                TreeNode facultyNode = new TreeNode(faculty);
                var facultyDepartments = new HashSet<string>(_data.Groups
                    .Where(t => t.FacultyName.Equals(faculty))
                    .Select(t => t.DepartmentName));
                foreach (var department in facultyDepartments)
                {
                    TreeNode departmentNode = new TreeNode(department);
                    var departmentsGroup = new HashSet<string>(_data.Groups
                        .Where(t => t.DepartmentName.Equals(department))
                        .Select(t => t.Name));
                    foreach (var group in departmentsGroup)
                        departmentNode.Nodes.Add(group);

                    facultyNode.Nodes.Add(departmentNode);
                }
                treeView.Nodes.Add(facultyNode);

                comboBox.Items.Add(faculty);
            }

            comboBox.SelectedIndex = 0;
        }

    }
}
