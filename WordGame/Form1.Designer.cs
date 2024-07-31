namespace WordGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Kelime = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            DogruCevapSayisi = new Label();
            YanlisCevapSayisi = new Label();
            label3 = new Label();
            SoruSayisi = new Label();
            RenkDegisimZamanlayicisi = new System.Windows.Forms.Timer(components);
            SoruDegistirmeZamanlayicisi = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // Kelime
            // 
            Kelime.AutoSize = true;
            Kelime.Font = new Font("Rubik", 27.7499962F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Kelime.Location = new Point(186, 111);
            Kelime.Name = "Kelime";
            Kelime.Size = new Size(116, 44);
            Kelime.TabIndex = 0;
            Kelime.Text = "label1";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Rubik", 14.9999981F);
            button1.Location = new Point(75, 168);
            button1.Name = "button1";
            button1.Size = new Size(158, 56);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 255);
            button2.Font = new Font("Rubik", 14.9999981F);
            button2.Location = new Point(267, 168);
            button2.Name = "button2";
            button2.Size = new Size(158, 56);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 255);
            button3.Font = new Font("Rubik", 14.9999981F);
            button3.Location = new Point(75, 267);
            button3.Name = "button3";
            button3.Size = new Size(158, 56);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 192, 255);
            button4.Font = new Font("Rubik", 14.9999981F);
            button4.Location = new Point(267, 267);
            button4.Name = "button4";
            button4.Size = new Size(158, 56);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rubik", 14.9999981F);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(195, 24);
            label1.TabIndex = 5;
            label1.Text = "Doğru Cevap Sayısı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rubik", 14.9999981F);
            label2.ForeColor = Color.FromArgb(64, 0, 64);
            label2.Location = new Point(12, 37);
            label2.Name = "label2";
            label2.Size = new Size(193, 24);
            label2.TabIndex = 6;
            label2.Text = "Yanlış Cevap Sayısı:";
            // 
            // DogruCevapSayisi
            // 
            DogruCevapSayisi.AutoSize = true;
            DogruCevapSayisi.Font = new Font("Rubik", 14.9999981F);
            DogruCevapSayisi.ForeColor = Color.FromArgb(64, 0, 64);
            DogruCevapSayisi.Location = new Point(213, 9);
            DogruCevapSayisi.Name = "DogruCevapSayisi";
            DogruCevapSayisi.Size = new Size(23, 24);
            DogruCevapSayisi.TabIndex = 7;
            DogruCevapSayisi.Text = "0";
            // 
            // YanlisCevapSayisi
            // 
            YanlisCevapSayisi.AutoSize = true;
            YanlisCevapSayisi.Font = new Font("Rubik", 14.9999981F);
            YanlisCevapSayisi.ForeColor = Color.FromArgb(64, 0, 64);
            YanlisCevapSayisi.Location = new Point(213, 37);
            YanlisCevapSayisi.Name = "YanlisCevapSayisi";
            YanlisCevapSayisi.Size = new Size(23, 24);
            YanlisCevapSayisi.TabIndex = 8;
            YanlisCevapSayisi.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rubik", 14.9999981F);
            label3.ForeColor = Color.FromArgb(64, 0, 64);
            label3.Location = new Point(365, 9);
            label3.Name = "label3";
            label3.Size = new Size(118, 24);
            label3.TabIndex = 9;
            label3.Text = "Soru Sayısı:";
            // 
            // SoruSayisi
            // 
            SoruSayisi.AutoSize = true;
            SoruSayisi.Font = new Font("Rubik", 14.9999981F);
            SoruSayisi.ForeColor = Color.FromArgb(64, 0, 64);
            SoruSayisi.Location = new Point(489, 9);
            SoruSayisi.Name = "SoruSayisi";
            SoruSayisi.Size = new Size(18, 24);
            SoruSayisi.TabIndex = 10;
            SoruSayisi.Text = "1";
            // 
            // RenkDegisimZamanlayicisi
            // 
            RenkDegisimZamanlayicisi.Tick += RenkDegisimZamanlayicisi_Tick;
            // 
            // SoruDegistirmeZamanlayicisi
            // 
            SoruDegistirmeZamanlayicisi.Tick += SoruDegistirmeZamanlayicisi_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(513, 380);
            Controls.Add(SoruSayisi);
            Controls.Add(label3);
            Controls.Add(YanlisCevapSayisi);
            Controls.Add(DogruCevapSayisi);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Kelime);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Kelime;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label DogruCevapSayisi;
        private Label YanlisCevapSayisi;
        private Label label3;
        private Label SoruSayisi;
        private System.Windows.Forms.Timer RenkDegisimZamanlayicisi;
        private System.Windows.Forms.Timer SoruDegistirmeZamanlayicisi;
    }
}
