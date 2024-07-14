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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace dormitory.Forms
{
    public partial class FormRepair : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
       
        public FormRepair()
        {
            InitializeComponent();
        }

        private void FormRepair_Load(object sender, EventArgs e)
        {
            open_connection();
            load_Repair_dataGridView_init();
            
        }
        private void load_Repair_dataGridView_init()
        {

            string sql = "SELECT * FROM project_dormitory.Repair";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Repair");
            Repair_dataGridView.DataSource = ds.Tables["Repair"].DefaultView;
            Repair_dataGridView.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";
            Repair_dataGridView.Columns[5].DefaultCellStyle.Format = "yyyy-MM-dd";

        }
        private void clear_data()
        {

            repid_textbox.Text = "";
            Contactid_textbox.Text = "";
            sub.Text = "";
            Description_textbox.Text = "";
            dosre_datepicker.Value = DateTime.Now;
            dores_datepicker.Value = DateTime.Now;
            yes_radioButton.Checked = false;
            no_radioButton.Checked = false;

        }
        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        //Repair(Repair_ID, subject, Description, status, Date_of_repair, Date_of_request, Contact_ID) VALUES
        private void insert_btn_Click(object sender, EventArgs e)
        {
            var Repair_ID = repid_textbox.Text;
            var subject = sub.Text;
            var Description = Description_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;

            var status = (yes_radioButton.Checked) ? yes_radioButton.Text : no_radioButton.Text;
            string Date_of_repair = dosre_datepicker.Value.ToString("yyyy-MM-dd");
            string Date_of_request = dores_datepicker.Value.ToString("yyyy-MM-dd");


            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Repair` (`Repair_ID`, `subject`, `Description`, `status`, `Date_of_repair`, `Date_of_request`, `Contact_ID`) " +
                "VALUES (@Repair_ID, @subject, @Description, @status, @Date_of_repair, @Date_of_request, @Contact_ID)";

            comm.Parameters.AddWithValue("@Repair_ID", Repair_ID);
            comm.Parameters.AddWithValue("@subject", subject);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@Date_of_repair", Date_of_repair);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
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
            load_Repair_dataGridView_init();
            clear_data();
        }
        //Repair(Repair_ID, subject, Description, status, Date_of_repair, Date_of_request, Contact_ID) VALUES
        private void Repair_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Repair_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Repair_ID = Repair_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string subject = Repair_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string Description = Repair_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string status = Repair_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string s_dob = Repair_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string Date_of_request = Repair_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string Contact_ID = Repair_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
 
                repid_textbox.Text = Repair_ID;
                sub.Text = subject;
                Description_textbox.Text = Description;
                Contactid_textbox.Text = Contact_ID;

                DateTime datereq;
                if (Date_of_request != "")
                {
                    datereq = Convert.ToDateTime(Date_of_request, null);
                    string str = datereq.Year + "-" + datereq.Month + "-" + datereq.Day;
                    dores_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                DateTime dateres;
                if (s_dob != "")
                {
                    dateres = Convert.ToDateTime(s_dob, null);
                    string str = dateres.Year + "-" + dateres.Month + "-" + dateres.Day;
                    dosre_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                if (status.Equals("yes"))
                {
                    yes_radioButton.Checked = true;
                }
                else { no_radioButton.Checked = true; }
            }
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var Repair_ID1 = repid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Repair`" +
                "WHERE `Repair_ID` = @Repair_IDu";

            comm.Parameters.AddWithValue("@Repair_IDu", Repair_ID1);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_Repair_dataGridView_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Repair_ID = repid_textbox.Text;
            var subject = sub.Text;
            var Description = Description_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;

            var status = (yes_radioButton.Checked) ? yes_radioButton.Text : no_radioButton.Text;
            string Date_of_repair = dosre_datepicker.Value.ToString("yyyy-MM-dd");
            string Date_of_request = dores_datepicker.Value.ToString("yyyy-MM-dd");


            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Repair` SET `subject` = @subject, `Description` = @Description, `status` = @status, " +
                "`Date_of_repair` = @Date_of_repair, `Date_of_request` = @Date_of_request, `Contact_ID` = @Contact_ID " +
                "WHERE `Repair_ID` = @Repair_ID";

            comm.Parameters.AddWithValue("@Repair_ID", Repair_ID);
            comm.Parameters.AddWithValue("@subject", subject);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@Date_of_repair", Date_of_repair);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);


            try
            {
                con.Open();
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("UPDATE Data Completed!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            load_Repair_dataGridView_init();
            clear_data();
        }

        private void Repair_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
