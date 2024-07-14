using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dormitory.Forms
{
    public partial class FormRoom : Form
    {
        MySqlConnection con = new MySqlConnection("host=localhost;user=root;password=;database=project_dormitory");
        MySqlCommand comm;
        public FormRoom()
        {
            InitializeComponent();
        }

        private void open_connection()
        {

            con.Open();
            //MessageBox.Show($"MySQL version : {con.ServerVersion}");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            open_connection();
            type_roomcomboBox.SelectedIndex = 0;
            load_room_griddata_init();
            load_typeroom_griddata_init();
            load_typeroom_combobox_init();
        }
        private void load_room_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.Room";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "Room");
            room_dataGridView.DataSource = ds.Tables["Room"].DefaultView;

        }
        private void load_typeroom_griddata_init()
        {

            string sql = "SELECT * FROM project_dormitory.TypeRoom";
            comm = new MySqlCommand(sql, con);
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(comm);
            da.Fill(ds, "TypeRoom");
            typeroom_dataGridView.DataSource = ds.Tables["TypeRoom"].DefaultView;

        }
        private void load_typeroom_combobox_init()
        {
            string sql = "SELECT distinct TypeRoomName FROM project_dormitory.TypeRoom";
            comm = new MySqlCommand(sql, con);

            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                type_roomcomboBox.Items.Add(reader.GetString("TypeRoomName"));
            }
            reader.Close();
        }
        private void clear_data()
        {
            type_roomcomboBox.SelectedIndex = 0;
            roomnum_textbox.Text = "";
            Dormitory_textBox.Text = "";
            Avi_textbox.Text = "";
           
        }
        //Room(RoomNumber, Availability, TypeRoom_ID, Dormitory_ID, Amount_of_student)
        private void insert_btn_Click(object sender, EventArgs e)
        {
            var RoomNumber1 = roomnum_textbox.Text;
            var Availability1 = Avi_textbox.Text;
            var selectedCar = type_roomcomboBox.SelectedIndex;
            var TypeRoom_ID1 = (selectedCar > 0) ? selectedCar.ToString() : null;
            var Dormitory_ID1 = Dormitory_textBox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`Room` (`RoomNumber`, `Availability`, `TypeRoom_ID`, `Dormitory_ID` ) " +
                "VALUES (@RoomNumber2, @Availability2, @TypeRoom_ID2, @Dormitory_ID2)";

            comm.Parameters.AddWithValue("@RoomNumber2", RoomNumber1);
            comm.Parameters.AddWithValue("@Availability2", Availability1);
            comm.Parameters.AddWithValue("@TypeRoom_ID2", TypeRoom_ID1);
            comm.Parameters.AddWithValue("@Dormitory_ID2", Dormitory_ID1);

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
            load_room_griddata_init();
            clear_data();
        }

        private void updeat_btn_Click(object sender, EventArgs e)
        {
            var RoomNumber = roomnum_textbox.Text;
            var Availability = Avi_textbox.Text;
            var selectedCar = type_roomcomboBox.SelectedIndex;
            var TypeRoom_ID = (selectedCar > 0) ? selectedCar.ToString() : null;
            var Dormitory_ID = Dormitory_textBox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`Room` " +
                "SET `Availability` = @Availability, `TypeRoom_ID` = @TypeRoom_ID, `Dormitory_ID` = @Dormitory_ID " +
                "WHERE `RoomNumber` = @RoomNumber";
            
            comm.Parameters.AddWithValue("@RoomNumber", RoomNumber);
            comm.Parameters.AddWithValue("@Availability", Availability);
            comm.Parameters.AddWithValue("@TypeRoom_ID", TypeRoom_ID);
            comm.Parameters.AddWithValue("@Dormitory_ID", Dormitory_ID);

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
            load_room_griddata_init();
            clear_data();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            var RoomNumberi = roomnum_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`Room`" +
                "WHERE `RoomNumber` = @RoomNumberi";

            comm.Parameters.AddWithValue("@RoomNumberi", RoomNumberi);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_room_griddata_init();
            clear_data();
        }

        private void buclear_btn_Click(object sender, EventArgs e)
        {
            clear_data();
        }

        private void room_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (room_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string RoomNumber = room_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string Availability = room_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string TypeDormitory_ID = room_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string Dorm = room_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

                roomnum_textbox.Text = RoomNumber;
                Avi_textbox.Text = Availability;
                Dormitory_textBox.Text = Dorm;
                if (TypeDormitory_ID != "")
                {
                    type_roomcomboBox.SelectedIndex = int.Parse(TypeDormitory_ID);
                }
            }
        }
        private void clear_data1()
        {
            Tid_textbox.Text = "";
            trname.Text = "";
            capasity.Text = "";
            Description.Text = "";
            price_textBox.Text = "";

        }

        private void insert1_btn_Click(object sender, EventArgs e)
        {
            var TypeRoom_ID = Tid_textbox.Text;
            var TypeRoomName = trname.Text;
            var Description1 = Description.Text;
            var Capacity = capasity.Text;
            var price = price_textBox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "INSERT INTO `project_dormitory`.`TypeRoom` (`TypeRoom_ID`, `TypeRoomName`, `Description`, `Capacity`, `price` ) " +
                "VALUES ( @TypeRoom_ID, @TypeRoomName, @Description, @Capacity, @price )";

            comm.Parameters.AddWithValue("@TypeRoom_ID", TypeRoom_ID);
            comm.Parameters.AddWithValue("@TypeRoomName", TypeRoomName);
            comm.Parameters.AddWithValue("@Description", Description1);
            comm.Parameters.AddWithValue("@Capacity", Capacity);
            comm.Parameters.AddWithValue("@price", price);

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
            load_typeroom_griddata_init();
            clear_data1();
        }

        private void clear_btn2_Click(object sender, EventArgs e)
        {
            clear_data1();
        }

        private void delete2_btn_Click(object sender, EventArgs e)
        {
            var TypeRoom_id = Tid_textbox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "DELETE FROM  `project_dormitory`.`TypeRoom`" +
                "WHERE `TypeRoom_ID` = @TypeRoom_id";

            comm.Parameters.AddWithValue("@TypeRoom_id", TypeRoom_id);


            try
            {
                int rowsAffected = comm.ExecuteNonQuery();
                MessageBox.Show("Delete Data Completed!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            load_typeroom_griddata_init();
            clear_data1();
        }

        private void update1_btn_Click(object sender, EventArgs e)
        {
            var TypeRoom_ID = Tid_textbox.Text;
            var TypeRoomName = trname.Text;
            var Description1 = Description.Text;
            var Capacity = capasity.Text;
            var price = price_textBox.Text;

            comm = con.CreateCommand();
            comm.CommandText = "UPDATE `project_dormitory`.`TypeRoom` SET `TypeRoomName` = @TypeRoomName, " +
                "`Description` = @Description1, `Capacity` = @Capacity, `price` = @price " +
                "WHERE `TypeRoom_ID` = @TypeRoom_ID";

            comm.Parameters.AddWithValue("@TypeRoom_ID", TypeRoom_ID);
            comm.Parameters.AddWithValue("@TypeRoomName", TypeRoomName);
            comm.Parameters.AddWithValue("@Description1", Description1);
            comm.Parameters.AddWithValue("@Capacity", Capacity);
            comm.Parameters.AddWithValue("@price", price);

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
            load_typeroom_griddata_init();
            clear_data1();
        }

        private void typeroom_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (typeroom_dataGridView.SelectedRows.Count > 0) // make sure user select at least 1 row 
            {
                string TypeRoom = typeroom_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string TypeR = typeroom_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                string Description1 = typeroom_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
                string Capacity = typeroom_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
                string price = typeroom_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

                Tid_textbox.Text = TypeRoom;
                trname.Text = TypeR;
                Description.Text = Description1;
                capasity.Text = Capacity;
                price_textBox.Text = price;
            }

        }

        private void typeroom_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string TypeRoom = room_dataGridView.SelectedRows[0].Cells[0].Value.ToString();
            string TypeR = room_dataGridView.SelectedRows[0].Cells[1].Value.ToString();
            string Description1 = room_dataGridView.SelectedRows[0].Cells[2].Value.ToString();
            string Capacity = room_dataGridView.SelectedRows[0].Cells[3].Value.ToString();
            string price = room_dataGridView.SelectedRows[0].Cells[4].Value.ToString();

            Tid_textbox.Text = TypeRoom;
            trname.Text = TypeR;
            Description.Text = Description1;
            capasity.Text = Capacity;
            price_textBox.Text = price;
        }
    }
}
