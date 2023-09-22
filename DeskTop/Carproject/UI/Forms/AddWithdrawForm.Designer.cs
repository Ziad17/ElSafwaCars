namespace Carproject.UI.Forms
{
    partial class AddWithdrawForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddWithdrawForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.total = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.first_pay_bill = new System.Windows.Forms.DateTimePicker();
            this.notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.give_radio = new System.Windows.Forms.RadioButton();
            this.take_radio = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.total);
            this.groupBox1.Controls.Add(this.id);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(55, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(618, 117);
            this.groupBox1.TabIndex = 153;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "معلومات المساهمة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.SystemColors.Window;
            this.total.Location = new System.Drawing.Point(24, 42);
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.total.Size = new System.Drawing.Size(106, 32);
            this.total.TabIndex = 149;
            this.total.TabStop = false;
            this.total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.total.TextChanged += new System.EventHandler(this.total_TextChanged);
            // 
            // id
            // 
            this.id.BackColor = System.Drawing.SystemColors.Window;
            this.id.Location = new System.Drawing.Point(237, 42);
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.id.Size = new System.Drawing.Size(86, 32);
            this.id.TabIndex = 148;
            this.id.TabStop = false;
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.TextChanged += new System.EventHandler(this.id_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.Location = new System.Drawing.Point(136, 47);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 21);
            this.label11.TabIndex = 146;
            this.label11.Text = "مبلغ المساهمة";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(324, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 21);
            this.label12.TabIndex = 145;
            this.label12.Text = "رقم المساهمة";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.SystemColors.Window;
            this.name.Location = new System.Drawing.Point(406, 42);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.name.Size = new System.Drawing.Size(120, 32);
            this.name.TabIndex = 143;
            this.name.TabStop = false;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(532, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 21);
            this.label14.TabIndex = 142;
            this.label14.Text = "أسم المساهم";
            // 
            // first_pay_bill
            // 
            this.first_pay_bill.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.first_pay_bill.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_pay_bill.Location = new System.Drawing.Point(24, 31);
            this.first_pay_bill.Name = "first_pay_bill";
            this.first_pay_bill.Size = new System.Drawing.Size(191, 32);
            this.first_pay_bill.TabIndex = 156;
            this.first_pay_bill.TabStop = false;
            this.first_pay_bill.ValueChanged += new System.EventHandler(this.first_pay_bill_ValueChanged);
            // 
            // notes
            // 
            this.notes.BackColor = System.Drawing.SystemColors.Window;
            this.notes.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes.Location = new System.Drawing.Point(24, 84);
            this.notes.Name = "notes";
            this.notes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.notes.Size = new System.Drawing.Size(191, 32);
            this.notes.TabIndex = 155;
            this.notes.TabStop = false;
            this.notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(221, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 24);
            this.label8.TabIndex = 154;
            this.label8.Text = "ملاحظات";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.Window;
            this.price.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(386, 31);
            this.price.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.price.Size = new System.Drawing.Size(128, 32);
            this.price.TabIndex = 153;
            this.price.TabStop = false;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.ThousandsSeparator = true;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged);
            this.price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.price_MouseClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 24);
            this.label9.TabIndex = 152;
            this.label9.Text = "مبلغ العملية";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(221, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 24);
            this.label10.TabIndex = 150;
            this.label10.Text = "تاريخ تسجيل العملية";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button4.Location = new System.Drawing.Point(168, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 47);
            this.button4.TabIndex = 141;
            this.button4.TabStop = false;
            this.button4.Text = "رجوع";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(337, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 47);
            this.button2.TabIndex = 140;
            this.button2.TabStop = false;
            this.button2.Text = "تأكيد";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(147, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 150;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(721, 16);
            this.panel1.TabIndex = 149;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.first_pay_bill);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.notes);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.price);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(55, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(618, 184);
            this.groupBox2.TabIndex = 157;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تحديد العملية";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.give_radio);
            this.groupBox5.Controls.Add(this.take_radio);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox5.Location = new System.Drawing.Point(386, 69);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(203, 56);
            this.groupBox5.TabIndex = 157;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "نوع العملية";
            // 
            // give_radio
            // 
            this.give_radio.AutoSize = true;
            this.give_radio.Font = new System.Drawing.Font("Arabic Typesetting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.give_radio.Location = new System.Drawing.Point(34, 20);
            this.give_radio.Name = "give_radio";
            this.give_radio.Size = new System.Drawing.Size(58, 27);
            this.give_radio.TabIndex = 123;
            this.give_radio.Text = "أضافة";
            this.give_radio.UseVisualStyleBackColor = true;
            this.give_radio.CheckedChanged += new System.EventHandler(this.name_radio_CheckedChanged);
            // 
            // take_radio
            // 
            this.take_radio.AutoSize = true;
            this.take_radio.Font = new System.Drawing.Font("Arabic Typesetting", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.take_radio.Location = new System.Drawing.Point(124, 20);
            this.take_radio.Name = "take_radio";
            this.take_radio.Size = new System.Drawing.Size(54, 27);
            this.take_radio.TabIndex = 125;
            this.take_radio.Text = "سحب";
            this.take_radio.UseVisualStyleBackColor = true;
            this.take_radio.CheckedChanged += new System.EventHandler(this.take_radio_CheckedChanged);
            // 
            // add_withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 446);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "add_withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "أضافة سحب";
            this.Load += new System.EventHandler(this.add_withdraw_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker first_pay_bill;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton give_radio;
        private System.Windows.Forms.RadioButton take_radio;
    }
}