namespace Carproject.UI.UserControls
{
    partial class PartUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ccc = new System.Windows.Forms.GroupBox();
            this.contr_today = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contr_pinned = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.ccc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contr_today)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contr_pinned)).BeginInit();
            this.SuspendLayout();
            // 
            // ccc
            // 
            this.ccc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ccc.Controls.Add(this.contr_today);
            this.ccc.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ccc.Location = new System.Drawing.Point(3, 3);
            this.ccc.Name = "ccc";
            this.ccc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ccc.Size = new System.Drawing.Size(1086, 227);
            this.ccc.TabIndex = 7;
            this.ccc.TabStop = false;
            this.ccc.Text = "تنبيهات اليوم";
            this.ccc.Enter += new System.EventHandler(this.ccc_Enter);
            // 
            // contr_today
            // 
            this.contr_today.AllowUserToAddRows = false;
            this.contr_today.AllowUserToDeleteRows = false;
            this.contr_today.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contr_today.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.contr_today.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contr_today.Location = new System.Drawing.Point(13, 23);
            this.contr_today.Name = "contr_today";
            this.contr_today.ReadOnly = true;
            this.contr_today.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contr_today.RowHeadersVisible = false;
            this.contr_today.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_today.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.contr_today.RowTemplate.Height = 30;
            this.contr_today.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contr_today.Size = new System.Drawing.Size(1052, 185);
            this.contr_today.TabIndex = 117;
            this.contr_today.TabStop = false;
            this.contr_today.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contr_today_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.contr_pinned);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(3, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1086, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنبيهات معلقة";
            // 
            // contr_pinned
            // 
            this.contr_pinned.AllowUserToAddRows = false;
            this.contr_pinned.AllowUserToDeleteRows = false;
            this.contr_pinned.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contr_pinned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.contr_pinned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contr_pinned.Location = new System.Drawing.Point(13, 20);
            this.contr_pinned.Name = "contr_pinned";
            this.contr_pinned.ReadOnly = true;
            this.contr_pinned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.contr_pinned.RowHeadersVisible = false;
            this.contr_pinned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.contr_pinned.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.contr_pinned.RowTemplate.Height = 30;
            this.contr_pinned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.contr_pinned.Size = new System.Drawing.Size(1052, 228);
            this.contr_pinned.TabIndex = 117;
            this.contr_pinned.TabStop = false;
            this.contr_pinned.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contr_pinned_CellDoubleClick);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(40)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.button1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Location = new System.Drawing.Point(390, 477);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 36);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "إدارة المساهمات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.button3.Location = new System.Drawing.Point(575, 476);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 36);
            this.button3.TabIndex = 11;
            this.button3.TabStop = false;
            this.button3.Text = "أضافة مساهمة";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PartUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ccc);
            this.Name = "PartUI";
            this.Size = new System.Drawing.Size(1100, 525);
            this.Load += new System.EventHandler(this.PartUI_Load);
            this.ccc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contr_today)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contr_pinned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView contr_today;
        public System.Windows.Forms.DataGridView contr_pinned;
        public System.Windows.Forms.GroupBox ccc;
        public System.Windows.Forms.GroupBox groupBox1;
    }
}
