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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddLawSuitButton = new System.Windows.Forms.Button();
            this.lawSuitsGrid = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.caseNumberComboBox = new System.Windows.Forms.ComboBox();
            this.id_search = new System.Windows.Forms.NumericUpDown();
            this.name_search = new System.Windows.Forms.ComboBox();
            this.name_radio = new System.Windows.Forms.RadioButton();
            this.caseNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.id_radio = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lawSuitsGrid)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.id_search)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.AddLawSuitButton);
            this.groupBox2.Controls.Add(this.lawSuitsGrid);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 13F);
            this.groupBox2.Location = new System.Drawing.Point(4, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(1459, 917);
            this.groupBox2.TabIndex = 134;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفواتير";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AddLawSuitButton
            // 
            this.AddLawSuitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddLawSuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.AddLawSuitButton.FlatAppearance.BorderSize = 0;
            this.AddLawSuitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLawSuitButton.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.AddLawSuitButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.AddLawSuitButton.Location = new System.Drawing.Point(23, 83);
            this.AddLawSuitButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddLawSuitButton.Name = "AddLawSuitButton";
            this.AddLawSuitButton.Size = new System.Drawing.Size(179, 58);
            this.AddLawSuitButton.TabIndex = 141;
            this.AddLawSuitButton.TabStop = false;
            this.AddLawSuitButton.Text = "إضافة شكوى";
            this.AddLawSuitButton.UseVisualStyleBackColor = false;
            this.AddLawSuitButton.Click += new System.EventHandler(this.AddLawSuitButtonClick);
            // 
            // lawSuitsGrid
            // 
            this.lawSuitsGrid.AllowUserToAddRows = false;
            this.lawSuitsGrid.AllowUserToDeleteRows = false;
            this.lawSuitsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lawSuitsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lawSuitsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 13F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lawSuitsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.lawSuitsGrid.Location = new System.Drawing.Point(29, 205);
            this.lawSuitsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.lawSuitsGrid.MultiSelect = false;
            this.lawSuitsGrid.Name = "lawSuitsGrid";
            this.lawSuitsGrid.ReadOnly = true;
            this.lawSuitsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lawSuitsGrid.RowHeadersVisible = false;
            this.lawSuitsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lawSuitsGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.lawSuitsGrid.RowTemplate.Height = 30;
            this.lawSuitsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lawSuitsGrid.Size = new System.Drawing.Size(1409, 730);
            this.lawSuitsGrid.TabIndex = 131;
            this.lawSuitsGrid.TabStop = false;
            this.lawSuitsGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.LawSuitsGridDoubleClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.caseNumberComboBox);
            this.groupBox5.Controls.Add(this.id_search);
            this.groupBox5.Controls.Add(this.name_search);
            this.groupBox5.Controls.Add(this.name_radio);
            this.groupBox5.Controls.Add(this.caseNumberRadioButton);
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.id_radio);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.search);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.groupBox5.Location = new System.Drawing.Point(683, 33);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox5.Size = new System.Drawing.Size(749, 123);
            this.groupBox5.TabIndex = 130;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "طريقة البحث";
            // 
            // caseNumberComboBox
            // 
            this.caseNumberComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.caseNumberComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.caseNumberComboBox.Font = new System.Drawing.Font("Tahoma", 13F);
            this.caseNumberComboBox.FormattingEnabled = true;
            this.caseNumberComboBox.Location = new System.Drawing.Point(444, 73);
            this.caseNumberComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.caseNumberComboBox.Name = "caseNumberComboBox";
            this.caseNumberComboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.caseNumberComboBox.Size = new System.Drawing.Size(297, 35);
            this.caseNumberComboBox.Sorted = true;
            this.caseNumberComboBox.TabIndex = 144;
            this.caseNumberComboBox.Visible = false;
            // 
            // id_search
            // 
            this.id_search.BackColor = System.Drawing.SystemColors.Window;
            this.id_search.Location = new System.Drawing.Point(478, 74);
            this.id_search.Margin = new System.Windows.Forms.Padding(4);
            this.id_search.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.id_search.Name = "id_search";
            this.id_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.id_search.Size = new System.Drawing.Size(255, 24);
            this.id_search.TabIndex = 128;
            this.id_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id_search.Visible = false;
            this.id_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_search_KeyDown);
            this.id_search.MouseClick += new System.Windows.Forms.MouseEventHandler(this.id_search_MouseClick);
            // 
            // name_search
            // 
            this.name_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.name_search.Font = new System.Drawing.Font("Tahoma", 13F);
            this.name_search.FormattingEnabled = true;
            this.name_search.Location = new System.Drawing.Point(444, 73);
            this.name_search.Margin = new System.Windows.Forms.Padding(4);
            this.name_search.Name = "name_search";
            this.name_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.name_search.Size = new System.Drawing.Size(297, 35);
            this.name_search.Sorted = true;
            this.name_search.TabIndex = 143;
            this.name_search.Visible = false;
            this.name_search.SelectedIndexChanged += new System.EventHandler(this.name_search_SelectedIndexChanged);
            this.name_search.TextChanged += new System.EventHandler(this.name_search_TextChanged);
            // 
            // name_radio
            // 
            this.name_radio.AutoSize = true;
            this.name_radio.Location = new System.Drawing.Point(565, 33);
            this.name_radio.Margin = new System.Windows.Forms.Padding(4);
            this.name_radio.Name = "name_radio";
            this.name_radio.Size = new System.Drawing.Size(65, 21);
            this.name_radio.TabIndex = 123;
            this.name_radio.Text = "الأسم";
            this.name_radio.UseVisualStyleBackColor = true;
            this.name_radio.CheckedChanged += new System.EventHandler(this.name_radio_CheckedChanged);
            // 
            // caseNumberRadioButton
            // 
            this.caseNumberRadioButton.AutoSize = true;
            this.caseNumberRadioButton.Location = new System.Drawing.Point(442, 33);
            this.caseNumberRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.caseNumberRadioButton.Name = "caseNumberRadioButton";
            this.caseNumberRadioButton.Size = new System.Drawing.Size(92, 21);
            this.caseNumberRadioButton.TabIndex = 124;
            this.caseNumberRadioButton.Text = "رقم القضية";
            this.caseNumberRadioButton.UseVisualStyleBackColor = true;
            this.caseNumberRadioButton.CheckedChanged += new System.EventHandler(this.CaseNumebrRadioCheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(217, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 58);
            this.button1.TabIndex = 141;
            this.button1.TabStop = false;
            this.button1.Text = "الكل";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SearchAll_Click);
            // 
            // id_radio
            // 
            this.id_radio.AutoSize = true;
            this.id_radio.Location = new System.Drawing.Point(639, 33);
            this.id_radio.Margin = new System.Windows.Forms.Padding(4);
            this.id_radio.Name = "id_radio";
            this.id_radio.Size = new System.Drawing.Size(94, 21);
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
            this.button3.Location = new System.Drawing.Point(8, 50);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(179, 58);
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
            this.search.Location = new System.Drawing.Point(328, 50);
            this.search.Margin = new System.Windows.Forms.Padding(4);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 58);
            this.search.TabIndex = 127;
            this.search.TabStop = false;
            this.search.Text = "بحث";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.SearchClick);
            // 
            // ViewLawSuitsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ViewLawSuitsControl";
            this.Size = new System.Drawing.Size(1467, 935);
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
        private System.Windows.Forms.RadioButton caseNumberRadioButton;
        private System.Windows.Forms.NumericUpDown id_search;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton id_radio;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button search;
        public System.Windows.Forms.Button AddLawSuitButton;
        private System.Windows.Forms.ComboBox caseNumberComboBox;
    }
}
