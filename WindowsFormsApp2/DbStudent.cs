using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    class DbStudent
    {
        
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=;database=university";
            MySqlConnection connection = new MySqlConnection(sql);
            try
            {
                connection.Open();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return connection;

        }
        public static void AddStudent(Student std)
        {
            string sql = "INSERT INTO students VALUES (NULL, @StudentName, @SLastName,@SCourse,@SGroupe, @University, @Faculty)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.Parameters.Add("@StudentName", MySqlDbType.VarChar).Value = std.First_name;
            cmd.Parameters.Add("@SLastName", MySqlDbType.VarChar).Value = std.Last_name;
            cmd.Parameters.Add("@SCourse", MySqlDbType.VarChar).Value = std.Course;
            cmd.Parameters.Add("@SGroupe", MySqlDbType.VarChar).Value = std.Groupe;
            cmd.Parameters.Add("@University", MySqlDbType.VarChar).Value = std.University;
            cmd.Parameters.Add("@Faculty", MySqlDbType.VarChar).Value = std.Faculty;
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added ok");

            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Student not insert.\n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            connection.Close();
        }
        public static void AddGrade(Grade grd)
        {
            string sql = "INSERT INTO grade VALUES (@sub, @grade)";
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Parameters.Add("@sub", MySqlDbType.VarChar).Value = "HtmlCss";


         

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("update ok ok");

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("not update");

            }
            connection.Close();
        }
    
        
        public static void DisplayAndSearch(string query, DataGridView dgv)
        {
            string sql = query;
            MySqlConnection connection = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            MySqlDataAdapter adapter_data = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adapter_data.Fill(tbl);
            connection.Close();
            dgv.DataSource = tbl;
            connection.Close();


        }

    }
}
