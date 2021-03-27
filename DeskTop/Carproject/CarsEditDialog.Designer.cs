namespace Carproject
{
    partial class CarsEditDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarsEditDialog));
            this.clear_all_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.unregister = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.from = new System.Windows.Forms.DateTimePicker();
            this.shaseh_num1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.model_num1 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.mark_car1 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.motor_num1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.car_num1 = new System.Windows.Forms.TextBox();
            this.paid_price1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.unregister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_price1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // clear_all_button
            // 
            this.clear_all_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.clear_all_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_all_button.FlatAppearance.BorderSize = 0;
            this.clear_all_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_all_button.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.clear_all_button.Location = new System.Drawing.Point(288, 454);
            this.clear_all_button.Name = "clear_all_button";
            this.clear_all_button.Size = new System.Drawing.Size(97, 48);
            this.clear_all_button.TabIndex = 124;
            this.clear_all_button.TabStop = false;
            this.clear_all_button.Text = "تعديل وحفظ";
            this.clear_all_button.UseVisualStyleBackColor = false;
            this.clear_all_button.Click += new System.EventHandler(this.clear_all_button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(30, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 48);
            this.button1.TabIndex = 125;
            this.button1.TabStop = false;
            this.button1.Text = "مسح السيارة";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.unregister);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(355, 358);
            this.groupBox1.TabIndex = 126;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تفاصيل السيارة";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // unregister
            // 
            this.unregister.ColumnCount = 2;
            this.unregister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.unregister.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.unregister.Controls.Add(this.label2, 0, 7);
            this.unregister.Controls.Add(this.textBox1, 1, 7);
            this.unregister.Controls.Add(this.from, 1, 6);
            this.unregister.Controls.Add(this.shaseh_num1, 1, 4);
            this.unregister.Controls.Add(this.label5, 0, 6);
            this.unregister.Controls.Add(this.label19, 0, 4);
            this.unregister.Controls.Add(this.model_num1, 1, 3);
            this.unregister.Controls.Add(this.label21, 0, 3);
            this.unregister.Controls.Add(this.mark_car1, 1, 2);
            this.unregister.Controls.Add(this.label25, 0, 2);
            this.unregister.Controls.Add(this.motor_num1, 1, 1);
            this.unregister.Controls.Add(this.label18, 0, 1);
            this.unregister.Controls.Add(this.label17, 0, 0);
            this.unregister.Controls.Add(this.car_num1, 1, 0);
            this.unregister.Controls.Add(this.paid_price1, 1, 5);
            this.unregister.Controls.Add(this.label1, 0, 5);
            this.unregister.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unregister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(3)))));
            this.unregister.Location = new System.Drawing.Point(44, 31);
            this.unregister.Name = "unregister";
            this.unregister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.unregister.RowCount = 8;
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.unregister.Size = new System.Drawing.Size(273, 321);
            this.unregister.TabIndex = 131;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 133;
            this.label2.Text = "مكان السيارة";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(7, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 32);
            this.textBox1.TabIndex = 132;
            this.textBox1.TabStop = false;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // from
            // 
            this.from.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.from.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.from.Location = new System.Drawing.Point(7, 243);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(154, 32);
            this.from.TabIndex = 159;
            this.from.TabStop = false;
            // 
            // shaseh_num1
            // 
            this.shaseh_num1.BackColor = System.Drawing.SystemColors.Window;
            this.shaseh_num1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shaseh_num1.Location = new System.Drawing.Point(7, 163);
            this.shaseh_num1.Name = "shaseh_num1";
            this.shaseh_num1.Size = new System.Drawing.Size(154, 32);
            this.shaseh_num1.TabIndex = 11;
            this.shaseh_num1.TabStop = false;
            this.shaseh_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.label5.Location = new System.Drawing.Point(198, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 24);
            this.label5.TabIndex = 158;
            this.label5.Text = "تاريخ الاضافة";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(203, 160);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 21);
            this.label19.TabIndex = 10;
            this.label19.Text = "رقم الشاسيه";
            // 
            // model_num1
            // 
            this.model_num1.BackColor = System.Drawing.SystemColors.Window;
            this.model_num1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_num1.Location = new System.Drawing.Point(7, 123);
            this.model_num1.Name = "model_num1";
            this.model_num1.Size = new System.Drawing.Size(154, 32);
            this.model_num1.TabIndex = 10;
            this.model_num1.TabStop = false;
            this.model_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(226, 120);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 21);
            this.label21.TabIndex = 12;
            this.label21.Text = "الموديل";
            // 
            // mark_car1
            // 
            this.mark_car1.BackColor = System.Drawing.SystemColors.Window;
            this.mark_car1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark_car1.Location = new System.Drawing.Point(7, 83);
            this.mark_car1.Name = "mark_car1";
            this.mark_car1.Size = new System.Drawing.Size(154, 32);
            this.mark_car1.TabIndex = 9;
            this.mark_car1.TabStop = false;
            this.mark_car1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(230, 80);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(40, 21);
            this.label25.TabIndex = 117;
            this.label25.Text = "الماركة";
            // 
            // motor_num1
            // 
            this.motor_num1.BackColor = System.Drawing.SystemColors.Window;
            this.motor_num1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motor_num1.Location = new System.Drawing.Point(7, 43);
            this.motor_num1.Name = "motor_num1";
            this.motor_num1.Size = new System.Drawing.Size(154, 32);
            this.motor_num1.TabIndex = 8;
            this.motor_num1.TabStop = false;
            this.motor_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(210, 40);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 21);
            this.label18.TabIndex = 9;
            this.label18.Text = "رقم الموتور";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(208, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(62, 21);
            this.label17.TabIndex = 8;
            this.label17.Text = "رقم السيارة";
            // 
            // car_num1
            // 
            this.car_num1.BackColor = System.Drawing.SystemColors.Window;
            this.car_num1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.car_num1.Location = new System.Drawing.Point(7, 3);
            this.car_num1.Name = "car_num1";
            this.car_num1.Size = new System.Drawing.Size(154, 32);
            this.car_num1.TabIndex = 7;
            this.car_num1.TabStop = false;
            this.car_num1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paid_price1
            // 
            this.paid_price1.BackColor = System.Drawing.SystemColors.Window;
            this.paid_price1.Location = new System.Drawing.Point(7, 203);
            this.paid_price1.Name = "paid_price1";
            this.paid_price1.Size = new System.Drawing.Size(154, 29);
            this.paid_price1.TabIndex = 119;
            this.paid_price1.TabStop = false;
            this.paid_price1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paid_price1.ThousandsSeparator = true;
            this.paid_price1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.paid_price1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 118;
            this.label1.Text = "مبلغ الشراء";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 11);
            this.panel1.TabIndex = 133;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Location = new System.Drawing.Point(161, 454);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 48);
            this.button2.TabIndex = 134;
            this.button2.TabStop = false;
            this.button2.Text = "بيع";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CarsEditDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 514);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.clear_all_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CarsEditDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تعديل معلومات سيارة";
            this.Load += new System.EventHandler(this.CarsEditDialog_Load);
            this.groupBox1.ResumeLayout(false);
            this.unregister.ResumeLayout(false);
            this.unregister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paid_price1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clear_all_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel unregister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox shaseh_num1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox model_num1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox mark_car1;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox motor_num1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox car_num1;
        private System.Windows.Forms.NumericUpDown paid_price1;
        private System.Windows.Forms.DateTimePicker from;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}