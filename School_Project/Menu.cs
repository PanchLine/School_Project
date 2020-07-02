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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            Form formStudents = new FormStudents();
            formStudents.Show();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            Form formTeachers = new FormTeachers();
            formTeachers.Show();
        }

        private void buttonSubjects_Click(object sender, EventArgs e)
        {
            Form formSubjects = new FormSubjects();
            formSubjects.Show();
        }

        private void buttonMarks_Click(object sender, EventArgs e)
        {
            Form formMarks = new FormMarks();
            formMarks.Show();
        }
    }
}
