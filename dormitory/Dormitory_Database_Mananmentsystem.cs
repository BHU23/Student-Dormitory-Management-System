using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dormitory
{
    public partial class Dormitory_Database_Mananmentsystem : Form
    {
        private Button previousButton;
        private Form activeForm;
        public Dormitory_Database_Mananmentsystem()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ChangeButtonColor(Button button)
        {
            button.ForeColor = Color.Black;
            button.BackColor = Color.Wheat;
            button.Font = new Font(button.Font.FontFamily, 12);
        }
        private void ChangebButtonColor(Button button)
        {
            button.ForeColor = Color.White;
            button.BackColor = Color.Black;
            button.Font = new Font(button.Font.FontFamily, 10);
        }
        private void previousofButton(object sender)
        {
            if (previousButton != null)
            {
                // กำหนดสีเดิมให้กับปุ่มก่อนหน้า
                ChangebButtonColor(previousButton);
            }

            // ปรับสีปุ่มใหม่ที่ถูกคลิก
            if((Button)sender != home_button)
                ChangeButtonColor((Button)sender);

            // เก็บปุ่มที่ถูกคลิกเพื่อใช้ในการกลับสีให้กับปุ่มอื่น ๆ
            previousButton = (Button)sender;
        }
        private void OpenChildForm(Form childForm, object btnSender,Button b)
        {
            if (activeForm != null)
                activeForm.Close();
            previousofButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            label1.Text = b.Text;
        }
        private void student_register_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormHome(), sender, home_button);
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormStudent(), sender, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormContact1(), sender, button3);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormDormitory(), sender, button4);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {  
            OpenChildForm(new Forms.FormRoom(), sender, button5);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRSRDocuments(), sender, button9);
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormCounselor(), sender, button6);
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBook_a_tutoring_room(), sender, button7);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRepair(), sender, button8);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPayment(), sender, button9);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
