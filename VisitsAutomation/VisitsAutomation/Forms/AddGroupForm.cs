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
        private DataContext _data;

        public AddGroupForm()
        {
            InitializeComponent();
        }

        public AddGroupForm(DataContext data) : this()
        {
            this._data = data;
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
    }
}
