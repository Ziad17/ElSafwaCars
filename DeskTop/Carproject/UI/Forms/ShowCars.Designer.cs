namespace Carproject.UI.Forms
{
    partial class ShowCars
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowCars));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.available = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.search_cb_available = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sss = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.search_cb_sold = new System.Windows.Forms.ComboBox();
            this.sold = new System.Windows.Forms.DataGridView();
            this.ffff = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.available)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sss.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sold)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(401, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // available
            // 
            this.available.AllowUserToAddRows = false;
            this.available.AllowUserToDeleteRows = false;
            this.available.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.available.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.available.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.available.Location = new System.Drawing.Point(6, 101);
            this.available.MultiSelect = false;
            this.available.Name = "available";
            this.available.ReadOnly = true;
            this.available.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.available.RowHeadersVisible = false;
            this.available.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.available.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.available.RowTemplate.Height = 30;
            this.available.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.available.Size = new System.Drawing.Size(752, 250);
            this.available.TabIndex = 117;
            this.available.TabStop = false;
            this.available.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_CellContentClick);
            this.available.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.available_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.available);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(768, 357);
            this.groupBox1.TabIndex = 119;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "المعرض";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.search_cb_available);
            this.groupBox3.Location = new System.Drawing.Point(12, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(441, 77);
            this.groupBox3.TabIndex = 129;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "بحث";
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
            this.button2.Location = new System.Drawing.Point(11, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 32);
            this.button2.TabIndex = 150;
            this.button2.TabStop = false;
            this.button2.Text = "بحث";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(268, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 27);
            this.label1.TabIndex = 149;
            this.label1.Text = "رقم السيارة";
            // 
            // search_cb_available
            // 
            this.search_cb_available.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_cb_available.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.search_cb_available.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_cb_available.FormattingEnabled = true;
            this.search_cb_available.Location = new System.Drawing.Point(130, 27);
            this.search_cb_available.Name = "search_cb_available";
            this.search_cb_available.Size = new System.Drawing.Size(138, 32);
            this.search_cb_available.Sorted = true;
            this.search_cb_available.TabIndex = 148;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.sss);
            this.groupBox2.Controls.Add(this.sold);
            this.groupBox2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(768, 347);
            this.groupBox2.TabIndex = 120;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المباعة";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // sss
            // 
            this.sss.Controls.Add(this.button1);
            this.sss.Controls.Add(this.label7);
            this.sss.Controls.Add(this.search_cb_sold);
            this.sss.Location = new System.Drawing.Point(6, 19);
            this.sss.Name = "sss";
            this.sss.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sss.Size = new System.Drawing.Size(441, 77);
            this.sss.TabIndex = 129;
            this.sss.TabStop = false;
            this.sss.Text = "بحث";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(17, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 150;
            this.button1.TabStop = false;
            this.button1.Text = "بحث";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Default;
            this.label7.Font = new System.Drawing.Font("Arabic Typesetting", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(274, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 27);
            this.label7.TabIndex = 149;
            this.label7.Text = "رقم السيارة";
            // 
            // search_cb_sold
            // 
            this.search_cb_sold.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.search_cb_sold.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.search_cb_sold.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_cb_sold.FormattingEnabled = true;
            this.search_cb_sold.Location = new System.Drawing.Point(136, 27);
            this.search_cb_sold.Name = "search_cb_sold";
            this.search_cb_sold.Size = new System.Drawing.Size(138, 32);
            this.search_cb_sold.Sorted = true;
            this.search_cb_sold.TabIndex = 148;
            // 
            // sold
            // 
            this.sold.AllowUserToAddRows = false;
            this.sold.AllowUserToDeleteRows = false;
            this.sold.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.sold.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.sold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sold.Location = new System.Drawing.Point(6, 102);
            this.sold.MultiSelect = false;
            this.sold.Name = "sold";
            this.sold.ReadOnly = true;
            this.sold.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sold.RowHeadersVisible = false;
            this.sold.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sold.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.sold.RowTemplate.Height = 30;
            this.sold.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.sold.Size = new System.Drawing.Size(752, 235);
            this.sold.TabIndex = 117;
            this.sold.TabStop = false;
            this.sold.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sold_CellContentClick);
            this.sold.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sold_CellContentDoubleClick);
            // 
            // ffff
            // 
            this.ffff.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ffff.Dock = System.Windows.Forms.DockStyle.Top;
            this.ffff.Location = new System.Drawing.Point(0, 0);
            this.ffff.Name = "ffff";
            this.ffff.Size = new System.Drawing.Size(792, 15);
            this.ffff.TabIndex = 123;
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
            this.button3.Location = new System.Drawing.Point(550, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 32);
            this.button3.TabIndex = 151;
            this.button3.TabStop = false;
            this.button3.Text = "طباعة";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ShowCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 724);
            this.Controls.Add(this.ffff);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ShowCars";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "السيارات";
            this.Load += new System.EventHandler(this.ShowCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.available)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.sss.ResumeLayout(false);
            this.sss.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sold)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView available;
        public System.Windows.Forms.DataGridView sold;
        private System.Windows.Forms.Panel ffff;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox search_cb_available;
        private System.Windows.Forms.GroupBox sss;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.ComboBox search_cb_sold;
        private System.Windows.Forms.Button button3;
    }
}