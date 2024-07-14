namespace dormitory.Forms
{
    partial class FormRSRDocuments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRSRDocuments));
            this.insert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.status_lable = new System.Windows.Forms.TextBox();
            this.dores_datepicker = new System.Windows.Forms.DateTimePicker();
            this.dosre_datepicker = new System.Windows.Forms.DateTimePicker();
            this.Contactid_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.time_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Receive_radioButton1 = new System.Windows.Forms.RadioButton();
            this.send = new System.Windows.Forms.RadioButton();
            this.Reserve_Send_Receive = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Document_ID_combobox = new System.Windows.Forms.ComboBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.Reservertid_textbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Document_ID_label5 = new System.Windows.Forms.Label();
            this.Subject_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            this.Rsr_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rsr_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(966, 320);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(164, 55);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "เพิ่มข้อมูลการจองรับ/ส่ง";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(966, 539);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(164, 55);
            this.clear_btn.TabIndex = 19;
            this.clear_btn.Text = "ล้างข้อมูล";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delate_btn
            // 
            this.delate_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.delate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delate_btn.Location = new System.Drawing.Point(966, 466);
            this.delate_btn.Name = "delate_btn";
            this.delate_btn.Size = new System.Drawing.Size(164, 55);
            this.delate_btn.TabIndex = 18;
            this.delate_btn.Text = "ลบรายการ";
            this.delate_btn.UseVisualStyleBackColor = true;
            this.delate_btn.Click += new System.EventHandler(this.delate_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.status_lable);
            this.panel1.Controls.Add(this.dores_datepicker);
            this.panel1.Controls.Add(this.dosre_datepicker);
            this.panel1.Controls.Add(this.Contactid_textbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.time_textbox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.Receive_radioButton1);
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.Reserve_Send_Receive);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Document_ID_combobox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.Reservertid_textbox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Document_ID_label5);
            this.panel1.Controls.Add(this.Subject_label);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 277);
            this.panel1.TabIndex = 16;
            // 
            // status_lable
            // 
            this.status_lable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.status_lable.Location = new System.Drawing.Point(549, 209);
            this.status_lable.Name = "status_lable";
            this.status_lable.Size = new System.Drawing.Size(223, 26);
            this.status_lable.TabIndex = 52;
            // 
            // dores_datepicker
            // 
            this.dores_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dores_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dores_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dores_datepicker.Location = new System.Drawing.Point(876, 205);
            this.dores_datepicker.Name = "dores_datepicker";
            this.dores_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dores_datepicker.TabIndex = 51;
            // 
            // dosre_datepicker
            // 
            this.dosre_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dosre_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dosre_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dosre_datepicker.Location = new System.Drawing.Point(876, 91);
            this.dosre_datepicker.Name = "dosre_datepicker";
            this.dosre_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dosre_datepicker.TabIndex = 50;
            // 
            // Contactid_textbox
            // 
            this.Contactid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contactid_textbox.Location = new System.Drawing.Point(146, 98);
            this.Contactid_textbox.Name = "Contactid_textbox";
            this.Contactid_textbox.Size = new System.Drawing.Size(223, 26);
            this.Contactid_textbox.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Contact ID";
            // 
            // time_textbox
            // 
            this.time_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.time_textbox.Location = new System.Drawing.Point(549, 141);
            this.time_textbox.Name = "time_textbox";
            this.time_textbox.Size = new System.Drawing.Size(223, 26);
            this.time_textbox.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(409, 98);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 25);
            this.label10.TabIndex = 46;
            this.label10.Text = "Time of Request  Ex:  12:00";
            // 
            // Receive_radioButton1
            // 
            this.Receive_radioButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Receive_radioButton1.AutoSize = true;
            this.Receive_radioButton1.Location = new System.Drawing.Point(256, 209);
            this.Receive_radioButton1.Name = "Receive_radioButton1";
            this.Receive_radioButton1.Size = new System.Drawing.Size(91, 24);
            this.Receive_radioButton1.TabIndex = 42;
            this.Receive_radioButton1.TabStop = true;
            this.Receive_radioButton1.Text = "Receive";
            this.Receive_radioButton1.UseVisualStyleBackColor = true;
            // 
            // send
            // 
            this.send.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.send.AutoSize = true;
            this.send.Location = new System.Drawing.Point(157, 208);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(69, 24);
            this.send.TabIndex = 41;
            this.send.TabStop = true;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // Reserve_Send_Receive
            // 
            this.Reserve_Send_Receive.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reserve_Send_Receive.AutoSize = true;
            this.Reserve_Send_Receive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reserve_Send_Receive.Location = new System.Drawing.Point(51, 206);
            this.Reserve_Send_Receive.Name = "Reserve_Send_Receive";
            this.Reserve_Send_Receive.Size = new System.Drawing.Size(67, 25);
            this.Reserve_Send_Receive.TabIndex = 40;
            this.Reserve_Send_Receive.Text = "Select";
            this.Reserve_Send_Receive.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(467, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Status";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(806, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Date of request";
            // 
            // Document_ID_combobox
            // 
            this.Document_ID_combobox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Document_ID_combobox.FormattingEnabled = true;
            this.Document_ID_combobox.Items.AddRange(new object[] {
            "---Select---"});
            this.Document_ID_combobox.Location = new System.Drawing.Point(549, 37);
            this.Document_ID_combobox.Name = "Document_ID_combobox";
            this.Document_ID_combobox.Size = new System.Drawing.Size(223, 28);
            this.Document_ID_combobox.TabIndex = 27;
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_textbox.Location = new System.Drawing.Point(146, 155);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(223, 26);
            this.name_textbox.TabIndex = 17;
            // 
            // Reservertid_textbox
            // 
            this.Reservertid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Reservertid_textbox.Location = new System.Drawing.Point(146, 35);
            this.Reservertid_textbox.Name = "Reservertid_textbox";
            this.Reservertid_textbox.Size = new System.Drawing.Size(223, 26);
            this.Reservertid_textbox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(806, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date of Reserve";
            // 
            // Document_ID_label5
            // 
            this.Document_ID_label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Document_ID_label5.AutoSize = true;
            this.Document_ID_label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Document_ID_label5.Location = new System.Drawing.Point(404, 40);
            this.Document_ID_label5.Name = "Document_ID_label5";
            this.Document_ID_label5.Size = new System.Drawing.Size(131, 25);
            this.Document_ID_label5.TabIndex = 4;
            this.Document_ID_label5.Text = "Document_ID";
            // 
            // Subject_label
            // 
            this.Subject_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subject_label.AutoSize = true;
            this.Subject_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_label.Location = new System.Drawing.Point(51, 155);
            this.Subject_label.Name = "Subject_label";
            this.Subject_label.Size = new System.Drawing.Size(78, 25);
            this.Subject_label.TabIndex = 2;
            this.Subject_label.Text = "Subject";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reservert ID";
            // 
            // update_btn
            // 
            this.update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(966, 395);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(164, 55);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "เปลี่ยนข้อมูล";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // Rsr_dataGridView
            // 
            this.Rsr_dataGridView.AllowUserToOrderColumns = true;
            this.Rsr_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Rsr_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Rsr_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.Rsr_dataGridView.Name = "Rsr_dataGridView";
            this.Rsr_dataGridView.RowHeadersWidth = 62;
            this.Rsr_dataGridView.RowTemplate.Height = 28;
            this.Rsr_dataGridView.Size = new System.Drawing.Size(923, 308);
            this.Rsr_dataGridView.TabIndex = 17;
            this.Rsr_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Rsr_dataGridView_CellClick);
            // 
            // FormRSRDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 629);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delate_btn);
            this.Controls.Add(this.Rsr_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.DoubleBuffered = true;
            this.Name = "FormRSRDocuments";
            this.Text = "FormRSRDocuments";
            this.Load += new System.EventHandler(this.FormRSRDocuments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Rsr_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox Document_ID_combobox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox Reservertid_textbox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Document_ID_label5;
        private System.Windows.Forms.Label Subject_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Rsr_dataGridView;
        private System.Windows.Forms.Label Reserve_Send_Receive;
        private System.Windows.Forms.TextBox time_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Contactid_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dores_datepicker;
        private System.Windows.Forms.DateTimePicker dosre_datepicker;
        private System.Windows.Forms.TextBox status_lable;
        private System.Windows.Forms.RadioButton Receive_radioButton1;
        private System.Windows.Forms.RadioButton send;
    }
}