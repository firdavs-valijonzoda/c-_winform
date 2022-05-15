using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
   class Student
    {
        public string University { get; set; }
        public string Faculty { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Course { get; set; }
        public string Groupe { get; set; }

        public Student(string firstname, string lastname, string course, string groupe, string university, string faculty)
        {

            First_name = firstname;
            Last_name = lastname;
            Course = course;
            Groupe = groupe;
            University = university;
            Faculty = faculty;

        }
       
    }
    class Grade
    {
        public string HtmlCss { get; set; }
        public string Javalang { get; set; }
        public string DataBase { get; set; }
        public string RestfApi { get; set; }

        public Grade(string htmlcss, string javalang, string datadase, string restfapi)
        {
            HtmlCss = htmlcss;
            Javalang = javalang;
            DataBase = datadase;
            RestfApi = restfapi;
        }
    }
}
