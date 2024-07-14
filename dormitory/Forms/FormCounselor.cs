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
    public partial class FormCounselor : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;

        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        public FormCounselor()
        {
            InitializeComponent();
        }

        private void FormCounselor_Load(object sender, EventArgs e)
        {
            open_connection();
            load_c_dorm_griddata_init();
        }
        private void load_c_dorm_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.Dormitory_Counselor";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Dormitory_Counselor");
            conselor_dataGridView.DataSource = ds.Tables["Dormitory_Counselor"].DefaultView;

        }
        private void clear_data()
        {

            CounselorID_textbox.Text = "";
            name_textbox.Text = "";
            did_textbox.Text = "";
            telephone_textbox.Text = "";
            Contact_textbox.Text = "";
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void conselor_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (conselor_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Counselor_ID = conselor_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string cc_name = conselor_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string ContactDetails = conselor_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string Telephone_Number = conselor_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string Dormitory_ID = conselor_dataGridView.SelectedRows[0].Cells[4].Value.ToString();


                CounselorID_textbox.Text = Counselor_ID;
                name_textbox.Text = cc_name;
                Contact_textbox.Text = ContactDetails;
                telephone_textbox.Text = Telephone_Number;
                did_textbox.Text = Dormitory_ID;


            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            var Counselor_ID = CounselorID_textbox.Text;
            var cc_name = name_textbox.Text;
            var ContactDetails = Contact_textbox.Text;
            var Telephone_Number = telephone_textbox.Text; 
            var Dormitory_ID = did_textbox.Text;


            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Dormitory_Counselor` (`Counselor_ID`, `Name`, `ContactDetails`, `Telephone_Number`, `Dormitory_ID`) " +
                "VALUES (@Counselor_ID, @cc_name, @ContactDetails, @Telephone_Number, @Dormitory_ID)";

            comm.Parameters.AddWithValue("@Counselor_ID", Counselor_ID);
            comm.Parameters.AddWithValue("@cc_name", cc_name);
            comm.Parameters.AddWithValue("@ContactDetails", ContactDetails);
            comm.Parameters.AddWithValue("@Telephone_Number", Telephone_Number);
            comm.Parameters.AddWithValue("@Dormitory_ID", Dormitory_ID);

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
            load_c_dorm_griddata_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Counselor_ID = CounselorID_textbox.Text;
            var cc_name = name_textbox.Text;
            var ContactDetails = Contact_textbox.Text;
            var Telephone_Number = telephone_textbox.Text;
            var Dormitory_ID = did_textbox.Text;


            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Dormitory_Counselor` SET `Name` = @cc_name, `ContactDetails` = @ContactDetails, " +
                "`Telephone_Number` = @Telephone_Number, `Dormitory_ID` = @Dormitory_ID " +
                "WHERE `Counselor_ID` = @Counselor_ID";


            comm.Parameters.AddWithValue("@Counselor_ID", Counselor_ID);
            comm.Parameters.AddWithValue("@cc_name", cc_name);
            comm.Parameters.AddWithValue("@ContactDetails", ContactDetails);
            comm.Parameters.AddWithValue("@Telephone_Number", Telephone_Number);
            comm.Parameters.AddWithValue("@Dormitory_ID", Dormitory_ID);

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
            load_c_dorm_griddata_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var Counselor_ID = CounselorID_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Dormitory_Counselor`" +
                "WHERE `Counselor_ID` = @Counselor_iD";

            comm.Parameters.AddWithValue("@Counselor_iD", Counselor_ID);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_c_dorm_griddata_init();
            clear_data();
        }
        //Dormitory_Counselor (Counselor_ID,Name,ContactDetails,Telephone_Number,Dormitory_ID)
    }
}
