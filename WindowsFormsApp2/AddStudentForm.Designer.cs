namespace WindowsFormsApp2
{
    partial class AddStudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textClass_lable = new System.Windows.Forms.Label();
            this.TextSelectionLable = new System.Windows.Forms.Label();
            this.textLast_name = new System.Windows.Forms.TextBox();
            this.textCourse = new System.Windows.Forms.TextBox();
            this.textGroupe = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.university_text = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.faculty_text = new System.Windows.Forms.ComboBox();
            this.form2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 105);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(58, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добовление студента";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(41, 143);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 10;
            this.textName.TextChanged += new System.EventHandler(this.textName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Фамилия";
            // 
            // textClass_lable
            // 
            this.textClass_lable.AutoSize = true;
            this.textClass_lable.Location = new System.Drawing.Point(38, 205);
            this.textClass_lable.Name = "textClass_lable";
            this.textClass_lable.Size = new System.Drawing.Size(31, 13);
            this.textClass_lable.TabIndex = 13;
            this.textClass_lable.Text = "Курс";
            // 
            // TextSelectionLable
            // 
            this.TextSelectionLable.AutoSize = true;
            this.TextSelectionLable.Location = new System.Drawing.Point(38, 244);
            this.TextSelectionLable.Name = "TextSelectionLable";
            this.TextSelectionLable.Size = new System.Drawing.Size(42, 13);
            this.TextSelectionLable.TabIndex = 14;
            this.TextSelectionLable.Text = "Группа";
            // 
            // textLast_name
            // 
            this.textLast_name.Location = new System.Drawing.Point(41, 182);
            this.textLast_name.Name = "textLast_name";
            this.textLast_name.Size = new System.Drawing.Size(100, 20);
            this.textLast_name.TabIndex = 15;
            // 
            // textCourse
            // 
            this.textCourse.Location = new System.Drawing.Point(41, 221);
            this.textCourse.Name = "textCourse";
            this.textCourse.Size = new System.Drawing.Size(100, 20);
            this.textCourse.TabIndex = 16;
            // 
            // textGroupe
            // 
            this.textGroupe.Location = new System.Drawing.Point(41, 260);
            this.textGroupe.Name = "textGroupe";
            this.textGroupe.Size = new System.Drawing.Size(100, 20);
            this.textGroupe.TabIndex = 17;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(41, 299);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Добавить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Университет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Факултет";
            // 
            // university_text
            // 
            this.university_text.FormattingEnabled = true;
            this.university_text.Items.AddRange(new object[] {
            "ХГУ",
            "ТГУ",
            "ТМУ",
            "ТПУ"});
            this.university_text.Location = new System.Drawing.Point(41, 43);
            this.university_text.Name = "university_text";
            this.university_text.Size = new System.Drawing.Size(121, 21);
            this.university_text.TabIndex = 25;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.faculty_text);
            this.panel2.Controls.Add(this.university_text);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.textGroupe);
            this.panel2.Controls.Add(this.textCourse);
            this.panel2.Controls.Add(this.textLast_name);
            this.panel2.Controls.Add(this.TextSelectionLable);
            this.panel2.Controls.Add(this.textClass_lable);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textName);
            this.panel2.Location = new System.Drawing.Point(-1, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 513);
            this.panel2.TabIndex = 1;
            // 
            // faculty_text
            // 
            this.faculty_text.FormattingEnabled = true;
            this.faculty_text.Items.AddRange(new object[] {
            "Химия",
            "Физика ",
            "Педагогика",
            "Математика"});
            this.faculty_text.Location = new System.Drawing.Point(40, 83);
            this.faculty_text.Name = "faculty_text";
            this.faculty_text.Size = new System.Drawing.Size(121, 21);
            this.faculty_text.TabIndex = 26;
            // 
            // form2BindingSource
            // 
            this.form2BindingSource.DataSource = typeof(WindowsFormsApp2.AddStudentForm);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 622);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource form2BindingSource;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label textClass_lable;
        private System.Windows.Forms.Label TextSelectionLable;
        private System.Windows.Forms.TextBox textLast_name;
        private System.Windows.Forms.TextBox textCourse;
        private System.Windows.Forms.TextBox textGroupe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox university_text;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox faculty_text;
    }
}