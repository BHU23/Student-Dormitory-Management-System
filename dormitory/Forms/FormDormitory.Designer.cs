namespace dormitory.Forms
{
    partial class FormDormitory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDormitory));
            this.dorm_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.description_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.capacity_textbox = new System.Windows.Forms.TextBox();
            this.Typedromname = new System.Windows.Forms.TextBox();
            this.Typedrom = new System.Windows.Forms.TextBox();
            this.bb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert1_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.delate2_btn = new System.Windows.Forms.Button();
            this.update2_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.TypeDormitory_comboBox = new System.Windows.Forms.ComboBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.contact_textbox = new System.Windows.Forms.TextBox();
            this.Address_leble = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.update_btn = new System.Windows.Forms.Button();
            this.did_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lablee = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.typedorm_dataGridVie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dorm_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typedorm_dataGridVie)).BeginInit();
            this.SuspendLayout();
            // 
            // dorm_dataGridView
            // 
            this.dorm_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dorm_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dorm_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.dorm_dataGridView.Name = "dorm_dataGridView";
            this.dorm_dataGridView.RowHeadersWidth = 62;
            this.dorm_dataGridView.RowTemplate.Height = 28;
            this.dorm_dataGridView.Size = new System.Drawing.Size(573, 308);
            this.dorm_dataGridView.TabIndex = 17;
            this.dorm_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dorm_dataGridView_CellClick);
            this.dorm_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dorm_dataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.description_textbox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.capacity_textbox);
            this.panel1.Controls.Add(this.Typedromname);
            this.panel1.Controls.Add(this.Typedrom);
            this.panel1.Controls.Add(this.bb);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.insert1_btn);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.delate2_btn);
            this.panel1.Controls.Add(this.update2_btn);
            this.panel1.Controls.Add(this.insert_btn);
            this.panel1.Controls.Add(this.TypeDormitory_comboBox);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.delate_btn);
            this.panel1.Controls.Add(this.contact_textbox);
            this.panel1.Controls.Add(this.Address_leble);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.update_btn);
            this.panel1.Controls.Add(this.did_textbox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.lablee);
            this.panel1.Controls.Add(this.address);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 277);
            this.panel1.TabIndex = 16;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // description_textbox
            // 
            this.description_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.description_textbox.Location = new System.Drawing.Point(765, 219);
            this.description_textbox.Name = "description_textbox";
            this.description_textbox.Size = new System.Drawing.Size(190, 26);
            this.description_textbox.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(629, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 25);
            this.label6.TabIndex = 32;
            this.label6.Text = "Description";
            // 
            // capacity_textbox
            // 
            this.capacity_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.capacity_textbox.Location = new System.Drawing.Point(765, 161);
            this.capacity_textbox.Name = "capacity_textbox";
            this.capacity_textbox.Size = new System.Drawing.Size(190, 26);
            this.capacity_textbox.TabIndex = 31;
            // 
            // Typedromname
            // 
            this.Typedromname.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Typedromname.Location = new System.Drawing.Point(765, 106);
            this.Typedromname.Name = "Typedromname";
            this.Typedromname.Size = new System.Drawing.Size(190, 26);
            this.Typedromname.TabIndex = 30;
            // 
            // Typedrom
            // 
            this.Typedrom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Typedrom.Location = new System.Drawing.Point(765, 45);
            this.Typedrom.Name = "Typedrom";
            this.Typedrom.Size = new System.Drawing.Size(190, 26);
            this.Typedrom.TabIndex = 29;
            // 
            // bb
            // 
            this.bb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bb.AutoSize = true;
            this.bb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bb.Location = new System.Drawing.Point(649, 162);
            this.bb.Name = "bb";
            this.bb.Size = new System.Drawing.Size(89, 25);
            this.bb.TabIndex = 28;
            this.bb.Text = "Capacity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(629, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 27;
            this.label4.Text = "Type Name";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(584, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "TypeDormiory ID";
            // 
            // insert1_btn
            // 
            this.insert1_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insert1_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert1_btn.Location = new System.Drawing.Point(995, 29);
            this.insert1_btn.Name = "insert1_btn";
            this.insert1_btn.Size = new System.Drawing.Size(132, 40);
            this.insert1_btn.TabIndex = 24;
            this.insert1_btn.Text = "เพิ่มข้อมูล";
            this.insert1_btn.UseVisualStyleBackColor = true;
            this.insert1_btn.Click += new System.EventHandler(this.insert1_btn_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(995, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 40);
            this.button2.TabIndex = 23;
            this.button2.Text = "ล้างข้อมูล";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // delate2_btn
            // 
            this.delate2_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delate2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delate2_btn.Location = new System.Drawing.Point(995, 155);
            this.delate2_btn.Name = "delate2_btn";
            this.delate2_btn.Size = new System.Drawing.Size(132, 40);
            this.delate2_btn.TabIndex = 22;
            this.delate2_btn.Text = "ลบข้อมูล";
            this.delate2_btn.UseVisualStyleBackColor = true;
            this.delate2_btn.Click += new System.EventHandler(this.delate2_btn_Click);
            // 
            // update2_btn
            // 
            this.update2_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update2_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update2_btn.Location = new System.Drawing.Point(995, 91);
            this.update2_btn.Name = "update2_btn";
            this.update2_btn.Size = new System.Drawing.Size(132, 40);
            this.update2_btn.TabIndex = 25;
            this.update2_btn.Text = "ยืนยันข้อมูล";
            this.update2_btn.UseVisualStyleBackColor = true;
            this.update2_btn.Click += new System.EventHandler(this.update2_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(26, 213);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(132, 40);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "เพิ่มข้อมูล";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // TypeDormitory_comboBox
            // 
            this.TypeDormitory_comboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TypeDormitory_comboBox.FormattingEnabled = true;
            this.TypeDormitory_comboBox.Items.AddRange(new object[] {
            "---Select---"});
            this.TypeDormitory_comboBox.Location = new System.Drawing.Point(375, 70);
            this.TypeDormitory_comboBox.Name = "TypeDormitory_comboBox";
            this.TypeDormitory_comboBox.Size = new System.Drawing.Size(190, 28);
            this.TypeDormitory_comboBox.TabIndex = 21;
            // 
            // clear_btn
            // 
            this.clear_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.Location = new System.Drawing.Point(481, 213);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(132, 40);
            this.clear_btn.TabIndex = 19;
            this.clear_btn.Text = "ล้างข้อมูล";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // delate_btn
            // 
            this.delate_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.delate_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delate_btn.Location = new System.Drawing.Point(330, 213);
            this.delate_btn.Name = "delate_btn";
            this.delate_btn.Size = new System.Drawing.Size(132, 40);
            this.delate_btn.TabIndex = 18;
            this.delate_btn.Text = "ลบข้อมูล";
            this.delate_btn.UseVisualStyleBackColor = true;
            this.delate_btn.Click += new System.EventHandler(this.delate_btn_Click);
            // 
            // contact_textbox
            // 
            this.contact_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.contact_textbox.Location = new System.Drawing.Point(375, 156);
            this.contact_textbox.Name = "contact_textbox";
            this.contact_textbox.Size = new System.Drawing.Size(190, 26);
            this.contact_textbox.TabIndex = 20;
            // 
            // Address_leble
            // 
            this.Address_leble.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Address_leble.Location = new System.Drawing.Point(143, 155);
            this.Address_leble.Name = "Address_leble";
            this.Address_leble.Size = new System.Drawing.Size(190, 26);
            this.Address_leble.TabIndex = 19;
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_textbox.Location = new System.Drawing.Point(143, 100);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(190, 26);
            this.name_textbox.TabIndex = 17;
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(174, 213);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(132, 40);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "ยืนยันข้อมูล";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // did_textbox
            // 
            this.did_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.did_textbox.Location = new System.Drawing.Point(143, 39);
            this.did_textbox.Name = "did_textbox";
            this.did_textbox.Size = new System.Drawing.Size(190, 26);
            this.did_textbox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(370, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Type Dormitory";
            // 
            // lablee
            // 
            this.lablee.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lablee.AutoSize = true;
            this.lablee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lablee.Location = new System.Drawing.Point(370, 118);
            this.lablee.Name = "lablee";
            this.lablee.Size = new System.Drawing.Size(80, 25);
            this.lablee.TabIndex = 6;
            this.lablee.Text = "Contact";
            // 
            // address
            // 
            this.address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.address.AutoSize = true;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(36, 156);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(85, 25);
            this.address.TabIndex = 4;
            this.address.Text = "Address";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dormiory ID";
            // 
            // typedorm_dataGridVie
            // 
            this.typedorm_dataGridVie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.typedorm_dataGridVie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.typedorm_dataGridVie.Location = new System.Drawing.Point(616, 308);
            this.typedorm_dataGridVie.Name = "typedorm_dataGridVie";
            this.typedorm_dataGridVie.RowHeadersWidth = 62;
            this.typedorm_dataGridVie.RowTemplate.Height = 28;
            this.typedorm_dataGridVie.Size = new System.Drawing.Size(547, 308);
            this.typedorm_dataGridVie.TabIndex = 18;
            this.typedorm_dataGridVie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typedorm_dataGridVie_CellClick);
            this.typedorm_dataGridVie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.typedorm_dataGridVie_CellContentClick);
            // 
            // FormDormitory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 629);
            this.Controls.Add(this.typedorm_dataGridVie);
            this.Controls.Add(this.dorm_dataGridView);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FormDormitory";
            this.Text = "FormDormitory";
            this.Load += new System.EventHandler(this.FormDormitory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dorm_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typedorm_dataGridVie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dorm_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Typedromname;
        private System.Windows.Forms.TextBox Typedrom;
        private System.Windows.Forms.Label bb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert1_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button delate2_btn;
        private System.Windows.Forms.Button update2_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.ComboBox TypeDormitory_comboBox;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.TextBox contact_textbox;
        private System.Windows.Forms.TextBox Address_leble;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox did_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lablee;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox description_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView typedorm_dataGridVie;
        private System.Windows.Forms.TextBox capacity_textbox;
    }
}