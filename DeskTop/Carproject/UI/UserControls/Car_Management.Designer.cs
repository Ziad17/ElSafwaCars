namespace Carproject.UI.UserControls
{
    partial class Car_Management
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.car_location = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.motor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.shaseh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mark = new System.Windows.Forms.TextBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.car_model = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.model = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.car_location);
            this.groupBox1.Controls.Add(this.from);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.motor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.shaseh);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.mark);
            this.groupBox1.Controls.Add(this.price);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.car_model);
            this.groupBox1.Controls.Add(this.notes);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.model);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(43, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1025, 371);
            this.groupBox1.TabIndex = 127;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "السيارات";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(274, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 27);
            this.label6.TabIndex = 158;
            this.label6.Text = "مكان السيارة";
            // 
            // car_location
            // 
            this.car_location.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.car_location.BackColor = System.Drawing.SystemColors.Window;
            this.car_location.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.car_location.Location = new System.Drawing.Point(103, 133);
            this.car_location.Name = "car_location";
            this.car_location.Size = new System.Drawing.Size(165, 38);
            this.car_location.TabIndex = 159;
            this.car_location.TabStop = false;
            this.car_location.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.car_location.KeyDown += new System.Windows.Forms.KeyEventHandler(this.car_location_KeyDown);
            // 
            // from
            // 
            this.from.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.from.CalendarFont = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.from.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.Location = new System.Drawing.Point(103, 210);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(165, 35);
            this.from.TabIndex = 157;
            this.from.TabStop = false;
            this.from.KeyDown += new System.Windows.Forms.KeyEventHandler(this.from_KeyDown);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(274, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 27);
            this.label5.TabIndex = 156;
            this.label5.Text = "تاريخ الاضافة";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(910, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 132;
            this.label4.Text = "رقم الموتور";
            // 
            // motor
            // 
            this.motor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.motor.BackColor = System.Drawing.SystemColors.Window;
            this.motor.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.motor.Location = new System.Drawing.Point(739, 131);
            this.motor.Name = "motor";
            this.motor.Size = new System.Drawing.Size(165, 38);
            this.motor.TabIndex = 133;
            this.motor.TabStop = false;
            this.motor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.motor.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.motor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.motor_KeyDown);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(274, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 27);
            this.label3.TabIndex = 130;
            this.label3.Text = "رقم الشاسيه";
            // 
            // shaseh
            // 
            this.shaseh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shaseh.BackColor = System.Drawing.SystemColors.Window;
            this.shaseh.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.shaseh.Location = new System.Drawing.Point(103, 57);
            this.shaseh.Name = "shaseh";
            this.shaseh.Size = new System.Drawing.Size(165, 38);
            this.shaseh.TabIndex = 131;
            this.shaseh.TabStop = false;
            this.shaseh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.shaseh.TextChanged += new System.EventHandler(this.shaseh_TextChanged);
            this.shaseh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.shaseh_KeyDown);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(597, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 27);
            this.label2.TabIndex = 128;
            this.label2.Text = "الماركة";
            // 
            // mark
            // 
            this.mark.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mark.BackColor = System.Drawing.SystemColors.Window;
            this.mark.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mark.Location = new System.Drawing.Point(421, 133);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(165, 38);
            this.mark.TabIndex = 129;
            this.mark.TabStop = false;
            this.mark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mark.TextChanged += new System.EventHandler(this.mark_TextChanged);
            this.mark.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mark_KeyDown);
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.BackColor = System.Drawing.SystemColors.Window;
            this.price.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.price.Location = new System.Drawing.Point(739, 209);
            this.price.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(165, 38);
            this.price.TabIndex = 127;
            this.price.TabStop = false;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.price.ThousandsSeparator = true;
            this.price.ValueChanged += new System.EventHandler(this.price_ValueChanged);
            this.price.KeyDown += new System.Windows.Forms.KeyEventHandler(this.price_KeyDown);
            this.price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.price_MouseClick);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(371, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 47);
            this.button3.TabIndex = 126;
            this.button3.TabStop = false;
            this.button3.Text = "عرض السيارات";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(557, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 47);
            this.button2.TabIndex = 124;
            this.button2.TabStop = false;
            this.button2.Text = "أضافة سيارة";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Default;
            this.label9.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(910, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 27);
            this.label9.TabIndex = 112;
            this.label9.Text = "رقم السيارة";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Cursor = System.Windows.Forms.Cursors.Default;
            this.label12.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(595, 214);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 27);
            this.label12.TabIndex = 114;
            this.label12.Text = "ملاحظات";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // car_model
            // 
            this.car_model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.car_model.AutoSize = true;
            this.car_model.Cursor = System.Windows.Forms.Cursors.Default;
            this.car_model.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.car_model.Location = new System.Drawing.Point(592, 62);
            this.car_model.Name = "car_model";
            this.car_model.Size = new System.Drawing.Size(53, 27);
            this.car_model.TabIndex = 113;
            this.car_model.Text = "الموديل";
            // 
            // notes
            // 
            this.notes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.notes.BackColor = System.Drawing.SystemColors.Window;
            this.notes.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.notes.Location = new System.Drawing.Point(421, 209);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(165, 38);
            this.notes.TabIndex = 117;
            this.notes.TabStop = false;
            this.notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.notes.TextChanged += new System.EventHandler(this.notes_TextChanged);
            this.notes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notes_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(913, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 27);
            this.label1.TabIndex = 113;
            this.label1.Text = "مبلغ الشراء";
            // 
            // model
            // 
            this.model.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.model.BackColor = System.Drawing.SystemColors.Window;
            this.model.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.model.Location = new System.Drawing.Point(421, 58);
            this.model.Name = "model";
            this.model.Size = new System.Drawing.Size(165, 38);
            this.model.TabIndex = 116;
            this.model.TabStop = false;
            this.model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.model.TextChanged += new System.EventHandler(this.model_TextChanged);
            this.model.KeyDown += new System.Windows.Forms.KeyEventHandler(this.model_KeyDown);
            // 
            // number
            // 
            this.number.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.number.AutoCompleteCustomSource.AddRange(new string[] {
            "محمد ",
            "زياد ",
            "زوز"});
            this.number.BackColor = System.Drawing.SystemColors.Window;
            this.number.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.number.Location = new System.Drawing.Point(739, 59);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(165, 38);
            this.number.TabIndex = 115;
            this.number.TabStop = false;
            this.number.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.number.TextChanged += new System.EventHandler(this.number_TextChanged);
            this.number.KeyDown += new System.Windows.Forms.KeyEventHandler(this.number_KeyDown);
            // 
            // Car_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "Car_Management";
            this.Size = new System.Drawing.Size(1100, 525);
            this.Load += new System.EventHandler(this.Car_Management_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label car_model;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.TextBox model;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox motor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox shaseh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mark;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox car_location;
    }
}
