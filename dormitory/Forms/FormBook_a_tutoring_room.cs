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
    public partial class FormBook_a_tutoring_room : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        
        public FormBook_a_tutoring_room()
        {
            InitializeComponent();
        }
        
        private void FormBook_a_tutoring_room_Load(object sender, EventArgs e)
        {
            open_connection();
            load_btrl_init();
        }
        private void clear_data()
        {
            bid_textbox.Text = "";
            Contactid_textbox.Text = "";
            description.Text = "";
            tob_textBox.Text = "";
            toe_textBox.Text = "";
            dosre_datepicker.Value = DateTime.Now;

        }
        private void load_btrl_init()
        {

            string sql = "SELECT * FROM project_dormitory.Book_a_tutoring_room";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Book_a_tutoring_room");
            btr_dataGridView.DataSource = ds.Tables["Book_a_tutoring_room"].DefaultView;
            btr_dataGridView.Columns[1].DefaultCellStyle.Format = "yyyy-MM-dd";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        
        private void btr_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (btr_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Book_ID = btr_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Datet1 = btr_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string Description = btr_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string Time_of_Begin = btr_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string Time_of_end = btr_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string Contact_ID = btr_dataGridView.SelectedRows[0].Cells[5].Value.ToString();

                bid_textbox.Text = Book_ID;
                tob_textBox.Text = Time_of_Begin;
                description.Text = Description;
                Contactid_textbox.Text = Contact_ID;
                toe_textBox.Text = Time_of_end;
                DateTime Datet;
                if (Datet1 != "")
                {
                    Datet = Convert.ToDateTime(Datet1, null);
                    string str = Datet.Year + "-" + Datet.Month + "-" + Datet.Day;

                }
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            var Book_id = bid_textbox.Text;
            var Time_of_Begin = tob_textBox.Text;
            var Description = description.Text;
            var Contact_ID = Contactid_textbox.Text;
            var Time_of_end = toe_textBox.Text;
            string Date_of_request = dosre_datepicker.Value.ToString("yyyy-MM-dd");
            

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Book_a_tutoring_room` (`Book_ID`, `Date`, `Description`, `Time_of_Begin`, `Time_of_end`, `Contact_ID`) " +
                "VALUES (@Book_id, @Date, @Description, @Time_of_Begin, @Time_of_end, @Contact_ID)";

            comm.Parameters.AddWithValue("@Book_id", Book_id);
            comm.Parameters.AddWithValue("@Date", Date_of_request);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@Time_of_Begin", Time_of_Begin);
            comm.Parameters.AddWithValue("@Time_of_end", Time_of_end);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);


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
            load_btrl_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var Book_id = bid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Book_a_tutoring_room`" +
                "WHERE `Book_ID` = @Book_ID9";

            comm.Parameters.AddWithValue("@Book_ID9", Book_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_btrl_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Book_id = bid_textbox.Text;
            var Time_of_Begin = tob_textBox.Text;
            var Description = description.Text;
            var Contact_ID = Contactid_textbox.Text;
            var Time_of_end = toe_textBox.Text;
            string Date_of_request = dosre_datepicker.Value.ToString("yyyy-MM-dd");


            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Book_a_tutoring_room` SET `Date` = @Date, `Description` = @Description, " +
                "`Time_of_Begin` = @Time_of_Begin, `Time_of_end` = @Time_of_end, `Contact_ID` = @Contact_ID " +
                "WHERE `Book_ID` = @Book_id";

            comm.Parameters.AddWithValue("@Book_id", Book_id);
            comm.Parameters.AddWithValue("@Date", Date_of_request);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@Time_of_Begin", Time_of_Begin);
            comm.Parameters.AddWithValue("@Time_of_end", Time_of_end);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);


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
            load_btrl_init();
            clear_data();
        }
    }
}
