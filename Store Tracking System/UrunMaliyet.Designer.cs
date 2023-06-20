namespace Store_Tracking_System
{
    partial class UrunMaliyet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            txtAlisFiyat = new TextBox();
            txtSatisFiyat = new TextBox();
            txtNetKar = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtUrunKod = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label8 = new Label();
            yuzde = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 429);
            button1.Name = "button1";
            button1.Size = new Size(91, 36);
            button1.TabIndex = 0;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(249, 28);
            label1.Name = "label1";
            label1.Size = new Size(301, 31);
            label1.TabIndex = 1;
            label1.Text = "ÜRÜN MALİYET İŞLEMLERİ";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(60, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(678, 210);
            dataGridView1.TabIndex = 2;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "urunad";
            Column1.HeaderText = "ÜRÜN ADI";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "urunkod";
            Column2.HeaderText = "ÜRÜN KODU";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "stok";
            Column3.HeaderText = "STOK";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "alisfiyat";
            Column4.HeaderText = "ALIŞ FİYATI";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "satisfiyat";
            Column5.HeaderText = "SATIŞ FİYATI";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // txtAlisFiyat
            // 
            txtAlisFiyat.Location = new Point(435, 321);
            txtAlisFiyat.Name = "txtAlisFiyat";
            txtAlisFiyat.Size = new Size(125, 27);
            txtAlisFiyat.TabIndex = 4;
            // 
            // txtSatisFiyat
            // 
            txtSatisFiyat.Location = new Point(249, 321);
            txtSatisFiyat.Name = "txtSatisFiyat";
            txtSatisFiyat.Size = new Size(125, 27);
            txtSatisFiyat.TabIndex = 5;
            // 
            // txtNetKar
            // 
            txtNetKar.Location = new Point(613, 321);
            txtNetKar.Name = "txtNetKar";
            txtNetKar.Size = new Size(125, 27);
            txtNetKar.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(450, 296);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 7;
            label3.Text = "ALIŞ FİYATI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(256, 296);
            label4.Name = "label4";
            label4.Size = new Size(110, 23);
            label4.TabIndex = 8;
            label4.Text = "SATIŞ FİYATI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(635, 296);
            label5.Name = "label5";
            label5.Size = new Size(81, 23);
            label5.TabIndex = 9;
            label5.Text = "NET KAR";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(60, 296);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 11;
            label6.Text = "ÜRÜN KODU";
            // 
            // txtUrunKod
            // 
            txtUrunKod.Location = new Point(54, 321);
            txtUrunKod.Name = "txtUrunKod";
            txtUrunKod.Size = new Size(125, 27);
            txtUrunKod.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(198, 322);
            label2.Name = "label2";
            label2.Size = new Size(29, 23);
            label2.TabIndex = 12;
            label2.Text = "->";
            label2.Click += label2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(398, 323);
            label7.Name = "label7";
            label7.Size = new Size(17, 23);
            label7.TabIndex = 13;
            label7.Text = "-";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(576, 322);
            label8.Name = "label8";
            label8.Size = new Size(22, 23);
            label8.TabIndex = 14;
            label8.Text = "=";
            label8.Click += label8_Click;
            // 
            // yuzde
            // 
            yuzde.AutoSize = true;
            yuzde.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            yuzde.Location = new Point(576, 370);
            yuzde.Name = "yuzde";
            yuzde.Size = new Size(123, 23);
            yuzde.TabIndex = 16;
            yuzde.Text = "KAR YÜZDESİ:";
            // 
            // UrunMaliyet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 477);
            Controls.Add(yuzde);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(txtUrunKod);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNetKar);
            Controls.Add(txtSatisFiyat);
            Controls.Add(txtAlisFiyat);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(818, 524);
            MinimumSize = new Size(818, 524);
            Name = "UrunMaliyet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunMaliyet";
            Load += UrunMaliyet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtAlisFiyat;
        private TextBox txtSatisFiyat;
        private TextBox txtNetKar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtUrunKod;
        private Label label2;
        private Label label7;
        private Label label8;
        private Label yuzde;
    }
}