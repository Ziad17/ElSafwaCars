namespace Carproject
{
    partial class ContrbuiteAlerts
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
            this.gggg = new System.Windows.Forms.GroupBox();
            this.alerts_today = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.alerts_pinned = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gggg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alerts_today)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alerts_pinned)).BeginInit();
            this.SuspendLayout();
            // 
            // gggg
            // 
            this.gggg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gggg.Controls.Add(this.alerts_today);
            this.gggg.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gggg.Location = new System.Drawing.Point(112, 19);
            this.gggg.Name = "gggg";
            this.gggg.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gggg.Size = new System.Drawing.Size(914, 197);
            this.gggg.TabIndex = 7;
            this.gggg.TabStop = false;
            this.gggg.Text = "تنبيهات اليوم";
            // 
            // alerts_today
            // 
            this.alerts_today.AllowUserToAddRows = false;
            this.alerts_today.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alerts_today.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.alerts_today.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alerts_today.Location = new System.Drawing.Point(67, 31);
            this.alerts_today.Name = "alerts_today";
            this.alerts_today.ReadOnly = true;
            this.alerts_today.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alerts_today.RowHeadersVisible = false;
            this.alerts_today.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.alerts_today.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.alerts_today.RowTemplate.Height = 30;
            this.alerts_today.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alerts_today.Size = new System.Drawing.Size(791, 155);
            this.alerts_today.TabIndex = 116;
            this.alerts_today.TabStop = false;
            this.alerts_today.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alerts_today_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.alerts_pinned);
            this.groupBox1.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.Location = new System.Drawing.Point(112, 249);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(914, 197);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تنبيهات سابقة";
            // 
            // alerts_pinned
            // 
            this.alerts_pinned.AllowUserToAddRows = false;
            this.alerts_pinned.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.alerts_pinned.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.alerts_pinned.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.alerts_pinned.Location = new System.Drawing.Point(67, 31);
            this.alerts_pinned.Name = "alerts_pinned";
            this.alerts_pinned.ReadOnly = true;
            this.alerts_pinned.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.alerts_pinned.RowHeadersVisible = false;
            this.alerts_pinned.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.alerts_pinned.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.alerts_pinned.RowTemplate.Height = 30;
            this.alerts_pinned.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.alerts_pinned.Size = new System.Drawing.Size(791, 155);
            this.alerts_pinned.TabIndex = 116;
            this.alerts_pinned.TabStop = false;
            this.alerts_pinned.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.alerts_pinned_CellContentClick);
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
            this.button3.Location = new System.Drawing.Point(626, 463);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 41);
            this.button3.TabIndex = 13;
            this.button3.TabStop = false;
            this.button3.Text = "أضافة مساهمة";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            this.button1.Location = new System.Drawing.Point(398, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 41);
            this.button1.TabIndex = 12;
            this.button1.TabStop = false;
            this.button1.Text = "أدارة المساهمات";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ContrbuiteAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gggg);
            this.Name = "ContrbuiteAlerts";
            this.Size = new System.Drawing.Size(1100, 530);
            this.Load += new System.EventHandler(this.ContrbuiteAlerts_Load);
            this.gggg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alerts_today)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alerts_pinned)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gggg;
        private System.Windows.Forms.DataGridView alerts_today;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView alerts_pinned;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}
