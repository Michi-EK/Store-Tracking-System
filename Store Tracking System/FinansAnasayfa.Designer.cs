namespace Store_Tracking_System
{
    partial class FinansAnasayfa
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(48, 165);
            button1.Name = "button1";
            button1.Size = new Size(174, 108);
            button1.TabIndex = 0;
            button1.Text = "CARİ HESAP İŞLEMLERİ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(312, 165);
            button2.Name = "button2";
            button2.Size = new Size(174, 108);
            button2.TabIndex = 1;
            button2.Text = "KAR/ZARAR İŞLEMLERİ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(566, 165);
            button3.Name = "button3";
            button3.Size = new Size(174, 108);
            button3.TabIndex = 2;
            button3.Text = "ÜRÜN MALİYET İŞLEMLERİ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 420);
            button4.Name = "button4";
            button4.Size = new Size(98, 38);
            button4.TabIndex = 3;
            button4.Text = "GERİ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FinansAnasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(791, 470);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximumSize = new Size(809, 517);
            MinimumSize = new Size(809, 517);
            Name = "FinansAnasayfa";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FinansAnasayfa";
            Load += FinansAnasayfa_Load;
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}