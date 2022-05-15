using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    { 
        private readonly Form1 _parent;

        public Form2()
        {
        }

        public Form2(Form1 parent)
        {
            InitializeComponent();
            _parent = parent;
        }

            public void Clear()
        {
            textName.Text = textLast_name.Text = textCourse.Text = textGroupe.Text = university_text.Text = faculty_text.Text = string.Empty;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (textName.Text.Trim().Length < 2)
            {
                MessageBox.Show("Имя студента не введена!");
                return;
            }
            if (textLast_name.Text.Trim().Length < 1)
            {
                MessageBox.Show("Фамилия студента не введена!");
                return;
            }
            if (textCourse.Text.Trim().Length == 0)
            {
                MessageBox.Show("Какой курс?");
                return;

            }
            if (textGroupe.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите группу!");
                return;
            }
            if (btnSave.Text == "Добавить")
            {
                Student std = new Student(textName.Text.Trim(), textLast_name.Text.Trim(), textCourse.Text.Trim(), textGroupe.Text.Trim(),
                    university_text.Text.Trim(), faculty_text.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            _parent.Display();
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

    
