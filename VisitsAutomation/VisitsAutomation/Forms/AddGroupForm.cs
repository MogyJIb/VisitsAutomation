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
    public partial class AddGroupForm : Form
    {
        private Group selectedGroup;
        private int selectedIndex = 0;
        private DataContext _data;

        public AddGroupForm()
        {
            InitializeComponent();
        }

        public AddGroupForm(DataContext data) : this()
        {
            this._data = data;
            LoadGroups();

            dataGridView_Groups.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label_Faculty_Click(object sender, EventArgs e)
        {

        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            string name = textBox_Group.Text;
            string department = textBox_Department.Text;
            string faculty = textBox_Faculty.Text;

            int id = _data.Groups.Count + 1;

            Group group = new Group {Id = id,
                Name = name,
                DepartmentName = department,
                FacultyName = faculty};

            var findGroups = _data.Groups.Where(t => t.Equals(group));

            if (findGroups.Count() > 0)
            {
                MessageBox.Show("This group alredy exist!","warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _data.Groups.Add(group);
                _data.SaveChanges(DataContext.GROUP);

                MessageBox.Show("Group was added successfully.", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void LoadGroups()
        {
            dataGridView_Groups.Rows.Clear();
            var groups = _data.Groups.OrderBy(t => t.Name).ToList();
            foreach(Group group in groups)
            {
                dataGridView_Groups.Rows.Add(
                        new string[]
                        {
                            group.Name,
                            group.DepartmentName,
                            group.FacultyName
                        });
            }
            if (groups.Count > 0)
            {
                selectedGroup = groups.First();
                SetGroup();
            }
            
        }

        private void SetGroup()
        {
            if (selectedGroup != null)
            {
                textBox_Group.Text = selectedGroup.Name;
                textBox_Department.Text = selectedGroup.DepartmentName;
                textBox_Faculty.Text = selectedGroup.FacultyName;
            }
            else
            {
                textBox_Group.Text = "";
                textBox_Department.Text = "";
                textBox_Faculty.Text = "";
            }
        }

        private void dataGridView_Groups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = dataGridView_Groups.CurrentRow.Index;
            if (selectedIndex  < _data.Groups.Count)
            {
                selectedGroup = _data.Groups.OrderBy(t => t.Name).ToList()[selectedIndex];
            }
            else selectedGroup = null;
            SetGroup();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (selectedGroup != null)
            {
                _data.Groups.Remove(selectedGroup);
                _data.SaveChanges(DataContext.GROUP);
                dataGridView_Groups.Rows.RemoveAt(selectedIndex);
                if (selectedIndex + 1 < _data.Groups.Count)
                {
                    selectedIndex++;
                    selectedGroup = _data.Groups.OrderBy(t => t.Name).ToList()[selectedIndex];
                }
                else if (selectedIndex - 1 > -1)
                {
                    selectedIndex--;
                    selectedGroup = _data.Groups.OrderBy(t => t.Name).ToList()[selectedIndex];
                }
                else selectedGroup = null;
                SetGroup();
            }
     
        }
    }
}
