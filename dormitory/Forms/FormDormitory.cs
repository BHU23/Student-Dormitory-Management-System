using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dormitory.Forms
{
    public partial class FormDormitory : Form
    {
        public FormDormitory()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void FormDormitory_Load(object sender, EventArgs e)
        {
            TypeDormitory_comboBox.SelectedIndex = 0;
            open_connection();
            load_dorm_griddata_init();
            load_typedorm_griddata_init();
            load_typedorm_combobox_init();
        }
        private void load_dorm_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.Dormitory";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Dormitory");
            dorm_dataGridView.DataSource = ds.Tables["Dormitory"].DefaultView;

        }
        private void load_typedorm_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.TypeDormitory";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "TypeDormitory");
            typedorm_dataGridVie.DataSource = ds.Tables["TypeDormitory"].DefaultView;  

        }
        private void load_typedorm_combobox_init()
        {
            string sql = "SELECT distinct TypeDormitory_ID FROM project_dormitory.TypeDormitory";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                TypeDormitory_comboBox.Items.Add(reader.GetString("TypeDormitory_ID"));
            }
            reader.Close();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void clear_data()
        {

            did_textbox.Text = "";
            name_textbox.Text = "";
            Address_leble.Text = "";
            contact_textbox.Text = "";
            TypeDormitory_comboBox.SelectedIndex = 0;
        }
    

        private void dorm_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dorm_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string Dormitory_ID = dorm_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Name = dorm_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string Address = dorm_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string Contact = dorm_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string TypeDormitory_ID = dorm_dataGridView.SelectedRows[0].Cells[5].Value.ToString();

                did_textbox.Text = Dormitory_ID;
                name_textbox.Text = Name;
                Address_leble.Text = Address;
                contact_textbox.Text = Contact;
                TypeDormitory_comboBox.Text = TypeDormitory_ID;
                
            }
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            
            var Dormitory_ID = did_textbox.Text;
            var Name = name_textbox.Text;
            var selectedCar = TypeDormitory_comboBox.SelectedIndex;
            var TypeDormitory_ID = (selectedCar > 0) ? selectedCar.ToString() : null;
            var Address = Address_leble.Text;
            var Contact = contact_textbox.Text;


            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Dormitory` (`Dormitory_ID`, `Name`, `Address`, `Contact`, `TypeDormitory_ID`) " +
                "VALUES (@Dormitory_ID, @Name, @Address, @Contact, @TypeDormitory_ID)";

            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Dormitory_ID", Dormitory_ID);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Contact", Contact);
            comm.Parameters.AddWithValue("@TypeDormitory_ID", TypeDormitory_ID);

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
            load_dorm_griddata_init();
            clear_data();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var Dormitory_ID = did_textbox.Text;
            var Name = name_textbox.Text;
            var selectedCar = TypeDormitory_comboBox.SelectedIndex;
            var TypeDormitory_ID = (selectedCar >= 0) ? (selectedCar).ToString() : null;
            var Address = Address_leble.Text;
            var Contact = contact_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Dormitory` " +
                "SET `Name` = @Name, `Address` = @Address, `Contact` = @Contact, `TypeDormitory_ID` = @TypeDormitory_ID " +
                "WHERE `Dormitory_ID` = @Dormitory_ID";

            comm.Parameters.AddWithValue("@Name", Name);
            comm.Parameters.AddWithValue("@Dormitory_ID", Dormitory_ID);
            comm.Parameters.AddWithValue("@Address", Address);
            comm.Parameters.AddWithValue("@Contact", Contact);
            comm.Parameters.AddWithValue("@TypeDormitory_ID", TypeDormitory_ID);


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
            load_dorm_griddata_init();
            clear_data();
        }

        private void delate_btn_Click(object sender, EventArgs e)
        {
            var Dormitory = did_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM `project_dormitory`.`Dormitory`" +
                "WHERE `Dormitory_ID` = @Dormitory_id";

            comm.Parameters.AddWithValue("@Dormitory_id", Dormitory);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_dorm_griddata_init();
            clear_data();
        }

        private void typedorm_dataGridVie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (typedorm_dataGridVie.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string TypeDormitory_ID = typedorm_dataGridVie.SelectedRows[0].Cells[0].Value.ToString();
                string TypeDormitoryName = typedorm_dataGridVie.SelectedRows[0].Cells[1].Value.ToString();
                string Description = typedorm_dataGridVie.SelectedRows[0].Cells[2].Value.ToString();
                string Capacity = typedorm_dataGridVie.SelectedRows[0].Cells[3].Value.ToString();

                Typedrom.Text = TypeDormitory_ID;
                Typedromname.Text = TypeDormitoryName;
                description_textbox.Text = Description;
                capacity_textbox.Text = Capacity;

            }
        }
        private void clear_data1()
        {
            Typedrom.Text = "";
            Typedromname.Text = "";
            description_textbox.Text = "";
            capacity_textbox.Text = "";
        }
        private void dorm_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear_data1();
        }

        private void insert1_btn_Click(object sender, EventArgs e)
        {
            var TypeDormitory_ID = Typedrom.Text;
            var TypeDormitoryName = Typedromname.Text;

            var Description = description_textbox.Text;
            var Capacity = capacity_textbox.Text;



            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`TypeDormitory` (`TypeDormitory_ID`, `TypeDormitoryName`, `Description`, `Capacity`) " +
                "VALUES (@TypeDormitory_ID, @TypeDormitoryName, @Description, @Capacity)";

            comm.Parameters.AddWithValue("@TypeDormitory_ID", TypeDormitory_ID);
            comm.Parameters.AddWithValue("@TypeDormitoryName", TypeDormitoryName);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@Capacity", Capacity);

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
            load_typedorm_griddata_init();
            clear_data1();
        }

        private void update2_btn_Click(object sender, EventArgs e)
        {
            
            var TypeDormitory_ID = Typedrom.Text;
            var TypeDormitoryName = Typedromname.Text;

            var Description = description_textbox.Text;
            var Capacity = capacity_textbox.Text;


            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`TypeDormitory` " +
                "SET `TypeDormitoryName` = @TypeDormitoryName, `Description` = @Description, `Capacity` = @Capacity " +
                "WHERE `TypeDormitory_ID` = @TypeDormitory_ID";

            comm.Parameters.AddWithValue("@TypeDormitory_ID", TypeDormitory_ID);
            comm.Parameters.AddWithValue("@TypeDormitoryName", TypeDormitoryName);
            comm.Parameters.AddWithValue("@Description", Description);
            comm.Parameters.AddWithValue("@Capacity", Capacity);

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
            load_typedorm_griddata_init();
            clear_data1();
        }

        private void delate2_btn_Click(object sender, EventArgs e)
        {
            var TypeDormitory = Typedrom.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM `project_dormitory`.`TypeDormitory`" +
                "WHERE `TypeDormitory_ID` = @TypeDormitory_id";

            comm.Parameters.AddWithValue("@TypeDormitory_id", TypeDormitory);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_typedorm_griddata_init();
            clear_data1();
        }

        private void typedorm_dataGridVie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
