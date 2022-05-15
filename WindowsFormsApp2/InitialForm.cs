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
    public partial class InitialForm : Form
    {
        AddStudentForm form;
        RateStudentForm form3;
    
        public InitialForm()
        {
            InitializeComponent();
            form = new AddStudentForm(this);
            form3 = new RateStudentForm(this);
        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT id, first_name, last_name, course, groupe, university, faculty FROM students", dataGridView1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm();
            form.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddStudentForm form = new AddStudentForm(this);
            form.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_Paint(object sender, PaintEventArgs e)
        {
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT * FROM  students WHERE first_name LIKE '%" + SearchForm1.Text + "%'", dataGridView1);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            RateStudentForm form3 = new RateStudentForm();
            form3.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
