namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.label7 = new System.Windows.Forms.Label();
            this.progressBar5 = new System.Windows.Forms.ProgressBar();
            this.label8 = new System.Windows.Forms.Label();
            this.progressBar6 = new System.Windows.Forms.ProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.progressBar7 = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.progressBar8 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar9 = new System.Windows.Forms.ProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.progressBar10 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.progressBar11 = new System.Windows.Forms.ProgressBar();
            this.label14 = new System.Windows.Forms.Label();
            this.progressBar12 = new System.Windows.Forms.ProgressBar();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(350, 86);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(895, 55);
            this.progressBar2.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.progressBar3);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.progressBar4);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.progressBar5);
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Controls.Add(this.progressBar6);
            this.flowLayoutPanel2.Controls.Add(this.label9);
            this.flowLayoutPanel2.Controls.Add(this.progressBar7);
            this.flowLayoutPanel2.Controls.Add(this.label10);
            this.flowLayoutPanel2.Controls.Add(this.progressBar8);
            this.flowLayoutPanel2.Controls.Add(this.label11);
            this.flowLayoutPanel2.Controls.Add(this.progressBar9);
            this.flowLayoutPanel2.Controls.Add(this.label12);
            this.flowLayoutPanel2.Controls.Add(this.progressBar10);
            this.flowLayoutPanel2.Controls.Add(this.label13);
            this.flowLayoutPanel2.Controls.Add(this.progressBar11);
            this.flowLayoutPanel2.Controls.Add(this.label14);
            this.flowLayoutPanel2.Controls.Add(this.progressBar12);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(41, 210);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1235, 369);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Alt Sunucu 1 :";
            // 
            // progressBar3
            // 
            this.progressBar3.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar3.Location = new System.Drawing.Point(200, 3);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(999, 63);
            this.progressBar3.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Alt Sunucu 2: ";
            // 
            // progressBar4
            // 
            this.progressBar4.ForeColor = System.Drawing.Color.Red;
            this.progressBar4.Location = new System.Drawing.Point(200, 72);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(999, 65);
            this.progressBar4.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(3, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Alt Sunucu 3: ";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // progressBar5
            // 
            this.progressBar5.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar5.Location = new System.Drawing.Point(200, 143);
            this.progressBar5.Name = "progressBar5";
            this.progressBar5.Size = new System.Drawing.Size(999, 63);
            this.progressBar5.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(3, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 32);
            this.label8.TabIndex = 7;
            this.label8.Text = "Alt Sunucu 4: ";
            // 
            // progressBar6
            // 
            this.progressBar6.ForeColor = System.Drawing.Color.Red;
            this.progressBar6.Location = new System.Drawing.Point(200, 212);
            this.progressBar6.Name = "progressBar6";
            this.progressBar6.Size = new System.Drawing.Size(999, 65);
            this.progressBar6.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(3, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(191, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Alt Sunucu 5: ";
            // 
            // progressBar7
            // 
            this.progressBar7.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar7.Location = new System.Drawing.Point(200, 283);
            this.progressBar7.Name = "progressBar7";
            this.progressBar7.Size = new System.Drawing.Size(999, 63);
            this.progressBar7.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(3, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 32);
            this.label10.TabIndex = 11;
            this.label10.Text = "Alt Sunucu 6: ";
            // 
            // progressBar8
            // 
            this.progressBar8.ForeColor = System.Drawing.Color.Red;
            this.progressBar8.Location = new System.Drawing.Point(200, 352);
            this.progressBar8.Name = "progressBar8";
            this.progressBar8.Size = new System.Drawing.Size(999, 65);
            this.progressBar8.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(3, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 32);
            this.label11.TabIndex = 14;
            this.label11.Text = "Alt Sunucu 7: ";
            // 
            // progressBar9
            // 
            this.progressBar9.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar9.Location = new System.Drawing.Point(200, 423);
            this.progressBar9.Name = "progressBar9";
            this.progressBar9.Size = new System.Drawing.Size(999, 63);
            this.progressBar9.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 489);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(191, 32);
            this.label12.TabIndex = 15;
            this.label12.Text = "Alt Sunucu 8: ";
            // 
            // progressBar10
            // 
            this.progressBar10.ForeColor = System.Drawing.Color.Red;
            this.progressBar10.Location = new System.Drawing.Point(200, 492);
            this.progressBar10.Name = "progressBar10";
            this.progressBar10.Size = new System.Drawing.Size(999, 65);
            this.progressBar10.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(38, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ana Sunucu : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(38, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Alt Sunucular ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(41, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(166, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "BAŞLAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1079, 10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(166, 56);
            this.button4.TabIndex = 5;
            this.button4.Text = "DUR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(3, 560);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 32);
            this.label13.TabIndex = 18;
            this.label13.Text = "Alt Sunucu 9: ";
            // 
            // progressBar11
            // 
            this.progressBar11.ForeColor = System.Drawing.Color.HotPink;
            this.progressBar11.Location = new System.Drawing.Point(200, 563);
            this.progressBar11.Name = "progressBar11";
            this.progressBar11.Size = new System.Drawing.Size(999, 63);
            this.progressBar11.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(3, 629);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(197, 31);
            this.label14.TabIndex = 19;
            this.label14.Text = "Alt Sunucu 10: ";
            this.label14.Click += new System.EventHandler(this.Label14_Click);
            // 
            // progressBar12
            // 
            this.progressBar12.ForeColor = System.Drawing.Color.Red;
            this.progressBar12.Location = new System.Drawing.Point(206, 632);
            this.progressBar12.Name = "progressBar12";
            this.progressBar12.Size = new System.Drawing.Size(999, 65);
            this.progressBar12.TabIndex = 9;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1324, 598);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.progressBar2);
            this.Name = "Form1";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ProgressBar progressBar5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar progressBar6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ProgressBar progressBar7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar progressBar10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ProgressBar progressBar11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar12;
    }
}

