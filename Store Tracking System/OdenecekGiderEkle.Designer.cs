namespace Store_Tracking_System
{
    partial class OdenecekGiderEkle
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtIslemAd = new TextBox();
            txtOdenecekYer = new TextBox();
            txtFiyat = new TextBox();
            label5 = new Label();
            button2 = new Button();
            label6 = new Label();
            txtFaturaNo = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 403);
            button1.Name = "button1";
            button1.Size = new Size(96, 35);
            button1.TabIndex = 6;
            button1.Text = "GERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(62, 119);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
            label1.TabIndex = 1;
            label1.Text = "İŞLEM ADI :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 162);
            label2.Name = "label2";
            label2.Size = new Size(148, 23);
            label2.TabIndex = 2;
            label2.Text = "ÖDENECEK YER : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 207);
            label3.Name = "label3";
            label3.Size = new Size(64, 23);
            label3.TabIndex = 3;
            label3.Text = "FİYAT :";
            label3.Click += label3_Click;
            // 
            // txtIslemAd
            // 
            txtIslemAd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtIslemAd.Location = new Point(172, 118);
            txtIslemAd.Name = "txtIslemAd";
            txtIslemAd.Size = new Size(218, 30);
            txtIslemAd.TabIndex = 0;
            // 
            // txtOdenecekYer
            // 
            txtOdenecekYer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtOdenecekYer.Location = new Point(172, 161);
            txtOdenecekYer.Name = "txtOdenecekYer";
            txtOdenecekYer.Size = new Size(218, 30);
            txtOdenecekYer.TabIndex = 1;
            // 
            // txtFiyat
            // 
            txtFiyat.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFiyat.Location = new Point(172, 204);
            txtFiyat.Name = "txtFiyat";
            txtFiyat.Size = new Size(218, 30);
            txtFiyat.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(129, 41);
            label5.Name = "label5";
            label5.Size = new Size(261, 31);
            label5.TabIndex = 9;
            label5.Text = "ÖDENECEK GİDER EKLE";
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(226, 334);
            button2.Name = "button2";
            button2.Size = new Size(97, 32);
            button2.TabIndex = 5;
            button2.Text = "EKLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(45, 243);
            label6.Name = "label6";
            label6.Size = new Size(115, 23);
            label6.TabIndex = 12;
            label6.Text = "FATURA NO :";
            // 
            // txtFaturaNo
            // 
            txtFaturaNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtFaturaNo.Location = new Point(172, 240);
            txtFaturaNo.Name = "txtFaturaNo";
            txtFaturaNo.Size = new Size(218, 30);
            txtFaturaNo.TabIndex = 4;
            // 
            // OdenecekGiderEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(442, 450);
            Controls.Add(txtFaturaNo);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(txtFiyat);
            Controls.Add(txtOdenecekYer);
            Controls.Add(txtIslemAd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximumSize = new Size(460, 497);
            MinimumSize = new Size(460, 497);
            Name = "OdenecekGiderEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OdenecekGiderEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtIslemAd;
        private TextBox txtOdenecekYer;
        private TextBox txtFiyat;
        private Label label5;
        private Button button2;
        private Label label6;
        private TextBox txtFaturaNo;
    }
}