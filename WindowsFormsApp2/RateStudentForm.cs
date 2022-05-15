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
    public partial class RateStudentForm : Form

    {
        private readonly InitialForm _parent;

        public RateStudentForm()
        {
        }

        public RateStudentForm(InitialForm parent)
        {
            InitializeComponent();
            _parent = parent;

        }
        public void Clear2()
        {
            comboBox1.Text = comboBox2.Text = comboBox3.Text = comboBox4.Text = string.Empty;

        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Добавить")
            {
                Grade grd = new Grade(comboBox1.Text.Trim(), comboBox2.Text.Trim(), comboBox3.Text.Trim(), comboBox4.Text.Trim());
                DbStudent.AddGrade(grd);
                Clear2();
            }
            _parent.Display();
        }
    }
}
