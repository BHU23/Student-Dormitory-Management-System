using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dormitory.Forms
{
    public partial class FormStudent : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        public FormStudent()
        {
            InitializeComponent();
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void FormStudent_Load(object sender, EventArgs e)
        {
            open_connection();
            major_combobox.SelectedIndex = 0;
            scholarship_combobox.SelectedIndex = 0;
            load_student_griddata_init();
            load_major_combobox_init();
            load_scholarship_combobox_init();
        }
        private void load_student_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.student";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Student");
            student_dataGridView.DataSource = ds.Tables["Student"].DefaultView;
            student_dataGridView.Columns[2].DefaultCellStyle.Format = "yyyy-MM-Dd";

        }
        private void load_major_combobox_init()
        {
            string sql = "SELECT distinct Major_name FROM project_dormitory.Major";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                major_combobox.Items.Add(reader.GetString("Major_name"));
            }
            reader.Close();
        }

        private void load_scholarship_combobox_init()
        {
            string sql = "SELECT distinct Scholarship_Name FROM project_dormitory.scholarship";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                scholarship_combobox.Items.Add(reader.GetString("Scholarship_Name"));
            }
            reader.Close();
        }
        private void clear_data()
        {

            sid_textbox.Text = "";
            name_textbox.Text = "";
            Domicile_textbox.Text = "";
            telephone_textbox.Text = "";
            major_combobox.SelectedIndex = 0;
            scholarship_combobox.SelectedIndex = 0;
            dob_datepicker.Value = DateTime.Now;
            female_radioButton.Checked = false;
            male_radioButton.Checked = false;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;
            var s_name = name_textbox.Text;
            var selectedCar = major_combobox.SelectedIndex ;
            var s_major = (selectedCar > 0) ? selectedCar.ToString() : null;
            var s_domicile = Domicile_textbox.Text;
            var s_telephone = telephone_textbox.Text;

            var gender = (male_radioButton.Checked) ? male_radioButton.Text : female_radioButton.Text;
            string dob_date = dob_datepicker.Value.ToString("yyyy-MM-dd");
            var selectedCar2 = scholarship_combobox.SelectedIndex;
            var scholarship = (selectedCar2 > 0) ? selectedCar2.ToString() : null;

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Student` (`Student_ID`, `Name`, `Date_of_Birth`, `Gender`, `Domicile`, `Telephone_Number`, `Scholarship_ID`, `Major_ID`) " +
                "VALUES (@Student_id, @Student_name, @DOB, @Gender, @Domicile, @Telephone, @Scholarship, @Major_id)";

            comm.Parameters.AddWithValue("@Student_id", s_id);
            comm.Parameters.AddWithValue("@Student_name", s_name);
            comm.Parameters.AddWithValue("@Domicile", s_domicile);
            comm.Parameters.AddWithValue("@Telephone", s_telephone);
            comm.Parameters.AddWithValue("@Gender", gender);
            comm.Parameters.AddWithValue("@DOB", dob_date);
            comm.Parameters.AddWithValue("@Major_id", s_major);
            comm.Parameters.AddWithValue("@Scholarship", scholarship);

            try
            {
                con.Open();
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Save Data Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            load_student_griddata_init();
            clear_data();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        
        private void update_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;
            var s_name = name_textbox.Text;
            var selectedCar = major_combobox.SelectedIndex ;
            var s_major = (selectedCar > 0) ? selectedCar.ToString() : null;
            var s_domicile = Domicile_textbox.Text;
            var s_telephone = telephone_textbox.Text;

            var gender = (male_radioButton.Checked) ? male_radioButton.Text : female_radioButton.Text;
            string dob_date = dob_datepicker.Value.ToString("yyyy-MM-dd");
            var selectedCar2 = scholarship_combobox.SelectedIndex;
            var scholarship = (selectedCar2 > 0) ? selectedCar2.ToString() : null;

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`student`" +
                "SET `Name`=@Student_name, `Date_of_Birth`=@DOB, `Gender`=@Gender, `Domicile`=@Domicile, `Telephone_Number`=@Telephone, `Scholarship_ID`=@Scholarship, `Major_ID`=@Major_id " +
                "WHERE `Student_ID` = @Student_id";

            comm.Parameters.AddWithValue("@Student_id", s_id);
            comm.Parameters.AddWithValue("@Student_name", s_name);
            comm.Parameters.AddWithValue("@Domicile", s_domicile);
            comm.Parameters.AddWithValue("@Telephone", s_telephone);
            comm.Parameters.AddWithValue("@Gender", gender);
            comm.Parameters.AddWithValue("@DOB", dob_date);
            comm.Parameters.AddWithValue("@Major_id", s_major);
            comm.Parameters.AddWithValue("@Scholarship", scholarship);

            try
            {
                con.Open();
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Update Data Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            load_student_griddata_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`student`" +
                "WHERE `Student_id` = @Student_id";

            comm.Parameters.AddWithValue("@Student_id", s_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_student_griddata_init();
            clear_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void student_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (student_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string s_id = student_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string s_name = student_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string s_major = student_dataGridView.SelectedRows[0].Cells[7].Value.ToString();
                string s_gender = student_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string s_dob = student_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string s_domicile = student_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string scholarship = student_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                string s_telephone = student_dataGridView.SelectedRows[0].Cells[5].Value.ToString();

                sid_textbox.Text = s_id;
                name_textbox.Text = s_name;
                Domicile_textbox.Text = s_domicile;
                telephone_textbox.Text = s_telephone;
                if (s_major != "")
                {
                    major_combobox.SelectedIndex = int.Parse(s_major);
                }
                if (scholarship != "")
                    scholarship_combobox.SelectedIndex = int.Parse(scholarship);

                DateTime dateBirth;
                if (s_dob != "")
                {
                    dateBirth = Convert.ToDateTime(s_dob, null);
                    string str = dateBirth.Year + "-" + dateBirth.Month + "-" + dateBirth.Day;
                    dob_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                if (s_gender.Equals("Male"))
                {
                    male_radioButton.Checked = true;
                }
                else { female_radioButton.Checked = true; }
            }
        }


        private void student_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
