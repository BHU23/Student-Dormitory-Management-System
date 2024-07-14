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
using static System.Net.Mime.MediaTypeNames;

namespace dormitory.Forms
{
    public partial class FormRSRDocuments : Form
    {

        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        public FormRSRDocuments()
        {
            InitializeComponent();
        }
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void FormRSRDocuments_Load(object sender, EventArgs e)
        {
            open_connection();
            load_RSRDocuments_init();
            load_Document_ID_comboboxx_init();
        }
        private void load_RSRDocuments_init()
        {

            string sql = "SELECT * FROM project_dormitory.reserve_send_receive_documents";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "reserve_send_receive_documents");
            Rsr_dataGridView.DataSource = ds.Tables["reserve_send_receive_documents"].DefaultView;
            Rsr_dataGridView.Columns[2].DefaultCellStyle.Format = "yyyy-MM-dd";
            Rsr_dataGridView.Columns[4].DefaultCellStyle.Format = "yyyy-MM-dd";

        }
        private void load_Document_ID_comboboxx_init()
        {
            string sql = "SELECT distinct Document_ID FROM project_dormitory.Form_Documents";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                Document_ID_combobox.Items.Add(reader.GetString("Document_ID"));
            }
            reader.Close();
        }
        private void clear_data()
        {

            Reservertid_textbox.Text = "";
            Contactid_textbox.Text = "";
            name_textbox.Text = "";
            time_textbox.Text = "";
            Document_ID_combobox.SelectedIndex = 0;
            dosre_datepicker.Value = DateTime.Now;
            dores_datepicker.Value = DateTime.Now;
            status_lable.Text = "";
            send.Checked = false;
            Receive_radioButton1.Checked = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        //eserve_send_receive_documents(Reserve_ID, subject, Date_of_Reserve, status , Date_of_request, Time_of_request, Contact_ID, Reserve_Send_Receive, Document_ID)
        private void Rsr_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Rsr_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Reserve_ID = Rsr_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string subject = Rsr_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string Date_of_Reserve = Rsr_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string status = Rsr_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string Date_of_request = Rsr_dataGridView.SelectedRows[0].Cells[4].Value.ToString();
                string Time_of_request = Rsr_dataGridView.SelectedRows[0].Cells[5].Value.ToString();
                string Contact_ID = Rsr_dataGridView.SelectedRows[0].Cells[6].Value.ToString();
                string Reserve_Send_Receive = Rsr_dataGridView.SelectedRows[0].Cells[8].Value.ToString();
                string Document_ID = Rsr_dataGridView.SelectedRows[0].Cells[7].Value.ToString();

                Reservertid_textbox.Text = Reserve_ID;
                name_textbox.Text = subject;
                Contactid_textbox.Text = Contact_ID;
                time_textbox.Text = Time_of_request;
                status_lable.Text = status;
                if (Document_ID != "")
                {
                    Document_ID_combobox.SelectedIndex = int.Parse(Document_ID);
                }
                DateTime datereq;
                if (Date_of_request != "")
                {
                    datereq = Convert.ToDateTime(Date_of_request, null);
                    string str = datereq.Year + "-" + datereq.Month + "-" + datereq.Day;
                    dores_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                DateTime dateres;
                if (Date_of_Reserve != "")
                {
                    dateres = Convert.ToDateTime(Date_of_Reserve, null);
                    string str = dateres.Year + "-" + dateres.Month + "-" + dateres.Day;
                    dosre_datepicker.Value = DateTime.ParseExact(str, "yyyy-M-d", null);
                }
                
                if (Reserve_Send_Receive.Equals("send"))
                {
                    send.Checked = true;
                }
                else { Receive_radioButton1.Checked = true; }
            }
        
        }
        //INSERT INTO reserve_send_receive_documents(Reserve_ID, subject, Date_of_Reserve, status , Date_of_request, Time_of_request, Contact_ID, Reserve_Send_Receive, Document_ID
      
            
        private void insert_btn_Click(object sender, EventArgs e)
        {
            var Reserve_ID = Reservertid_textbox.Text;
            var subject = name_textbox.Text;
            var Time_of_request = time_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;
            
            var status = status_lable.Text;
            var Reserve_Send_Receive = (send.Checked) ? send.Text : Receive_radioButton1.Text;
            string Date_of_request = dosre_datepicker.Value.ToString("yyyy-MM-dd");
            string Date_of_Reserve = dores_datepicker.Value.ToString("yyyy-MM-dd");
            var selectedCar2 = Document_ID_combobox.SelectedIndex;
            var Document_ID = (selectedCar2 > 0) ? selectedCar2.ToString() : null;

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`reserve_send_receive_documents` (`Reserve_ID`, `subject`, `Date_of_Reserve`, " +
                "`status`, `Date_of_request`, `Time_of_request`, `Contact_ID`, `Reserve_Send_Receive`, `Document_ID`) " +
                "VALUES (@Reserve_ID, @subject, @Date_of_Reserve, @status, @Date_of_request, @Time_of_request, @Contact_ID, @Reserve_Send_Receive, @Document_ID)";

            comm.Parameters.AddWithValue("@Reserve_ID", Reserve_ID);
            comm.Parameters.AddWithValue("@subject", subject);
            comm.Parameters.AddWithValue("@Date_of_Reserve", Date_of_Reserve);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
            comm.Parameters.AddWithValue("@Time_of_request", Time_of_request);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);
            comm.Parameters.AddWithValue("@Reserve_Send_Receive", Reserve_Send_Receive);
            comm.Parameters.AddWithValue("@Document_ID", Document_ID);

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
            load_RSRDocuments_init();
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Reserve_ID = Reservertid_textbox.Text;
            var subject = name_textbox.Text;
            var Time_of_request = time_textbox.Text;
            var Contact_ID = Contactid_textbox.Text;

            var status = status_lable.Text;
            var Reserve_Send_Receive = (send.Checked) ? send.Text : Receive_radioButton1.Text;
            string Date_of_request = dosre_datepicker.Value.ToString("yyyy-MM-dd");
            string Date_of_Reserve = dores_datepicker.Value.ToString("yyyy-MM-dd");
            var selectedCar2 = Document_ID_combobox.SelectedIndex;
            var Document_ID = (selectedCar2 > 0) ? selectedCar2.ToString() : null;

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`reserve_send_receive_documents` SET `subject` = @subject, `Date_of_Reserve` = @Date_of_Reserve, " +
"`status` = @status, `Date_of_request` = @Date_of_request, `Time_of_request` = @Time_of_request, `Contact_ID` = @Contact_ID, " +
    "`Reserve_Send_Receive` = @Reserve_Send_Receive, `Document_ID` = @Document_ID " +
    "WHERE `Reserve_ID` = @Reserve_ID";

            comm.Parameters.AddWithValue("@Reserve_ID", Reserve_ID);
            comm.Parameters.AddWithValue("@subject", subject);
            comm.Parameters.AddWithValue("@Date_of_Reserve", Date_of_Reserve);
            comm.Parameters.AddWithValue("@status", status);
            comm.Parameters.AddWithValue("@Date_of_request", Date_of_request);
            comm.Parameters.AddWithValue("@Time_of_request", Time_of_request);
            comm.Parameters.AddWithValue("@Contact_ID", Contact_ID);
            comm.Parameters.AddWithValue("@Reserve_Send_Receive", Reserve_Send_Receive);
            comm.Parameters.AddWithValue("@Document_ID", Document_ID);

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
            load_RSRDocuments_init();
            clear_data();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var s_id = Reservertid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`reserve_send_receive_documents`" +
                "WHERE `Reserve_ID` = @Reserve_iD";

            comm.Parameters.AddWithValue("@Reserve_iD", s_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_RSRDocuments_init();
            clear_data();
        }
    
    }
}
