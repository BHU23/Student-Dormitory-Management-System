namespace dormitory.Forms
{
    partial class FormCounselor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCounselor));
            this.update_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.delate_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.did_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Contact_textbox = new System.Windows.Forms.TextBox();
            this.telephone_textbox = new System.Windows.Forms.TextBox();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.CounselorID_textbox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cintact = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.conselor_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conselor_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Location = new System.Drawing.Point(966, 395);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(164, 55);
            this.update_btn.TabIndex = 21;
            this.update_btn.Text = "ยืนยันข้อมูล";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.insert_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insert_btn.Location = new System.Drawing.Point(966, 320);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(164, 55);
            this.insert_btn.TabIndex = 20;
            this.insert_btn.Text = "เพิ่มข้อมูลที่ปรึกษา";
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
            this.delate_btn.Text = "ลบข้อมูลที่ปรึกษา";
            this.delate_btn.UseVisualStyleBackColor = true;
            this.delate_btn.Click += new System.EventHandler(this.delate_btn_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Wheat;
            this.panel1.Controls.Add(this.did_textbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Contact_textbox);
            this.panel1.Controls.Add(this.telephone_textbox);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.CounselorID_textbox);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cintact);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(11, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 277);
            this.panel1.TabIndex = 16;
            // 
            // did_textbox
            // 
            this.did_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.did_textbox.Location = new System.Drawing.Point(314, 173);
            this.did_textbox.Name = "did_textbox";
            this.did_textbox.Size = new System.Drawing.Size(223, 26);
            this.did_textbox.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Dormiory ID";
            // 
            // Contact_textbox
            // 
            this.Contact_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Contact_textbox.Location = new System.Drawing.Point(754, 93);
            this.Contact_textbox.Name = "Contact_textbox";
            this.Contact_textbox.Size = new System.Drawing.Size(223, 26);
            this.Contact_textbox.TabIndex = 38;
            // 
            // telephone_textbox
            // 
            this.telephone_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.telephone_textbox.Location = new System.Drawing.Point(754, 154);
            this.telephone_textbox.Name = "telephone_textbox";
            this.telephone_textbox.Size = new System.Drawing.Size(223, 26);
            this.telephone_textbox.TabIndex = 37;
            // 
            // name_textbox
            // 
            this.name_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.name_textbox.Location = new System.Drawing.Point(314, 113);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(223, 26);
            this.name_textbox.TabIndex = 36;
            // 
            // CounselorID_textbox
            // 
            this.CounselorID_textbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CounselorID_textbox.Location = new System.Drawing.Point(314, 50);
            this.CounselorID_textbox.Name = "CounselorID_textbox";
            this.CounselorID_textbox.Size = new System.Drawing.Size(223, 26);
            this.CounselorID_textbox.TabIndex = 35;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(590, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(143, 25);
            this.label14.TabIndex = 34;
            this.label14.Text = "Phone Number";
            // 
            // cintact
            // 
            this.cintact.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cintact.AutoSize = true;
            this.cintact.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cintact.Location = new System.Drawing.Point(653, 92);
            this.cintact.Name = "cintact";
            this.cintact.Size = new System.Drawing.Size(80, 25);
            this.cintact.TabIndex = 33;
            this.cintact.Text = "Contact";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(215, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Counselor ID";
            // 
            // conselor_dataGridView
            // 
            this.conselor_dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.conselor_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.conselor_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.conselor_dataGridView.Location = new System.Drawing.Point(11, 308);
            this.conselor_dataGridView.Name = "conselor_dataGridView";
            this.conselor_dataGridView.RowHeadersWidth = 62;
            this.conselor_dataGridView.RowTemplate.Height = 28;
            this.conselor_dataGridView.Size = new System.Drawing.Size(923, 308);
            this.conselor_dataGridView.TabIndex = 17;
            this.conselor_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.conselor_dataGridView_CellClick);
            // 
            // FormCounselor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1175, 629);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.delate_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.conselor_dataGridView);
            this.DoubleBuffered = true;
            this.Name = "FormCounselor";
            this.Text = "FormCounselor";
            this.Load += new System.EventHandler(this.FormCounselor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.conselor_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button delate_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView conselor_dataGridView;
        private System.Windows.Forms.TextBox Contact_textbox;
        private System.Windows.Forms.TextBox telephone_textbox;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.TextBox CounselorID_textbox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label cintact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox did_textbox;
        private System.Windows.Forms.Label label1;
    }
}