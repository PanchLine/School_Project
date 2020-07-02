using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project
{
    public partial class FormSubjects : Form
    {
        public FormSubjects()
        {
            InitializeComponent();
            ShowSubjects();
            ShowTeachers();
        }
        void ShowSubjects()
        {
            listViewSubjects.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.abc.SubjectsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    subjectsSet.ID.ToString(),
                    subjectsSet.Subject,
                    subjectsSet.TeachersSet.Name
                });
                item.Tag = subjectsSet;
                listViewSubjects.Items.Add(item);
            }
            listViewSubjects.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowTeachers()
        {
            comboBoxTeacher.Items.Clear();
            foreach (TeachersSet teachersSet in Program.abc.TeachersSet)
            {
                string[] item = { teachersSet.ID.ToString() + ".", teachersSet.Name };
                comboBoxTeacher.Items.Add(string.Join(" ", item));
            }
        }

        private void listViewSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count ==1)
            {
                SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                comboBoxTeacher.SelectedIndex = comboBoxTeacher.FindString(subjectsSet.id_Teacher.ToString());
            }
            else
            {
                comboBoxTeacher.SelectedItem = null;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewSubjects.SelectedItems.Count == 1)
            {
                if (comboBoxTeacher.SelectedItem != null)
                {
                    SubjectsSet subjectsSet = listViewSubjects.SelectedItems[0].Tag as SubjectsSet;
                    subjectsSet.id_Teacher = Convert.ToInt32(comboBoxTeacher.SelectedItem.ToString().Split('.')[0]);
                    Program.abc.SaveChanges();
                    ShowSubjects();
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }
    }
}
