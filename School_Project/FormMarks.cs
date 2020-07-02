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
    public partial class FormMarks : Form
    {
        public FormMarks()
        {
            InitializeComponent();
            ShowMarks();
            ShowStudents();
            ShowSubjects();

        }
        void ShowMarks()
        {
            listViewMarks.Items.Clear();
            foreach (MarksSet marksSet in Program.abc.MarksSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    marksSet.ID.ToString(),
                    marksSet.StudentsSet.Name,
                    marksSet.SubjectsSet.Subject,
                    marksSet.Mark.ToString()
                });
                item.Tag = marksSet;
                listViewMarks.Items.Add(item);
            }
            listViewMarks.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        void ShowStudents()
        {
            comboBoxStudent.Items.Clear();
            foreach (StudentsSet studentsSet in Program.abc.StudentsSet)
            {
                string[] item = { studentsSet.ID.ToString() + ".", studentsSet.Name };
                comboBoxStudent.Items.Add(string.Join(" ", item));
            }
        }
        
        void ShowSubjects()
        {
            comboBoxSubject.Items.Clear();
            foreach (SubjectsSet subjectsSet in Program.abc.SubjectsSet)
            {
                string[] item = { subjectsSet.ID.ToString() + ".", subjectsSet.Subject };
                comboBoxSubject.Items.Add(string.Join(" ", item));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStudent.SelectedItem != null && comboBoxSubject.SelectedItem != null && 
                textBoxMark.Text != "")
            {
                int temp;
                bool mark = int.TryParse(textBoxMark.Text, out temp);
                if (!mark) MessageBox.Show("Оценка - это число", "Неверный формат оценки", MessageBoxButtons.OK);
                else 
                {
                    MarksSet marksSet = new MarksSet();
                    marksSet.id_Student = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                    marksSet.id_Subject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                    marksSet.Mark = Convert.ToInt32(textBoxMark.Text);
                    Program.abc.MarksSet.Add(marksSet);
                    Program.abc.SaveChanges();
                    ShowMarks();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewMarks.SelectedItems.Count == 1)
            {
                if (comboBoxStudent.SelectedItem != null && comboBoxSubject.SelectedItem != null &&
                textBoxMark.Text != "")
                {
                    int temp;
                    bool mark = int.TryParse(textBoxMark.Text, out temp);
                    if (!mark) MessageBox.Show("Оценка - это число", "Неверный формат оценки", MessageBoxButtons.OK);
                    else
                    {
                        MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
                        marksSet.id_Student = Convert.ToInt32(comboBoxStudent.SelectedItem.ToString().Split('.')[0]);
                        marksSet.id_Subject = Convert.ToInt32(comboBoxSubject.SelectedItem.ToString().Split('.')[0]);
                        marksSet.Mark = Convert.ToInt32(textBoxMark.Text);
                        Program.abc.SaveChanges();
                        ShowMarks();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewMarks.SelectedItems.Count == 1)
                {
                    MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
                    Program.abc.MarksSet.Remove(marksSet);
                    Program.abc.SaveChanges();
                    ShowStudents();
                }
                comboBoxStudent.SelectedItem = null;
                comboBoxSubject.SelectedItem = null;
                textBoxMark.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewMarks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMarks.SelectedItems.Count ==1)
            {
                MarksSet marksSet = listViewMarks.SelectedItems[0].Tag as MarksSet;
                comboBoxStudent.SelectedIndex = comboBoxStudent.FindString(marksSet.id_Student.ToString());
                comboBoxSubject.SelectedIndex = comboBoxSubject.FindString(marksSet.id_Subject.ToString());
                textBoxMark.Text = marksSet.Mark.ToString();
            }
            else
            {
                comboBoxStudent.SelectedItem = null;
                comboBoxSubject.SelectedItem = null;
                textBoxMark.Text = "";
            }
        }
    }
}
