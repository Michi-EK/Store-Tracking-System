namespace Store_Tracking_System
{
    partial class UrunAnasayfa
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(62, 182);
            button1.Name = "button1";
            button1.Size = new Size(134, 98);
            button1.TabIndex = 0;
            button1.Text = "ÜRÜN EKLE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(230, 182);
            button2.Name = "button2";
            button2.Size = new Size(134, 98);
            button2.TabIndex = 1;
            button2.Text = "ÜRÜN GÜNCELLE";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(398, 182);
            button3.Name = "button3";
            button3.Size = new Size(170, 98);
            button3.TabIndex = 2;
            button3.Text = "ÜRÜN LİSTELE-ARA";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(602, 182);
            button4.Name = "button4";
            button4.Size = new Size(216, 98);
            button4.TabIndex = 3;
            button4.Text = "ÜRÜN STOK GÜNCELLE";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(12, 438);
            button5.Name = "button5";
            button5.Size = new Size(98, 34);
            button5.TabIndex = 4;
            button5.Text = "GERİ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // UrunAnasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(890, 484);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(908, 531);
            MinimumSize = new Size(908, 531);
            Name = "UrunAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UrunAnasayfa";
            Load += UrunAnasayfa_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}