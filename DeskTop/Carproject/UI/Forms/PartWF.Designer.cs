namespace Carproject.UI.Forms
{
    partial class PartWF
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartWF));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.id_contr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.contr_duration = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contr_total_price = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.contr_first_pay_date = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.contr_notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contr_phone = new System.Windows.Forms.TextBox();
            this.contr_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_contr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contr_total_price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(246, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 16);
            this.panel1.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.id_contr);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.contr_duration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.contr_total_price);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.contr_first_pay_date);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.contr_notes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.contr_phone);
            this.groupBox1.Controls.Add(this.contr_name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(44, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(787, 324);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "أضافة مساهمة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dateTimePicker1.Location = new System.Drawing.Point(128, 31);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 35);
            this.dateTimePicker1.TabIndex = 133;
            this.dateTimePicker1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(288, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 27);
            this.label5.TabIndex = 132;
            this.label5.Text = "تاريخ الانشاء";
            // 
            // id_contr
            // 
            this.id_contr.BackColor = System.Drawing.SystemColors.Window;
            this.id_contr.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.id_contr.Location = new System.Drawing.Point(538, 35);
            this.id_contr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.id_contr.Name = "id_contr";
            this.id_contr.Size = new System.Drawing.Size(154, 35);
            this.id_contr.TabIndex = 131;
            this.id_contr.TabStop = false;
            this.id_contr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_contr.ThousandsSeparator = true;
            this.id_contr.ValueChanged += new System.EventHandler(this.id_contr_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(701, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 27);
            this.label4.TabIndex = 130;
            this.label4.Text = "رقم المساهمة";
            // 
            // contr_duration
            // 
            this.contr_duration.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_duration.FormattingEnabled = true;
            this.contr_duration.Items.AddRange(new object[] {
            "شهريا",
            "أسبوعيا"});
            this.contr_duration.Location = new System.Drawing.Point(128, 131);
            this.contr_duration.Name = "contr_duration";
            this.contr_duration.Size = new System.Drawing.Size(154, 35);
            this.contr_duration.TabIndex = 129;
            this.contr_duration.TabStop = false;
            this.contr_duration.SelectedIndexChanged += new System.EventHandler(this.contr_duration_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(288, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 27);
            this.label3.TabIndex = 128;
            this.label3.Text = "فترة التنبيه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // contr_total_price
            // 
            this.contr_total_price.BackColor = System.Drawing.SystemColors.Window;
            this.contr_total_price.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_total_price.Location = new System.Drawing.Point(538, 182);
            this.contr_total_price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.contr_total_price.Name = "contr_total_price";
            this.contr_total_price.Size = new System.Drawing.Size(154, 35);
            this.contr_total_price.TabIndex = 127;
            this.contr_total_price.TabStop = false;
            this.contr_total_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.contr_total_price.ThousandsSeparator = true;
            this.contr_total_price.ValueChanged += new System.EventHandler(this.contr_total_price_ValueChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(240, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 36);
            this.button3.TabIndex = 126;
            this.button3.TabStop = false;
            this.button3.Text = "حذف المعلومات";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(438, 255);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 36);
            this.button2.TabIndex = 124;
            this.button2.TabStop = false;
            this.button2.Text = "أضافة مساهمة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(698, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 27);
            this.label9.TabIndex = 112;
            this.label9.Text = "الأسم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // contr_first_pay_date
            // 
            this.contr_first_pay_date.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.contr_first_pay_date.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_first_pay_date.Location = new System.Drawing.Point(128, 83);
            this.contr_first_pay_date.Name = "contr_first_pay_date";
            this.contr_first_pay_date.Size = new System.Drawing.Size(154, 35);
            this.contr_first_pay_date.TabIndex = 123;
            this.contr_first_pay_date.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(288, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 27);
            this.label12.TabIndex = 114;
            this.label12.Text = "ملاحظات";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Cursor = System.Windows.Forms.Cursors.Default;
            this.label10.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label10.Location = new System.Drawing.Point(698, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 27);
            this.label10.TabIndex = 113;
            this.label10.Text = "الهاتف";
            // 
            // contr_notes
            // 
            this.contr_notes.BackColor = System.Drawing.SystemColors.Window;
            this.contr_notes.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_notes.Location = new System.Drawing.Point(128, 181);
            this.contr_notes.Name = "contr_notes";
            this.contr_notes.Size = new System.Drawing.Size(154, 35);
            this.contr_notes.TabIndex = 117;
            this.contr_notes.TabStop = false;
            this.contr_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.contr_notes.TextChanged += new System.EventHandler(this.contr_notes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(701, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 27);
            this.label1.TabIndex = 113;
            this.label1.Text = "المبلغ";
            // 
            // contr_phone
            // 
            this.contr_phone.BackColor = System.Drawing.SystemColors.Window;
            this.contr_phone.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_phone.Location = new System.Drawing.Point(538, 134);
            this.contr_phone.Name = "contr_phone";
            this.contr_phone.Size = new System.Drawing.Size(154, 35);
            this.contr_phone.TabIndex = 116;
            this.contr_phone.TabStop = false;
            this.contr_phone.TextChanged += new System.EventHandler(this.contr_phone_TextChanged);
            // 
            // contr_name
            // 
            this.contr_name.AutoCompleteCustomSource.AddRange(new string[] {
            "محمد ",
            "زياد ",
            "زوز"});
            this.contr_name.BackColor = System.Drawing.SystemColors.Window;
            this.contr_name.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_name.Location = new System.Drawing.Point(538, 83);
            this.contr_name.Name = "contr_name";
            this.contr_name.Size = new System.Drawing.Size(154, 35);
            this.contr_name.TabIndex = 115;
            this.contr_name.TabStop = false;
            this.contr_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.contr_name.TextChanged += new System.EventHandler(this.contr_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(288, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 114;
            this.label2.Text = "تاريخ أول تنبيه";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // PartWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PartWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "أضافة مساهمة";
            this.Load += new System.EventHandler(this.PartWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_contr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contr_total_price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox contr_duration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown contr_total_price;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker contr_first_pay_date;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox contr_notes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox contr_phone;
        private System.Windows.Forms.TextBox contr_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NumericUpDown id_contr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
    }
}