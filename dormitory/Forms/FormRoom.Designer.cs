namespace dormitory.Forms
{
    partial class FormRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.price_textBox = new System.Windows.Forms.TextBox();
            this.Price_label = new System.Windows.Forms.Label();
            this.insert1_btn = new System.Windows.Forms.Button();
            this.clear_btn2 = new System.Windows.Forms.Button();
            this.delete2_btn = new System.Windows.Forms.Button();
            this.update1_btn = new System.Windows.Forms.Button();
            this.Description = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.capasity = new System.Windows.Forms.TextBox();
            this.trname = new System.Windows.Forms.TextBox();
            this.Tid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.buclear_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.updeat_btn = new System.Windows.Forms.Button();
            this.Dormitory_textBox = new System.Windows.Forms.TextBox();
            this.type_roomcomboBox = new System.Windows.Forms.ComboBox();
            this.Avi_textbox = new System.Windows.Forms.TextBox();
            this.roomnum_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typeroom_dataGridView = new System.Windows.Forms.DataGridView();
            this.room_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeroom_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.price_textBox);
            this.panel1.Controls.Add(this.Price_label);
            this.panel1.Controls.Add(this.insert1_btn);
            this.panel1.Controls.Add(this.clear_btn2);
            this.panel1.Controls.Add(this.delete2_btn);
            this.panel1.Controls.Add(this.update1_btn);
            this.panel1.Controls.Add(this.Description);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.capasity);
            this.panel1.Controls.Add(this.trname);
            this.panel1.Controls.Add(this.Tid_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.insert_btn);
            this.panel1.Controls.Add(this.buclear_btn);
            this.panel1.Controls.Add(this.delete_btn);
            this.panel1.Controls.Add(this.updeat_btn);
            this.panel1.Controls.Add(this.Dormitory_textBox);
            this.panel1.Controls.Add(this.type_roomcomboBox);
            this.panel1.Controls.Add(this.Avi_textbox);
            this.panel1.Controls.Add(this.roomnum_textbox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 277);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // price_textBox
            // 
            this.price_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.price_textBox.Location = new System.Drawing.Point(768, 217);
            this.price_textBox.Name = "price_textBox";
            this.price_textBox.Size = new System.Drawing.Size(190, 26);
            this.price_textBox.TabIndex = 51;
            // 
            // Price_label
            // 
            this.Price_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Price_label.AutoSize = true;
            this.Price_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_label.Location = new System.Drawing.Point(685, 216);
            this.Price_label.Name = "Price_label";
            this.Price_label.Size = new System.Drawing.Size(56, 25);
            this.Price_label.TabIndex = 50;
            this.Price_label.Text = "Price";
            // 
            // insert1_btn
            // 
            this.insert1_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insert1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert1_btn.Location = new System.Drawing.Point(989, 29);
            this.insert1_btn.Name = "insert1_btn";
            this.insert1_btn.Size = new System.Drawing.Size(132, 40);
            this.insert1_btn.TabIndex = 48;
            this.insert1_btn.Text = "เพิ่มข้อมูล";
            this.insert1_btn.UseVisualStyleBackColor = true;
            this.insert1_btn.Click += new System.EventHandler(this.insert1_btn_Click);
            // 
            // clear_btn2
            // 
            this.clear_btn2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clear_btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn2.Location = new System.Drawing.Point(989, 219);
            this.clear_btn2.Name = "clear_btn2";
            this.clear_btn2.Size = new System.Drawing.Size(132, 40);
            this.clear_btn2.TabIndex = 47;
            this.clear_btn2.Text = "ล้างข้อมูล";
            this.clear_btn2.UseVisualStyleBackColor = true;
            this.clear_btn2.Click += new System.EventHandler(this.clear_btn2_Click);
            // 
            // delete2_btn
            // 
            this.delete2_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delete2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete2_btn.Location = new System.Drawing.Point(989, 155);
            this.delete2_btn.Name = "delete2_btn";
            this.delete2_btn.Size = new System.Drawing.Size(132, 40);
            this.delete2_btn.TabIndex = 46;
            this.delete2_btn.Text = "ลบข้อมูล";
            this.delete2_btn.UseVisualStyleBackColor = true;
            this.delete2_btn.Click += new System.EventHandler(this.delete2_btn_Click);
            // 
            // update1_btn
            // 
            this.update1_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update1_btn.Location = new System.Drawing.Point(989, 91);
            this.update1_btn.Name = "update1_btn";
            this.update1_btn.Size = new System.Drawing.Size(132, 40);
            this.update1_btn.TabIndex = 49;
            this.update1_btn.Text = "ยืนยันข้อมูล";
            this.update1_btn.UseVisualStyleBackColor = true;
            this.update1_btn.Click += new System.EventHandler(this.update1_btn_Click);
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Description.Location = new System.Drawing.Point(768, 178);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(190, 26);
            this.Description.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(632, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Description";
            // 
            // capasity
            // 
            this.capasity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capasity.Location = new System.Drawing.Point(768, 133);
            this.capasity.Name = "capasity";
            this.capasity.Size = new System.Drawing.Size(190, 26);
            this.capasity.TabIndex = 43;
            // 
            // trname
            // 
            this.trname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.trname.Location = new System.Drawing.Point(768, 92);
            this.trname.Name = "trname";
            this.trname.Size = new System.Drawing.Size(190, 26);
            this.trname.TabIndex = 42;
            // 
            // Tid_textbox
            // 
            this.Tid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Tid_textbox.Location = new System.Drawing.Point(768, 46);
            this.Tid_textbox.Name = "Tid_textbox";
            this.Tid_textbox.Size = new System.Drawing.Size(190, 26);
            this.Tid_textbox.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(652, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 40;
            this.label1.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(632, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Type Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(609, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 38;
            this.label5.Text = "TypeRoom ID";
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(434, 27);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(132, 40);
            this.insert_btn.TabIndex = 36;
            this.insert_btn.Text = "เพิ่มข้อมูล";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // buclear_btn
            // 
            this.buclear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buclear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buclear_btn.Location = new System.Drawing.Point(434, 217);
            this.buclear_btn.Name = "buclear_btn";
            this.buclear_btn.Size = new System.Drawing.Size(132, 40);
            this.buclear_btn.TabIndex = 35;
            this.buclear_btn.Text = "ล้างข้อมูล";
            this.buclear_btn.UseVisualStyleBackColor = true;
            this.buclear_btn.Click += new System.EventHandler(this.buclear_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.Location = new System.Drawing.Point(434, 153);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(132, 40);
            this.delete_btn.TabIndex = 34;
            this.delete_btn.Text = "ลบข้อมูล";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // updeat_btn
            // 
            this.updeat_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.updeat_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updeat_btn.Location = new System.Drawing.Point(434, 89);
            this.updeat_btn.Name = "updeat_btn";
            this.updeat_btn.Size = new System.Drawing.Size(132, 40);
            this.updeat_btn.TabIndex = 37;
            this.updeat_btn.Text = "ยืนยันข้อมูล";
            this.updeat_btn.UseVisualStyleBackColor = true;
            this.updeat_btn.Click += new System.EventHandler(this.updeat_btn_Click);
            // 
            // Dormitory_textBox
            // 
            this.Dormitory_textBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dormitory_textBox.Location = new System.Drawing.Point(185, 152);
            this.Dormitory_textBox.Name = "Dormitory_textBox";
            this.Dormitory_textBox.Size = new System.Drawing.Size(227, 26);
            this.Dormitory_textBox.TabIndex = 30;
            // 
            // type_roomcomboBox
            // 
            this.type_roomcomboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.type_roomcomboBox.FormattingEnabled = true;
            this.type_roomcomboBox.Items.AddRange(new object[] {
            "---Select---"});
            this.type_roomcomboBox.Location = new System.Drawing.Point(185, 96);
            this.type_roomcomboBox.Name = "type_roomcomboBox";
            this.type_roomcomboBox.Size = new System.Drawing.Size(227, 28);
            this.type_roomcomboBox.TabIndex = 29;
            // 
            // Avi_textbox
            // 
            this.Avi_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Avi_textbox.Location = new System.Drawing.Point(185, 217);
            this.Avi_textbox.Name = "Avi_textbox";
            this.Avi_textbox.Size = new System.Drawing.Size(227, 26);
            this.Avi_textbox.TabIndex = 19;
            // 
            // roomnum_textbox
            // 
            this.roomnum_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.roomnum_textbox.Location = new System.Drawing.Point(185, 36);
            this.roomnum_textbox.Name = "roomnum_textbox";
            this.roomnum_textbox.Size = new System.Drawing.Size(227, 26);
            this.roomnum_textbox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(56, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(104, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Availability";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dormitory";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "TypeRoom";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room Number";
            // 
            // typeroom_dataGridView
            // 
            this.typeroom_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typeroom_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typeroom_dataGridView.Location = new System.Drawing.Point(616, 309);
            this.typeroom_dataGridView.Name = "typeroom_dataGridView";
            this.typeroom_dataGridView.RowHeadersWidth = 62;
            this.typeroom_dataGridView.RowTemplate.Height = 28;
            this.typeroom_dataGridView.Size = new System.Drawing.Size(547, 308);
            this.typeroom_dataGridView.TabIndex = 53;
            this.typeroom_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typeroom_dataGridView_CellClick);
            this.typeroom_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typeroom_dataGridView_CellContentClick);
            // 
            // room_dataGridView
            // 
            this.room_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.room_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.room_dataGridView.Location = new System.Drawing.Point(11, 309);
            this.room_dataGridView.Name = "room_dataGridView";
            this.room_dataGridView.RowHeadersWidth = 62;
            this.room_dataGridView.RowTemplate.Height = 28;
            this.room_dataGridView.Size = new System.Drawing.Size(573, 308);
            this.room_dataGridView.TabIndex = 52;
            this.room_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.room_dataGridView_CellClick);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 629);
            this.Controls.Add(this.typeroom_dataGridView);
            this.Controls.Add(this.room_dataGridView);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormRoom";
            this.Text = "FormRoom";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeroom_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.room_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Avi_textbox;
        private System.Windows.Forms.TextBox roomnum_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Dormitory_textBox;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox capasity;
        private System.Windows.Forms.TextBox trname;
        private System.Windows.Forms.TextBox Tid_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button buclear_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button updeat_btn;
        private System.Windows.Forms.Button insert1_btn;
        private System.Windows.Forms.Button clear_btn2;
        private System.Windows.Forms.Button delete2_btn;
        private System.Windows.Forms.Button update1_btn;
        private System.Windows.Forms.TextBox price_textBox;
        private System.Windows.Forms.Label Price_label;
        private System.Windows.Forms.DataGridView typeroom_dataGridView;
        private System.Windows.Forms.DataGridView room_dataGridView;
        private System.Windows.Forms.ComboBox type_roomcomboBox;
    }
}