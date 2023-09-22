using Carproject.UI.UserControls;

namespace Carproject.UI.Forms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.mainUI1 = new MainUI();
            this.partui1 = new PartUI();
            this.printForm = new PrintForm();
            this.payinstall2 = new View_Bills();
            this.showcars1 = new Car_Management();
            this.userChangeUI1 = new UserChangeUI();
            this.bellUI1 = new BellUI();
            this.accUI1 = new AccUI();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.panel1.Controls.Add(this.button10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1100, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 760);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button10
            // 
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Enabled = false;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(16, 561);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(147, 55);
            this.button10.TabIndex = 10;
            this.button10.TabStop = false;
            this.button10.Text = "طباعة";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(6, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Smart team :01285620713";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(0, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 53);
            this.panel3.TabIndex = 8;
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Enabled = false;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(16, 510);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(147, 55);
            this.button9.TabIndex = 7;
            this.button9.TabStop = false;
            this.button9.Text = "تعديل المستخدم";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Enabled = false;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(16, 450);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(147, 55);
            this.button8.TabIndex = 6;
            this.button8.TabStop = false;
            this.button8.Text = "الأحصائيات";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Sidepanel.Location = new System.Drawing.Point(168, 152);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(12, 53);
            this.Sidepanel.TabIndex = 0;
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Enabled = false;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(16, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 55);
            this.button6.TabIndex = 1;
            this.button6.TabStop = false;
            this.button6.Text = "الفواتير";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(16, 330);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(147, 55);
            this.button5.TabIndex = 2;
            this.button5.TabStop = false;
            this.button5.Text = "المساهمات";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(16, 390);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(147, 55);
            this.button4.TabIndex = 3;
            this.button4.TabStop = false;
            this.button4.Text = "السيارات";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(16, 210);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 55);
            this.button3.TabIndex = 4;
            this.button3.TabStop = false;
            this.button3.Text = "انشاء وثيقة دفع";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arabic Typesetting", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(16, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(147, 55);
            this.button2.TabIndex = 5;
            this.button2.TabStop = false;
            this.button2.Text = "الرئيسية";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 15);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(287, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(507, 249);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.Location = new System.Drawing.Point(10, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 25);
            this.button1.TabIndex = 4;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button7.Location = new System.Drawing.Point(43, 18);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(25, 25);
            this.button7.TabIndex = 2;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // mainUI1
            // 
            this.mainUI1.Location = new System.Drawing.Point(0, 207);
            this.mainUI1.Name = "mainUI1";
            this.mainUI1.Size = new System.Drawing.Size(1100, 550);
            this.mainUI1.TabIndex = 3;
            this.mainUI1.Load += new System.EventHandler(this.mainUI1_Load);
            // 
            // partui1
            // 
            this.partui1.Location = new System.Drawing.Point(0, 207);
            this.partui1.Name = "partui1";
            this.partui1.Size = new System.Drawing.Size(1100, 550);
            this.partui1.TabIndex = 6;
            // 
            // printForm
            // 
            this.printForm.Location = new System.Drawing.Point(0, 207);
            this.printForm.Name = "printForm";
            this.printForm.Size = new System.Drawing.Size(1100, 550);
            this.printForm.TabIndex = 699;
            // 
            // payinstall2
            // 
            this.payinstall2.Location = new System.Drawing.Point(0, 207);
            this.payinstall2.Name = "payinstall2";
            this.payinstall2.Size = new System.Drawing.Size(1100, 525);
            this.payinstall2.TabIndex = 7;
            // 
            // showcars1
            // 
            this.showcars1.Location = new System.Drawing.Point(0, 207);
            this.showcars1.Name = "showcars1";
            this.showcars1.Size = new System.Drawing.Size(1100, 525);
            this.showcars1.TabIndex = 3;
            // 
            // userChangeUI1
            // 
            this.userChangeUI1.Location = new System.Drawing.Point(0, 207);
            this.userChangeUI1.Name = "userChangeUI1";
            this.userChangeUI1.Size = new System.Drawing.Size(1100, 542);
            this.userChangeUI1.TabIndex = 10;
            this.userChangeUI1.Load += new System.EventHandler(this.userChangeUI1_Load);
            // 
            // bellUI1
            // 
            this.bellUI1.BackColor = System.Drawing.SystemColors.Control;
            this.bellUI1.Location = new System.Drawing.Point(0, 207);
            this.bellUI1.Name = "bellUI1";
            this.bellUI1.Size = new System.Drawing.Size(1100, 525);
            this.bellUI1.TabIndex = 0;
            // 
            // accUI1
            // 
            this.accUI1.Location = new System.Drawing.Point(0, 207);
            this.accUI1.Name = "accUI1";
            this.accUI1.Size = new System.Drawing.Size(1100, 525);
            this.accUI1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainUI1);
            this.Controls.Add(this.partui1);
            this.Controls.Add(this.payinstall2);
            this.Controls.Add(this.showcars1);
            this.Controls.Add(this.printForm);
            this.Controls.Add(this.userChangeUI1);
            this.Controls.Add(this.bellUI1);
            this.Controls.Add(this.accUI1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ELbashaCars";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button7;
        
        public System.Windows.Forms.Button button6;
        public System.Windows.Forms.Button button5;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Panel Sidepanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.Button button8;
        public System.Windows.Forms.Button button9;
        private UserChangeUI userChangeUI1;
        public System.Windows.Forms.Panel panel3;
        public View_Bills payinstall2;
        private PartUI partui1;
        private MainUI mainUI1;
        private Car_Management showcars1;
        private AccUI accUI1;
        public BellUI bellUI1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button button10;
        public PrintForm printForm;
    }
}

