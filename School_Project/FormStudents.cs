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
    public partial class FormStudents : Form
    {
        public FormStudents()
        {
            InitializeComponent();
            ShowStudents();
        }

        void ShowStudents()
        {
            listViewStudents.Items.Clear();
            foreach (StudentsSet studentsSet in Program.abc.StudentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    studentsSet.ID.ToString(),
                    studentsSet.Name,
                    studentsSet.Dob.ToString().Substring(0, studentsSet.Dob.ToString().Length-8)
               });
                item.Tag = studentsSet;
                listViewStudents.Items.Add(item);
            }
            listViewStudents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxDob.Text != "")
            {
                DateTime temp;
                bool date = DateTime.TryParse(textBoxDob.Text, out temp);
                if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                else
                {
                    StudentsSet studentsSet = new StudentsSet();
                    studentsSet.Name = textBoxName.Text;
                    studentsSet.Dob = Convert.ToDateTime(textBoxDob.Text);

                    Program.abc.StudentsSet.Add(studentsSet);
                    Program.abc.SaveChanges();
                    ShowStudents();
                }
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count ==1)
            {
                if (textBoxName.Text != "" && textBoxDob.Text != "")
                {
                    DateTime temp;
                    bool date = DateTime.TryParse(textBoxDob.Text, out temp);
                    if (!date) MessageBox.Show("Введите дату в формате: ДД.ММ.ГГГГ", "Неверный формат даты", MessageBoxButtons.OK);
                    else
                    {
                        StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                        studentsSet.Name = textBoxName.Text;
                        studentsSet.Dob = Convert.ToDateTime(textBoxDob.Text);
                        Program.abc.SaveChanges();
                        ShowStudents();
                    }
                }
                else
                {
                    MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewStudents.SelectedItems.Count == 1)
                {
                    StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                    Program.abc.StudentsSet.Remove(studentsSet);
                    Program.abc.SaveChanges();
                    ShowStudents();
                }
                textBoxName.Text = "";
                textBoxDob.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStudents.SelectedItems.Count == 1)
            {
                StudentsSet studentsSet = listViewStudents.SelectedItems[0].Tag as StudentsSet;
                textBoxName.Text = studentsSet.Name;
                textBoxDob.Text = studentsSet.Dob.ToString().Substring(0, studentsSet.Dob.ToString().Length - 8);
            }
            else
            {
                textBoxName.Text = "";
                textBoxDob.Text = "";
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxName.Clear();
        }
    }
}
