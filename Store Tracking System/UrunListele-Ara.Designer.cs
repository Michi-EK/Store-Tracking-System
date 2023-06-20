namespace Store_Tracking_System
{
    partial class UrunListele_Ara
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
            dgvurunler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            txtAra = new TextBox();
            button2 = new Button();
            buttonListele = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvurunler).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 572);
            button1.Name = "button1";
            button1.Size = new Size(97, 36);
            button1.TabIndex = 0;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvurunler
            // 
            dgvurunler.AllowUserToAddRows = false;
            dgvurunler.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvurunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvurunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvurunler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column7, Column4, Column5, Column6, Column2, Column3 });
            dgvurunler.GridColor = SystemColors.ActiveBorder;
            dgvurunler.Location = new Point(25, 68);
            dgvurunler.Name = "dgvurunler";
            dgvurunler.ReadOnly = true;
            dgvurunler.RowHeadersWidth = 51;
            dgvurunler.RowTemplate.Height = 29;
            dgvurunler.Size = new Size(928, 383);
            dgvurunler.TabIndex = 1;
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
            // Column7
            // 
            Column7.DataPropertyName = "toptanciad";
            Column7.HeaderText = "TOPTANCI ADI";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "alisfiyat";
            Column4.HeaderText = "ÜRÜN ALIŞ FİYATI";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "satisfiyat";
            Column5.HeaderText = "ÜRÜN SATIŞ FİYATI";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "tarih";
            Column6.HeaderText = "TARİH";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
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
            // txtAra
            // 
            txtAra.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtAra.Location = new Point(314, 473);
            txtAra.Name = "txtAra";
            txtAra.Size = new Size(350, 30);
            txtAra.TabIndex = 2;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(437, 520);
            button2.Name = "button2";
            button2.Size = new Size(104, 34);
            button2.TabIndex = 3;
            button2.Text = "ARA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // buttonListele
            // 
            buttonListele.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonListele.Location = new Point(670, 473);
            buttonListele.Name = "buttonListele";
            buttonListele.Size = new Size(104, 30);
            buttonListele.TabIndex = 4;
            buttonListele.Text = "LİSTELE";
            buttonListele.UseVisualStyleBackColor = true;
            buttonListele.Click += buttonListele_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(371, 25);
            label1.Name = "label1";
            label1.Size = new Size(236, 31);
            label1.TabIndex = 5;
            label1.Text = "ÜRÜN LİSTELE - ARA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(205, 476);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 6;
            label2.Text = "ÜRÜN ADI :";
            // 
            // UrunListele_Ara
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(980, 620);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonListele);
            Controls.Add(button2);
            Controls.Add(txtAra);
            Controls.Add(dgvurunler);
            Controls.Add(button1);
            MaximumSize = new Size(998, 667);
            MinimumSize = new Size(998, 667);
            Name = "UrunListele_Ara";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunListele_Ara";
            Load += UrunListele_Ara_Load;
            ((System.ComponentModel.ISupportInitialize)dgvurunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvurunler;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private TextBox txtAra;
        private Button button2;
        private Button buttonListele;
        private Label label1;
        private Label label2;
    }
}