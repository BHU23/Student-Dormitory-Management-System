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

    public partial class FormPayment : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
     
       
        public FormPayment()
        {
            InitializeComponent();
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {

            open_connection();
            load_payment_griddata_init();
            
        }

        private void load_payment_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.Payment";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Payment");
            payment_dataGridView.DataSource = ds.Tables["Payment"].DefaultView;
            payment_dataGridView.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";

        }

        private void payment_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void clear_data()
        {

            pid_textbox.Text = "";
            Contactid_textbox.Text = "";
            amount_textbox.Text = "";
            medthod_textbox.Text = "";
            dor_datepicker.Value = DateTime.Now;
            yes_radioButton.Checked = false;
            no_radioButton.Checked = false;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }
        //Payment (Payment_ID, Amount, Date, Method, status, Contact_ID) VALUES
        private void payment_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (payment_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Payment_ID = payment_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Amount = payment_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string s_dor = payment_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string Method = payment_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string status = payment_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string Contact_ID = payment_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                
                pid_textbox.Text = Payment_ID;
                Contactid_textbox.Text = Contact_ID;
                amount_textbox.Text = Amount;
                medthod_textbox.Text = Method;
               

                DateTime datereq;
                if (s_dor != "")
                {
                    datereq = Convert.ToDateTime(s_dor, null);
                    string str = datereq.Year + "-" + datereq.Month + "-" + datereq.Day;
                    dor_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                
                if (status.Equals("yes"))
                {
                    yes_radioButton.Checked = true;
                }
                else { no_radioButton.Checked = true; }
            }
        }
        //Payment (Payment_ID, Amount, Date, Method, status, Contact_ID) VALUES
        private void insert_btn_Click(object sender, EventArgs e)
        {
            var Payment_ID = pid_textbox.Text;
            var Amount = amount_textbox.Text;
            var Method = medthod_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;

            var status = (yes_radioButton.Checked) ? yes_radioButton.Text : no_radioButton.Text;
            string Date_of_request = dor_datepicker.Value.ToString("yyyy-MM-dd");


            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Payment` (`Payment_ID`, `Amount`, `Date`, `Method`, `status`, `Contact_ID`) " +
                "VALUES (@Payment_ID, @Amount, @Date_of_request, @Method, @status, @Contact_ID)";

            comm.Parameters.AddWithValue("@Payment_ID", Payment_ID);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
            comm.Parameters.AddWithValue("@Method", Method);
            comm.Parameters.AddWithValue("@status", status);
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
            load_payment_griddata_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Payment_ID = pid_textbox.Text;
            var Amount = amount_textbox.Text;
            var Method = medthod_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;

            var status = (yes_radioButton.Checked) ? yes_radioButton.Text : no_radioButton.Text;
            string Date_of_request = dor_datepicker.Value.ToString("yyyy-MM-dd");


            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Payment` SET `Amount` = @Amount, `Date` = @Date_of_request, " +
                "`Method` = @Method, `status` = @status, `Contact_ID` = @Contact_ID " +
                "WHERE `Payment_ID` = @Payment_ID"; ;

            comm.Parameters.AddWithValue("@Payment_ID", Payment_ID);
            comm.Parameters.AddWithValue("@Amount", Amount);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
            comm.Parameters.AddWithValue("@Method", Method);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);



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
            load_payment_griddata_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var Payment_id = pid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Payment`" +
                "WHERE `Payment_ID` = @Payment_id";

            comm.Parameters.AddWithValue("@Payment_id", Payment_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_payment_griddata_init();
            clear_data();
        }

        private void payment_dataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
