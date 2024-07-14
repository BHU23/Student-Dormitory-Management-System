namespace dormitory.Forms
{
    partial class FormPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPayment));
            this.no_radioButton = new System.Windows.Forms.RadioButton();
            this.yes_radioButton = new System.Windows.Forms.RadioButton();
            this.medthod_textbox = new System.Windows.Forms.TextBox();
            this.amount_textbox = new System.Windows.Forms.TextBox();
            this.pid_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.insert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.payment_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dor_datepicker = new System.Windows.Forms.DateTimePicker();
            this.Contactid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.update_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.payment_dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // no_radioButton
            // 
            this.no_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.no_radioButton.AutoSize = true;
            this.no_radioButton.Location = new System.Drawing.Point(780, 186);
            this.no_radioButton.Name = "no_radioButton";
            this.no_radioButton.Size = new System.Drawing.Size(54, 24);
            this.no_radioButton.TabIndex = 21;
            this.no_radioButton.TabStop = true;
            this.no_radioButton.Text = "No";
            this.no_radioButton.UseVisualStyleBackColor = true;
            // 
            // yes_radioButton
            // 
            this.yes_radioButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.yes_radioButton.AutoSize = true;
            this.yes_radioButton.Location = new System.Drawing.Point(693, 185);
            this.yes_radioButton.Name = "yes_radioButton";
            this.yes_radioButton.Size = new System.Drawing.Size(62, 24);
            this.yes_radioButton.TabIndex = 20;
            this.yes_radioButton.TabStop = true;
            this.yes_radioButton.Text = "Yes";
            this.yes_radioButton.UseVisualStyleBackColor = true;
            // 
            // medthod_textbox
            // 
            this.medthod_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.medthod_textbox.Location = new System.Drawing.Point(693, 71);
            this.medthod_textbox.Name = "medthod_textbox";
            this.medthod_textbox.Size = new System.Drawing.Size(223, 26);
            this.medthod_textbox.TabIndex = 19;
            // 
            // amount_textbox
            // 
            this.amount_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.amount_textbox.Location = new System.Drawing.Point(284, 186);
            this.amount_textbox.Name = "amount_textbox";
            this.amount_textbox.Size = new System.Drawing.Size(223, 26);
            this.amount_textbox.TabIndex = 17;
            // 
            // pid_textbox
            // 
            this.pid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pid_textbox.Location = new System.Drawing.Point(286, 69);
            this.pid_textbox.Name = "pid_textbox";
            this.pid_textbox.Size = new System.Drawing.Size(223, 26);
            this.pid_textbox.TabIndex = 16;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(582, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "Method";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(587, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(604, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Date";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(189, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(165, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Payment ID";
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(966, 320);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(164, 55);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "เพิ่มรายการจ่ายเงิน";
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
            // payment_dataGridView
            // 
            this.payment_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.payment_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.payment_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.payment_dataGridView.Name = "payment_dataGridView";
            this.payment_dataGridView.RowHeadersWidth = 62;
            this.payment_dataGridView.RowTemplate.Height = 28;
            this.payment_dataGridView.Size = new System.Drawing.Size(923, 308);
            this.payment_dataGridView.TabIndex = 17;
            this.payment_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_dataGridView_CellClick);
            this.payment_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.payment_dataGridView_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.dor_datepicker);
            this.panel1.Controls.Add(this.Contactid_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.no_radioButton);
            this.panel1.Controls.Add(this.yes_radioButton);
            this.panel1.Controls.Add(this.medthod_textbox);
            this.panel1.Controls.Add(this.amount_textbox);
            this.panel1.Controls.Add(this.pid_textbox);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 277);
            this.panel1.TabIndex = 16;
            // 
            // dor_datepicker
            // 
            this.dor_datepicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dor_datepicker.CustomFormat = "yyyy-MM-dd";
            this.dor_datepicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dor_datepicker.Location = new System.Drawing.Point(693, 126);
            this.dor_datepicker.Name = "dor_datepicker";
            this.dor_datepicker.Size = new System.Drawing.Size(223, 26);
            this.dor_datepicker.TabIndex = 43;
            // 
            // Contactid_textbox
            // 
            this.Contactid_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contactid_textbox.Location = new System.Drawing.Point(284, 125);
            this.Contactid_textbox.Name = "Contactid_textbox";
            this.Contactid_textbox.Size = new System.Drawing.Size(223, 26);
            this.Contactid_textbox.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Contact ID";
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
            // FormPayment
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
            this.Controls.Add(this.payment_dataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.update_btn);
            this.DoubleBuffered = true;
            this.Name = "FormPayment";
            this.Text = "FormPayment";
            this.Load += new System.EventHandler(this.FormPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payment_dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton no_radioButton;
        private System.Windows.Forms.RadioButton yes_radioButton;
        private System.Windows.Forms.TextBox medthod_textbox;
        private System.Windows.Forms.TextBox amount_textbox;
        private System.Windows.Forms.TextBox pid_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.DataGridView payment_dataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox Contactid_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dor_datepicker;
    }
}