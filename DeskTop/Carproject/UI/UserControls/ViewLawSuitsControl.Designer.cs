namespace Carproject.UI.UserControls
{
    partial class ViewLawSuitsControl
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lawSuitsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.name_radio = new System.Windows.Forms.RadioButton();
            this.name_search = new System.Windows.Forms.ComboBox();
            this.date_radio = new System.Windows.Forms.RadioButton();
            this.id_search = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.id_radio = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.date_search = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lawSuitsGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lawSuitsGrid);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1094, 745);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفواتير";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lawSuitsGrid
            // 
            this.lawSuitsGrid.AllowUserToAddRows = false;
            this.lawSuitsGrid.AllowUserToDeleteRows = false;
            this.lawSuitsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 13F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lawSuitsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.lawSuitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 13F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lawSuitsGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.lawSuitsGrid.Location = new System.Drawing.Point(17, 133);
            this.lawSuitsGrid.MultiSelect = false;
            this.lawSuitsGrid.Name = "lawSuitsGrid";
            this.lawSuitsGrid.ReadOnly = true;
            this.lawSuitsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lawSuitsGrid.RowHeadersVisible = false;
            this.lawSuitsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lawSuitsGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.lawSuitsGrid.RowTemplate.Height = 30;
            this.lawSuitsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lawSuitsGrid.Size = new System.Drawing.Size(1057, 593);
            this.lawSuitsGrid.TabIndex = 131;
            this.lawSuitsGrid.TabStop = false;
            this.lawSuitsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_search_CellClick);
            this.lawSuitsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bill_search_CellContentClick);
            this.lawSuitsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lawSuitsGrid_CellDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.name_radio);
            this.groupBox5.Controls.Add(this.name_search);
            this.groupBox5.Controls.Add(this.date_radio);
            this.groupBox5.Controls.Add(this.id_search);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.id_radio);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.search);
            this.groupBox5.Controls.Add(this.date_search);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox5.Location = new System.Drawing.Point(512, 27);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(562, 100);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "طريقة البحث";
            // 
            // name_radio
            // 
            this.name_radio.AutoSize = true;
            this.name_radio.Location = new System.Drawing.Point(424, 27);
            this.name_radio.Name = "name_radio";
            this.name_radio.Size = new System.Drawing.Size(54, 17);
            this.name_radio.TabIndex = 123;
            this.name_radio.Text = "الأسم";
            this.name_radio.UseVisualStyleBackColor = true;
            this.name_radio.CheckedChanged += new System.EventHandler(this.name_radio_CheckedChanged);
            // 
            // name_search
            // 
            this.name_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name_search.Font = new System.Drawing.Font("Tahoma", 13F);
            this.name_search.FormattingEnabled = true;
            this.name_search.Location = new System.Drawing.Point(327, 60);
            this.name_search.Name = "name_search";
            this.name_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_search.Size = new System.Drawing.Size(224, 29);
            this.name_search.Sorted = true;
            this.name_search.TabIndex = 143;
            this.name_search.Visible = false;
            this.name_search.SelectedIndexChanged += new System.EventHandler(this.name_search_SelectedIndexChanged);
            this.name_search.TextChanged += new System.EventHandler(this.name_search_TextChanged);
            // 
            // date_radio
            // 
            this.date_radio.AutoSize = true;
            this.date_radio.Location = new System.Drawing.Point(344, 27);
            this.date_radio.Name = "date_radio";
            this.date_radio.Size = new System.Drawing.Size(81, 17);
            this.date_radio.TabIndex = 124;
            this.date_radio.Text = "تاريخ الانشاء";
            this.date_radio.UseVisualStyleBackColor = true;
            this.date_radio.CheckedChanged += new System.EventHandler(this.date_radio_CheckedChanged_1);
            // 
            // id_search
            // 
            this.id_search.BackColor = System.Drawing.SystemColors.Window;
            this.id_search.Location = new System.Drawing.Point(344, 69);
            this.id_search.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.id_search.Name = "id_search";
            this.id_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_search.Size = new System.Drawing.Size(191, 20);
            this.id_search.TabIndex = 128;
            this.id_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_search.Visible = false;
            this.id_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_search_KeyDown);
            this.id_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.id_search_MouseClick);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(163, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 47);
            this.button1.TabIndex = 141;
            this.button1.TabStop = false;
            this.button1.Text = "الكل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SearchAll_Click);
            // 
            // id_radio
            // 
            this.id_radio.AutoSize = true;
            this.id_radio.Location = new System.Drawing.Point(479, 27);
            this.id_radio.Name = "id_radio";
            this.id_radio.Size = new System.Drawing.Size(77, 17);
            this.id_radio.TabIndex = 125;
            this.id_radio.Text = "رقم الفاتورة";
            this.id_radio.UseVisualStyleBackColor = true;
            this.id_radio.CheckedChanged += new System.EventHandler(this.id_radio_CheckedChanged);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button3.Location = new System.Drawing.Point(6, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(134, 47);
            this.button3.TabIndex = 140;
            this.button3.TabStop = false;
            this.button3.Text = "تفريغ الجدول";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // search
            // 
            this.search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.search.FlatAppearance.BorderSize = 0;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.search.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.search.Location = new System.Drawing.Point(246, 41);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(67, 47);
            this.search.TabIndex = 127;
            this.search.TabStop = false;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.SearchClick);
            // 
            // date_search
            // 
            this.date_search.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.date_search.CalendarMonthBackground = System.Drawing.SystemColors.Control;
            this.date_search.Font = new System.Drawing.Font("Tahoma", 10F);
            this.date_search.Location = new System.Drawing.Point(334, 66);
            this.date_search.Name = "date_search";
            this.date_search.Size = new System.Drawing.Size(210, 24);
            this.date_search.TabIndex = 129;
            this.date_search.TabStop = false;
            this.date_search.Visible = false;
            this.date_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.date_search_KeyDown);
            // 
            // ViewLawSuitsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Name = "ViewLawSuitsControl";
            this.Size = new System.Drawing.Size(1100, 760);
            this.Load += new System.EventHandler(this.PayInstall_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lawSuitsGrid)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView lawSuitsGrid;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton name_radio;
        private System.Windows.Forms.ComboBox name_search;
        private System.Windows.Forms.RadioButton date_radio;
        private System.Windows.Forms.NumericUpDown id_search;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton id_radio;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button search;
        private System.Windows.Forms.DateTimePicker date_search;
    }
}
