namespace dormitory.Forms
{
    partial class FormBook_a_tutoring_room
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
            this.insert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.btr_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dosre_datepicker = new System.Windows.Forms.DateTimePicker();
            this.Contactid_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toe_textBox = new System.Windows.Forms.TextBox();
            this.tob_textBox = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bid_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btr_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.insert_btn.Text = "เพิ่มข้อมูลการขอใช้";
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
            this.delate_btn.Text = "ลบข้อรายการ";
            this.delate_btn.UseVisualStyleBackColor = true;
            this.delate_btn.Click += new System.EventHandler(this.delate_btn_Click);
            // 
            // btr_dataGridView
            // 
            this.btr_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btr_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.btr_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.btr_dataGridView.Name = "btr_dataGridView";
            this.btr_dataGridView.RowHeadersWidth = 62;
            this.btr_dataGridView.RowTemplate.Height = 28;
            this.btr_dataGridView.Size = new System.Drawing.Size(923, 308);
            this.btr_dataGridView.TabIndex = 17;
            this.btr_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.btr_dataGridView_CellClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.dosre_datepicker);
            this.panel1.Controls.Add(this.Contactid_textbox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.toe_textBox);
            this.panel1.Controls.Add(this.tob_textBox);
            this.panel1.Controls.Add(this.description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bid_textbox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 277);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // dosre_datepicker
            // 
            this.dosre_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dosre_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dosre_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dosre_datepicker.Location = new System.Drawing.Point(548, 126);
            this.dosre_datepicker.Name = "dosre_datepicker";
            this.dosre_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dosre_datepicker.TabIndex = 43;
            // 
            // Contactid_textbox
            // 
            this.Contactid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contactid_textbox.Location = new System.Drawing.Point(161, 126);
            this.Contactid_textbox.Name = "Contactid_textbox";
            this.Contactid_textbox.Size = new System.Drawing.Size(223, 26);
            this.Contactid_textbox.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(839, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Time";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(839, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "end ex. 21:00";
            // 
            // toe_textBox
            // 
            this.toe_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toe_textBox.Location = new System.Drawing.Point(879, 206);
            this.toe_textBox.Name = "toe_textBox";
            this.toe_textBox.Size = new System.Drawing.Size(223, 26);
            this.toe_textBox.TabIndex = 34;
            // 
            // tob_textBox
            // 
            this.tob_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tob_textBox.Location = new System.Drawing.Point(879, 126);
            this.tob_textBox.Name = "tob_textBox";
            this.tob_textBox.Size = new System.Drawing.Size(223, 26);
            this.tob_textBox.TabIndex = 33;
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description.Location = new System.Drawing.Point(548, 67);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(223, 26);
            this.description.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Description";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Contact ID";
            // 
            // bid_textbox
            // 
            this.bid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bid_textbox.Location = new System.Drawing.Point(161, 68);
            this.bid_textbox.Name = "bid_textbox";
            this.bid_textbox.Size = new System.Drawing.Size(223, 26);
            this.bid_textbox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(839, 79);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Begin ex. 12:00";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(467, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            // FormBook_a_tutoring_room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            //this.BackgroundImage = global::dormitory.Properties.Resources.ดีไซน์ที่ยังไม่ได้ตั้งชื่อ__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 629);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delate_btn);
            this.Controls.Add(this.btr_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.DoubleBuffered = true;
            this.Name = "FormBook_a_tutoring_room";
            this.Text = "FormBook_a_tutoring_room";
            this.Load += new System.EventHandler(this.FormBook_a_tutoring_room_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btr_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.DataGridView btr_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox bid_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox toe_textBox;
        private System.Windows.Forms.TextBox tob_textBox;
        private System.Windows.Forms.TextBox Contactid_textbox;
        private System.Windows.Forms.DateTimePicker dosre_datepicker;
    }
}