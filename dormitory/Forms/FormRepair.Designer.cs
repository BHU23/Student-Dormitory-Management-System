namespace dormitory.Forms
{
    partial class FormRepair
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRepair));
            this.insert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.Repair_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dores_datepicker = new System.Windows.Forms.DateTimePicker();
            this.dosre_datepicker = new System.Windows.Forms.DateTimePicker();
            this.Contactid_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.TextBox();
            this.Subject_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.no_radioButton = new System.Windows.Forms.RadioButton();
            this.yes_radioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Description_textbox = new System.Windows.Forms.TextBox();
            this.repid_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Repair_dataGridView)).BeginInit();
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
            this.insert_btn.Text = "เพิ่มรายการแจ้งซ่อม";
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
            // Repair_dataGridView
            // 
            this.Repair_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Repair_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Repair_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.Repair_dataGridView.Name = "Repair_dataGridView";
            this.Repair_dataGridView.RowHeadersWidth = 62;
            this.Repair_dataGridView.RowTemplate.Height = 28;
            this.Repair_dataGridView.Size = new System.Drawing.Size(923, 308);
            this.Repair_dataGridView.TabIndex = 17;
            this.Repair_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Repair_dataGridView_CellClick);
            this.Repair_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Repair_dataGridView_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.dores_datepicker);
            this.panel1.Controls.Add(this.dosre_datepicker);
            this.panel1.Controls.Add(this.Contactid_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sub);
            this.panel1.Controls.Add(this.Subject_label);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.no_radioButton);
            this.panel1.Controls.Add(this.yes_radioButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Description_textbox);
            this.panel1.Controls.Add(this.repid_textbox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 277);
            this.panel1.TabIndex = 16;
            // 
            // dores_datepicker
            // 
            this.dores_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dores_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dores_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dores_datepicker.Location = new System.Drawing.Point(462, 214);
            this.dores_datepicker.Name = "dores_datepicker";
            this.dores_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dores_datepicker.TabIndex = 43;
            // 
            // dosre_datepicker
            // 
            this.dosre_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dosre_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dosre_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dosre_datepicker.Location = new System.Drawing.Point(462, 100);
            this.dosre_datepicker.Name = "dosre_datepicker";
            this.dosre_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dosre_datepicker.TabIndex = 42;
            // 
            // Contactid_textbox
            // 
            this.Contactid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contactid_textbox.Location = new System.Drawing.Point(162, 136);
            this.Contactid_textbox.Name = "Contactid_textbox";
            this.Contactid_textbox.Size = new System.Drawing.Size(223, 26);
            this.Contactid_textbox.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Contact ID";
            // 
            // sub
            // 
            this.sub.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sub.Location = new System.Drawing.Point(158, 197);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(223, 26);
            this.sub.TabIndex = 39;
            // 
            // Subject_label
            // 
            this.Subject_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Subject_label.AutoSize = true;
            this.Subject_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject_label.Location = new System.Drawing.Point(65, 196);
            this.Subject_label.Name = "Subject_label";
            this.Subject_label.Size = new System.Drawing.Size(78, 25);
            this.Subject_label.TabIndex = 38;
            this.Subject_label.Text = "Subject";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "Date of request";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(424, 164);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 34;
            this.label8.Text = "Date of Reserve";
            // 
            // no_radioButton
            // 
            this.no_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.no_radioButton.AutoSize = true;
            this.no_radioButton.Location = new System.Drawing.Point(998, 155);
            this.no_radioButton.Name = "no_radioButton";
            this.no_radioButton.Size = new System.Drawing.Size(54, 24);
            this.no_radioButton.TabIndex = 31;
            this.no_radioButton.TabStop = true;
            this.no_radioButton.Text = "No";
            this.no_radioButton.UseVisualStyleBackColor = true;
            // 
            // yes_radioButton
            // 
            this.yes_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yes_radioButton.AutoSize = true;
            this.yes_radioButton.Location = new System.Drawing.Point(911, 154);
            this.yes_radioButton.Name = "yes_radioButton";
            this.yes_radioButton.Size = new System.Drawing.Size(62, 24);
            this.yes_radioButton.TabIndex = 30;
            this.yes_radioButton.TabStop = true;
            this.yes_radioButton.Text = "Yes";
            this.yes_radioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(823, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Status";
            // 
            // Description_textbox
            // 
            this.Description_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Description_textbox.Location = new System.Drawing.Point(911, 74);
            this.Description_textbox.Name = "Description_textbox";
            this.Description_textbox.Size = new System.Drawing.Size(223, 26);
            this.Description_textbox.TabIndex = 19;
            // 
            // repid_textbox
            // 
            this.repid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.repid_textbox.Location = new System.Drawing.Point(158, 73);
            this.repid_textbox.Name = "repid_textbox";
            this.repid_textbox.Size = new System.Drawing.Size(223, 26);
            this.repid_textbox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(782, 73);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Description";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Repair ID";
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
            // FormRepair
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
            this.Controls.Add(this.Repair_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.DoubleBuffered = true;
            this.Name = "FormRepair";
            this.Text = "FormRepair";
            this.Load += new System.EventHandler(this.FormRepair_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Repair_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.DataGridView Repair_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Description_textbox;
        private System.Windows.Forms.TextBox repid_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.RadioButton no_radioButton;
        private System.Windows.Forms.RadioButton yes_radioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sub;
        private System.Windows.Forms.Label Subject_label;
        private System.Windows.Forms.TextBox Contactid_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dores_datepicker;
        private System.Windows.Forms.DateTimePicker dosre_datepicker;
    }
}