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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeachers();
        }

        void ShowTeachers()
        {
            listViewTeachers.Items.Clear();
            foreach (TeachersSet teachersSet in Program.abc.TeachersSet)
            {
                ListViewItem item = new ListViewItem(new string[]
               {
                    teachersSet.ID.ToString(),
                    teachersSet.Name,
                    teachersSet.Email.ToString()
               });
                item.Tag = teachersSet;
                listViewTeachers.Items.Add(item);
            }
            listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                if (textBoxName.Text != "" && textBoxEmail.Text != "")
                {
                    TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                    teachersSet.Name = textBoxName.Text;
                    teachersSet.Email = textBoxEmail.Text;
                    Program.abc.SaveChanges();
                    ShowTeachers();
                }
                else
                {
                    MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
                }
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxEmail.Text != "")
            {
                TeachersSet teachersSet = new TeachersSet();
                teachersSet.Name = textBoxName.Text;
                teachersSet.Email = textBoxEmail.Text;

                Program.abc.TeachersSet.Add(teachersSet);
                Program.abc.SaveChanges();
                ShowTeachers();
            }
            else
            {
                MessageBox.Show("Заполните все необходимые поля", "Невозможно внести данные!", MessageBoxButtons.OK);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeachers.SelectedItems.Count == 1)
                {
                    TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                    Program.abc.TeachersSet.Remove(teachersSet);
                    Program.abc.SaveChanges();
                    ShowTeachers();
                }
                textBoxName.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                TeachersSet teachersSet = listViewTeachers.SelectedItems[0].Tag as TeachersSet;
                textBoxName.Text = teachersSet.Name;
                textBoxEmail.Text = teachersSet.Email;
            }
            else
            {
                textBoxName.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == false) return;
            if (e.KeyChar == Convert.ToChar(Keys.Back)) return;
            e.Handled = true;
            textBoxName.Clear();
        }
    }
}
