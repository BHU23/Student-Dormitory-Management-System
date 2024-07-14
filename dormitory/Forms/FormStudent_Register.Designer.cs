namespace dormitory.Forms
{
    partial class FormStudent_Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scholarship_combobox = new System.Windows.Forms.ComboBox();
            this.major_combobox = new System.Windows.Forms.ComboBox();
            this.dob_datepicker = new System.Windows.Forms.DateTimePicker();
            this.female_radioButton = new System.Windows.Forms.RadioButton();
            this.male_radioButton = new System.Windows.Forms.RadioButton();
            this.Domicile_textbox = new System.Windows.Forms.TextBox();
            this.telephone_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.sid_textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.student_dataGridView = new System.Windows.Forms.DataGridView();
            this.delate_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.scholarship_combobox);
            this.panel1.Controls.Add(this.major_combobox);
            this.panel1.Controls.Add(this.dob_datepicker);
            this.panel1.Controls.Add(this.female_radioButton);
            this.panel1.Controls.Add(this.male_radioButton);
            this.panel1.Controls.Add(this.Domicile_textbox);
            this.panel1.Controls.Add(this.telephone_textbox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.sid_textbox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1256, 277);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // scholarship_combobox
            // 
            this.scholarship_combobox.FormattingEnabled = true;
            this.scholarship_combobox.Location = new System.Drawing.Point(531, 125);
            this.scholarship_combobox.Name = "scholarship_combobox";
            this.scholarship_combobox.Size = new System.Drawing.Size(227, 28);
            this.scholarship_combobox.TabIndex = 28;
            this.scholarship_combobox.SelectedIndexChanged += new System.EventHandler(this.scholarship_combobox_SelectedIndexChanged);
            // 
            // major_combobox
            // 
            this.major_combobox.FormattingEnabled = true;
            this.major_combobox.Location = new System.Drawing.Point(528, 60);
            this.major_combobox.Name = "major_combobox";
            this.major_combobox.Size = new System.Drawing.Size(227, 28);
            this.major_combobox.TabIndex = 27;
            this.major_combobox.SelectedIndexChanged += new System.EventHandler(this.major_combobox_SelectedIndexChanged);
            // 
            // dob_datepicker
            // 
            this.dob_datepicker.Location = new System.Drawing.Point(531, 187);
            this.dob_datepicker.Name = "dob_datepicker";
            this.dob_datepicker.Size = new System.Drawing.Size(292, 26);
            this.dob_datepicker.TabIndex = 24;
            this.dob_datepicker.ValueChanged += new System.EventHandler(this.dob_datepicker_ValueChanged);
            // 
            // female_radioButton
            // 
            this.female_radioButton.AutoSize = true;
            this.female_radioButton.Location = new System.Drawing.Point(223, 187);
            this.female_radioButton.Name = "female_radioButton";
            this.female_radioButton.Size = new System.Drawing.Size(87, 24);
            this.female_radioButton.TabIndex = 21;
            this.female_radioButton.TabStop = true;
            this.female_radioButton.Text = "Female";
            this.female_radioButton.UseVisualStyleBackColor = true;
            this.female_radioButton.CheckedChanged += new System.EventHandler(this.female_radioButton_CheckedChanged);
            // 
            // male_radioButton
            // 
            this.male_radioButton.AutoSize = true;
            this.male_radioButton.Location = new System.Drawing.Point(136, 186);
            this.male_radioButton.Name = "male_radioButton";
            this.male_radioButton.Size = new System.Drawing.Size(68, 24);
            this.male_radioButton.TabIndex = 20;
            this.male_radioButton.TabStop = true;
            this.male_radioButton.Text = "Male";
            this.male_radioButton.UseVisualStyleBackColor = true;
            this.male_radioButton.CheckedChanged += new System.EventHandler(this.male_radioButton_CheckedChanged);
            // 
            // Domicile_textbox
            // 
            this.Domicile_textbox.Location = new System.Drawing.Point(1013, 62);
            this.Domicile_textbox.Name = "Domicile_textbox";
            this.Domicile_textbox.Size = new System.Drawing.Size(227, 26);
            this.Domicile_textbox.TabIndex = 19;
            this.Domicile_textbox.TextChanged += new System.EventHandler(this.Domicile_textbox_TextChanged);
            // 
            // telephone_textbox
            // 
            this.telephone_textbox.Location = new System.Drawing.Point(1013, 125);
            this.telephone_textbox.Name = "telephone_textbox";
            this.telephone_textbox.Size = new System.Drawing.Size(227, 26);
            this.telephone_textbox.TabIndex = 18;
            this.telephone_textbox.TextChanged += new System.EventHandler(this.telephone_textbox_TextChanged);
            // 
            // name_textbox
            // 
            this.name_textbox.Location = new System.Drawing.Point(134, 121);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(227, 26);
            this.name_textbox.TabIndex = 17;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // sid_textbox
            // 
            this.sid_textbox.Location = new System.Drawing.Point(134, 60);
            this.sid_textbox.Name = "sid_textbox";
            this.sid_textbox.Size = new System.Drawing.Size(227, 26);
            this.sid_textbox.TabIndex = 16;
            this.sid_textbox.TextChanged += new System.EventHandler(this.sid_textbox_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(849, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 25);
            this.label14.TabIndex = 10;
            this.label14.Text = "Phone Number";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(902, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Domicile";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(37, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Gender";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 187);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date of Birth";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(391, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Scholarship";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Major";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // student_dataGridView
            // 
            this.student_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_dataGridView.Location = new System.Drawing.Point(12, 307);
            this.student_dataGridView.Name = "student_dataGridView";
            this.student_dataGridView.RowHeadersWidth = 62;
            this.student_dataGridView.RowTemplate.Height = 28;
            this.student_dataGridView.Size = new System.Drawing.Size(1026, 308);
            this.student_dataGridView.TabIndex = 3;
            this.student_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.student_dataGridView_CellContentClick);
            // 
            // delate_btn
            // 
            this.delate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delate_btn.Location = new System.Drawing.Point(1070, 459);
            this.delate_btn.Name = "delate_btn";
            this.delate_btn.Size = new System.Drawing.Size(165, 55);
            this.delate_btn.TabIndex = 6;
            this.delate_btn.Text = "ลบข้อมูลนักศึกษา";
            this.delate_btn.UseVisualStyleBackColor = true;
            this.delate_btn.Click += new System.EventHandler(this.delate_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(1070, 532);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(165, 55);
            this.clear_btn.TabIndex = 7;
            this.clear_btn.Text = "ล้างข้อมูล";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(1070, 313);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(165, 55);
            this.insert_btn.TabIndex = 8;
            this.insert_btn.Text = "เพิ่มข้อมูลนักศึกษา";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(1070, 388);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(165, 55);
            this.update_btn.TabIndex = 9;
            this.update_btn.Text = "ยืนยันข้อมูล";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // FormStudent_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            //this.BackgroundImage = global::dormitory.Properties.Resources.ดีไซน์ที่ยังไม่ได้ตั้งชื่อ__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 629);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delate_btn);
            this.Controls.Add(this.student_dataGridView);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormStudent_Register";
            this.Text = "FormStudent_Register";
            this.Load += new System.EventHandler(this.FormStudent_Register_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.student_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Domicile_textbox;
        private System.Windows.Forms.TextBox telephone_textbox;
        private System.Windows.Forms.TextBox sid_textbox;
        private System.Windows.Forms.RadioButton female_radioButton;
        private System.Windows.Forms.RadioButton male_radioButton;
        private System.Windows.Forms.DateTimePicker dob_datepicker;
        private System.Windows.Forms.ComboBox scholarship_combobox;
        private System.Windows.Forms.ComboBox major_combobox;
        private System.Windows.Forms.DataGridView student_dataGridView;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox name_textbox;
    }
}