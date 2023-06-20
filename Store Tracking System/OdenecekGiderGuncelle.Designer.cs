namespace Store_Tracking_System
{
    partial class OdenecekGiderGuncelle
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
            dgvFaturalar = new DataGridView();
            label1 = new Label();
            txtFaturaNo = new TextBox();
            label6 = new Label();
            txtFiyat = new TextBox();
            txtOdenecekYer = new TextBox();
            txtIslemAd = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            button2 = new Button();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvFaturalar).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 397);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 0;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dgvFaturalar
            // 
            dgvFaturalar.AllowUserToAddRows = false;
            dgvFaturalar.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFaturalar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFaturalar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFaturalar.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column6, Column4 });
            dgvFaturalar.Location = new Point(12, 69);
            dgvFaturalar.Name = "dgvFaturalar";
            dgvFaturalar.ReadOnly = true;
            dgvFaturalar.RowHeadersWidth = 51;
            dgvFaturalar.RowTemplate.Height = 29;
            dgvFaturalar.Size = new Size(678, 251);
            dgvFaturalar.TabIndex = 1;
            dgvFaturalar.RowHeaderMouseClick += dgvFaturalar_RowHeaderMouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(191, 22);
            label1.Name = "label1";
            label1.Size = new Size(323, 31);
            label1.TabIndex = 2;
            label1.Text = "ÖDENECEK GİDER GÜNCELLE";
            // 
            // txtFaturaNo
            // 
            txtFaturaNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFaturaNo.Location = new Point(853, 214);
            txtFaturaNo.Name = "txtFaturaNo";
            txtFaturaNo.Size = new Size(218, 30);
            txtFaturaNo.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(732, 221);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 22;
            label6.Text = "FATURA NO :";
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFiyat.Location = new Point(852, 174);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(218, 30);
            txtFiyat.TabIndex = 20;
            // 
            // txtOdenecekYer
            // 
            txtOdenecekYer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtOdenecekYer.Location = new Point(852, 134);
            txtOdenecekYer.Name = "txtOdenecekYer";
            txtOdenecekYer.Size = new Size(218, 30);
            txtOdenecekYer.TabIndex = 19;
            // 
            // txtIslemAd
            // 
            txtIslemAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtIslemAd.Location = new Point(852, 94);
            txtIslemAd.Name = "txtIslemAd";
            txtIslemAd.Size = new Size(218, 30);
            txtIslemAd.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(783, 181);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 16;
            label3.Text = "FİYAT :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(699, 141);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 15;
            label2.Text = "ÖDENECEK YER : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(743, 101);
            label5.Name = "label5";
            label5.Size = new Size(104, 23);
            label5.TabIndex = 14;
            label5.Text = "İŞLEM ADI :";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(893, 273);
            button2.Name = "button2";
            button2.Size = new Size(122, 36);
            button2.TabIndex = 24;
            button2.Text = "GÜNCELLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "islemad";
            Column1.HeaderText = "İŞLEM ADI";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "odenecekyer";
            Column2.HeaderText = "ÖDENECEK YER";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "fiyat";
            Column3.HeaderText = "FİYAT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "tarih";
            Column6.HeaderText = "İŞLEM TARİHİ";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 125;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "faturano";
            Column4.HeaderText = "FATURA NO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // OdenecekGiderGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1095, 445);
            Controls.Add(button2);
            Controls.Add(txtFaturaNo);
            Controls.Add(label6);
            Controls.Add(txtFiyat);
            Controls.Add(txtOdenecekYer);
            Controls.Add(txtIslemAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(dgvFaturalar);
            Controls.Add(button1);
            Name = "OdenecekGiderGuncelle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdenecekGiderGuncelle";
            Load += OdenecekGiderGuncelle_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaturalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dgvFaturalar;
        private Label label1;
        private TextBox txtFaturaNo;
        private Label label6;
        private TextBox txtFiyat;
        private TextBox txtOdenecekYer;
        private TextBox txtIslemAd;
        private Label label3;
        private Label label2;
        private Label label5;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
    }
}