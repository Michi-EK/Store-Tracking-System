namespace Store_Tracking_System
{
    partial class CariHesapBilgi
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
            dgvFaturalar = new DataGridView();
            label2 = new Label();
            txtSecilenFaturaNo = new TextBox();
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
            button1.Location = new Point(12, 476);
            button1.Name = "button1";
            button1.Size = new Size(96, 39);
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
            label1.Location = new Point(226, 27);
            label1.Name = "label1";
            label1.Size = new Size(420, 31);
            label1.TabIndex = 2;
            label1.Text = "FATURA ÖDEME - CARİ HESAP BİLGİSİ";
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
            dgvFaturalar.Location = new Point(102, 81);
            dgvFaturalar.Name = "dgvFaturalar";
            dgvFaturalar.ReadOnly = true;
            dgvFaturalar.RowHeadersWidth = 51;
            dgvFaturalar.RowTemplate.Height = 29;
            dgvFaturalar.Size = new Size(679, 251);
            dgvFaturalar.TabIndex = 3;
            dgvFaturalar.RowHeaderMouseClick += dgvFaturalar_RowHeaderMouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(141, 362);
            label2.Name = "label2";
            label2.Size = new Size(186, 23);
            label2.TabIndex = 4;
            label2.Text = "SEÇİLEN FATURA NO :";
            // 
            // txtSecilenFaturaNo
            // 
            txtSecilenFaturaNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtSecilenFaturaNo.Location = new Point(342, 359);
            txtSecilenFaturaNo.Name = "txtSecilenFaturaNo";
            txtSecilenFaturaNo.Size = new Size(196, 30);
            txtSecilenFaturaNo.TabIndex = 5;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(562, 359);
            button2.Name = "button2";
            button2.Size = new Size(105, 30);
            button2.TabIndex = 6;
            button2.Text = "ÖDENDİ";
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
            // CariHesapBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(871, 527);
            Controls.Add(button2);
            Controls.Add(txtSecilenFaturaNo);
            Controls.Add(label2);
            Controls.Add(dgvFaturalar);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(889, 574);
            MinimumSize = new Size(889, 574);
            Name = "CariHesapBilgi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CariHesapBilgi";
            Load += CariHesapBilgi_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFaturalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dgvFaturalar;
        private Label label2;
        private TextBox txtSecilenFaturaNo;
        private Button button2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column4;
    }
}