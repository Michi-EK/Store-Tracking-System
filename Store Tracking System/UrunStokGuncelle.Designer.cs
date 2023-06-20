namespace Store_Tracking_System
{
    partial class UrunStokGuncelle
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
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            txtMevcutStok = new TextBox();
            txtYeniStok = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button2 = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvurunler).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 627);
            button1.Name = "button1";
            button1.Size = new Size(93, 41);
            button1.TabIndex = 0;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvurunler
            // 
            dgvurunler.AllowUserToAddRows = false;
            dgvurunler.AllowUserToDeleteRows = false;
            dgvurunler.BackgroundColor = SystemColors.ActiveBorder;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvurunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvurunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvurunler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6 });
            dgvurunler.Location = new Point(23, 85);
            dgvurunler.Name = "dgvurunler";
            dgvurunler.ReadOnly = true;
            dgvurunler.RowHeadersWidth = 51;
            dgvurunler.RowTemplate.Height = 29;
            dgvurunler.Size = new Size(553, 383);
            dgvurunler.TabIndex = 2;
            dgvurunler.CellContentClick += dgvurunler_CellContentClick;
            dgvurunler.RowHeaderMouseClick += dgvurunler_RowHeaderMouseClick;
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
            // Column6
            // 
            Column6.DataPropertyName = "tarih";
            Column6.HeaderText = "TARİH";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // txtMevcutStok
            // 
            txtMevcutStok.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtMevcutStok.Location = new Point(228, 494);
            txtMevcutStok.Name = "txtMevcutStok";
            txtMevcutStok.Size = new Size(162, 30);
            txtMevcutStok.TabIndex = 3;
            // 
            // txtYeniStok
            // 
            txtYeniStok.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtYeniStok.Location = new Point(228, 531);
            txtYeniStok.Name = "txtYeniStok";
            txtYeniStok.Size = new Size(162, 30);
            txtYeniStok.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(80, 494);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 5;
            label1.Text = "MEVCUT STOK : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(108, 531);
            label2.Name = "label2";
            label2.Size = new Size(105, 23);
            label2.TabIndex = 6;
            label2.Text = "YENİ STOK :";
            // 
            // button2
            // 
            button2.Location = new Point(409, 494);
            button2.Name = "button2";
            button2.Size = new Size(109, 67);
            button2.TabIndex = 7;
            button2.Text = "STOK GÜNCELLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(151, 34);
            label3.Name = "label3";
            label3.Size = new Size(297, 31);
            label3.TabIndex = 8;
            label3.Text = "ÜRÜN STOK GÜNCELLEME";
            // 
            // UrunStokGuncelle
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(591, 680);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtYeniStok);
            Controls.Add(txtMevcutStok);
            Controls.Add(dgvurunler);
            Controls.Add(button1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            MaximumSize = new Size(609, 727);
            MinimumSize = new Size(609, 727);
            Name = "UrunStokGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunStokGuncelle";
            Load += UrunStokGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvurunler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvurunler;
        private TextBox txtMevcutStok;
        private TextBox txtYeniStok;
        private Label label1;
        private Label label2;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private Label label3;
    }
}