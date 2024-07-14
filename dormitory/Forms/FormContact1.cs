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
    public partial class FormContact1 : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        public FormContact1()
        {
            InitializeComponent();
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void FormContact1_Load(object sender, EventArgs e)
        {
            term_combobox.SelectedIndex = 0;
            open_connection();
            load_contact_griddata_init();
            load_term_combobox_init();
       

        }
        private void load_contact_griddata_init()
        {

            string sql = "SELECT * from project_dormitory.Contact";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "contact");
            contact_dataGridView.DataSource = ds.Tables["contact"].DefaultView;
            contact_dataGridView.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";
            contact_dataGridView.Columns[6].DefaultCellStyle.Format = "yyyy-MM-dd";

        }
        private void load_term_combobox_init()
        {
            string sql = "SELECT distinct Term FROM project_dormitory.Term";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                term_combobox.Items.Add(reader.GetString("Term"));
            }
            reader.Close();
        }
        private void clear_data()
        {
            Contact_textBox.Text = "";
            year_textBox.Text = "";
            sid_textbox.Text = "";
            term_combobox.SelectedIndex = 0;
            Room_textBox.Text = "";
            dol_datepicker.Value = DateTime.Now;
            doe_datepicker.Value = DateTime.Now;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            var c_id = Contact_textBox.Text;
            var s_id = sid_textbox.Text;
      
            var roomname = Room_textBox.Text;
            var selecttrem = term_combobox.SelectedIndex;
            var trem = (selecttrem > 0) ? selecttrem.ToString() : null;
            var year = year_textBox.Text;
            string doe_date = doe_datepicker.Value.ToString("yyyy-MM-dd");
            string dol_date = dol_datepicker.Value.ToString("yyyy-MM-dd");

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Contact` (`Contact_ID`, `Student_ID`, `RoomNumber`, `Year`, `Term_term`, `Date_of_entry`, `Date_of_leaving`) " +
                "VALUES (@Contact_ID, @Student_ID, @RoomNumber, @Year, @Term_term, @Date_of_entry, @Date_of_leaving)";

            comm.Parameters.AddWithValue("@Contact_ID", c_id);
            comm.Parameters.AddWithValue("@Student_ID", s_id);
            comm.Parameters.AddWithValue("@RoomNumber", roomname);
            comm.Parameters.AddWithValue("@Year", year);
            comm.Parameters.AddWithValue("@Term_term", trem);
            comm.Parameters.AddWithValue("@Date_of_entry", doe_date);
            comm.Parameters.AddWithValue("@Date_of_leaving", dol_date);

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
            load_contact_griddata_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var c_id = Contact_textBox.Text;
            var s_id = sid_textbox.Text;
            var roomname = Room_textBox.Text;
            var selectedCar = term_combobox.SelectedIndex;
            var trem = selectedCar.ToString();
            var year = year_textBox.Text;
            string doe_date = doe_datepicker.Value.ToString("yyyy-MM-dd");
            string dol_date = dol_datepicker.Value.ToString("yyyy-MM-dd");

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Contact`" +
                "SET `Student_ID`=@Student_ID, `RoomNumber`=@RoomNumber, `Year`=@Year, `Term_term`=@Term_term, `Date_of_entry`=@Date_of_entry, `Date_of_leaving`=@Date_of_leaving " +
                "WHERE `Contact_ID` = @Contact_ID";

            comm.Parameters.AddWithValue("@Contact_ID", c_id);
            comm.Parameters.AddWithValue("@Student_ID", s_id);
            comm.Parameters.AddWithValue("@RoomNumber", roomname);
            comm.Parameters.AddWithValue("@Year", year);
            comm.Parameters.AddWithValue("@Term_term", trem);
            comm.Parameters.AddWithValue("@Date_of_entry", doe_date);
            comm.Parameters.AddWithValue("@Date_of_leaving", dol_date);

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
            load_contact_griddata_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var c_id = Contact_textBox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Contact`" +
               "WHERE `Contact_ID` = @Contact_ID";

            comm.Parameters.AddWithValue("@Contact_ID", c_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_contact_griddata_init();
            clear_data();
        }
        
        private void contact_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (contact_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Contact_ID = contact_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Student_ID = contact_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string RoomNumber = contact_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
               
                string Year = contact_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string Term_term = contact_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string Date_of_entry = contact_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string Date_of_leaving = contact_dataGridView.SelectedRows[0].Cells[6].Value.ToString();

                
                sid_textbox.Text = Student_ID;
                Contact_textBox.Text = Contact_ID;
                Room_textBox.Text = RoomNumber;
                year_textBox.Text = Year;
                if (Term_term != "")
                {
                    term_combobox.SelectedIndex = int.Parse(Term_term);
                }
                
                DateTime dateEntry;
                if (Date_of_entry != "")
                {
                    dateEntry = Convert.ToDateTime(Date_of_entry, null);
                    string str = dateEntry.Year + "-" + dateEntry.Month + "-" + dateEntry.Day;
                    doe_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                DateTime dateLeavingh;
                if (Date_of_leaving != "")
                {
                    dateLeavingh = Convert.ToDateTime(Date_of_leaving, null);
                    string str = dateLeavingh.Year + "-" + dateLeavingh.Month + "-" + dateLeavingh.Day;
                    dol_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
            
        }
    }
    }
}
