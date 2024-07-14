﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dormitory.Forms
{
    public partial class FormStudent_Register : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        public FormStudent_Register()
        {
            InitializeComponent();
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void FormStudent_Register_Load(object sender, EventArgs e)
        {
            open_connection();
            load_student_griddata_init();
            load_major_combobox_init();
            load_scholarship_combobox_init();     
        }
        private void load_student_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory1.student";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Student");
            student_dataGridView.DataSource = ds.Tables["Student"].DefaultView;
            student_dataGridView.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

        }
        private void load_major_combobox_init()
        {
            string sql = "SELECT distinct Major_name FROM project_dormitory1.Major";
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
            string sql = "SELECT distinct Scholarship_Name FROM project_dormitory1.scholarship";
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
            major_combobox.SelectedIndex = -1;
            scholarship_combobox.SelectedIndex = -1;
            dob_datepicker.Value = DateTime.Now;
            female_radioButton.Checked = false;
            male_radioButton.Checked = false;
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;
            var s_name = name_textbox.Text;
            var s_dob = dob_datepicker.Value.ToString("yyyy-MM-dd");
            var s_domicile = Domicile_textbox.Text;
            var s_telephone_number = telephone_textbox.Text;
            var selectedCar = major_combobox.SelectedIndex;
            var s_major = selectedCar.ToString();
            var selectedCar1 = scholarship_combobox.SelectedIndex;
            var s_scholarship = selectedCar1.ToString();
           
            var s_gender = "";
            if (male_radioButton.Checked)
            {
                s_gender = male_radioButton.Text;
            }
            else
            {
                s_gender = female_radioButton.Text;
            }

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory1`.`student` (`Student_ID`, `Name`, `Date_of_Birth`, `Gender`, `Domicile`, `Telephone_Number`, `Major_Major_ID `, `Scholarship_Scholarship_ID`) " +
                               "VALUES (@studentID, @Name, @Date_of_Birth, @Gender, @Domicile, @Telephone_Number, @major, @scholarship)";

            comm.Parameters.AddWithValue("@studentID", s_id);
            comm.Parameters.AddWithValue("@Name", s_name);
            comm.Parameters.AddWithValue("@Date_of_Birth", s_dob);
            comm.Parameters.AddWithValue("@Gender", s_gender);
            comm.Parameters.AddWithValue("@Domicile", s_domicile);
            comm.Parameters.AddWithValue("@Telephone_Number", s_telephone_number);
            comm.Parameters.AddWithValue("@major", s_major);
            comm.Parameters.AddWithValue("@scholarship", s_scholarship);

            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Save Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_student_griddata_init();
            clear_data();
        }

        private void student_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (student_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                    string s_id = student_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    string s_name = student_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    string s_dob = student_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    string s_gender = student_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    string s_domicile = student_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    string s_telephone_number = student_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    string s_major = student_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    string s_scholarship = student_dataGridView.SelectedRows[0].Cells[7].Value.ToString();

                sid_textbox.Text = s_id;
                name_textbox.Text = s_name;
                Domicile_textbox.Text = s_domicile;
                telephone_textbox.Text = s_telephone_number;
                if (s_major != "")
                {
                    major_combobox.SelectedIndex = int.Parse(s_major);
                }
                if (s_scholarship != "")
                    scholarship_combobox.SelectedIndex = int.Parse(s_scholarship);
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

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_database`.`student`," +
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

        private void update_btn_Click(object sender, EventArgs e)
        {
            var s_id = sid_textbox.Text;
            var s_name = name_textbox.Text;
            var selectedCar = major_combobox.SelectedIndex;
            var s_major = selectedCar.ToString();
            var s_domicile = Domicile_textbox.Text;
            var s_telephone_number = telephone_textbox.Text;
            var selectedCar1 = major_combobox.SelectedIndex;
            var s_scholarship = selectedCar1.ToString();
            var gender = "";
            if (male_radioButton.Checked)
            {
                gender = male_radioButton.Text;
            }
            else
            {
                gender = female_radioButton.Text;
            }
            string dob_date = dob_datepicker.Value.ToString("yyyy-MM-dd");

            string sql = "UPDATE project_dormitory.Contact,project_dormitory.student " +
                                 "SET student_ID = @studentID, Name = @name, Date_of_Birth = @dob, Gender = @gender, Domicile = @domicile, " +
                                 "Telephone_Number = @telephone, Major_Major_ID = @major, Scholarship_Scholarship_ID = @scholarship, " +
                                 "WHERE Contact_ID = @contactID";

            using (MySqlCommand comm = new MySqlCommand(sql, con))
                    {
                        comm.Parameters.AddWithValue("@studentID", s_id);
                        comm.Parameters.AddWithValue("@name", s_name);
                        comm.Parameters.AddWithValue("@dob", dob_date);
                        comm.Parameters.AddWithValue("@gender", gender);
                        comm.Parameters.AddWithValue("@domicile", s_domicile);
                        comm.Parameters.AddWithValue("@telephone", s_telephone_number);
                        comm.Parameters.AddWithValue("@major", s_major);
                        comm.Parameters.AddWithValue("@scholarship", s_scholarship);

                        comm.ExecuteNonQuery();
                    }

            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Update Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_student_griddata_init();
            clear_data();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void scholarship_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void major_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dob_datepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void female_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void male_radioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Domicile_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void telephone_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void sid_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

       

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}