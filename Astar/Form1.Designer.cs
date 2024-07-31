namespace Astar
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kapat = new System.Windows.Forms.Button();
            this.cozum = new System.Windows.Forms.Button();
            this.yenioyun = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kacmatris = new System.Windows.Forms.ComboBox();
            this.sonuc = new System.Windows.Forms.TextBox();
            this.amac = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.kapat);
            this.panel1.Controls.Add(this.cozum);
            this.panel1.Controls.Add(this.yenioyun);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 85);
            this.panel1.TabIndex = 0;
            // 
            // kapat
            // 
            this.kapat.BackColor = System.Drawing.Color.LightGreen;
            this.kapat.Location = new System.Drawing.Point(364, 24);
            this.kapat.Name = "kapat";
            this.kapat.Size = new System.Drawing.Size(136, 40);
            this.kapat.TabIndex = 0;
            this.kapat.Text = "Çıkış";
            this.kapat.UseVisualStyleBackColor = false;
            this.kapat.Click += new System.EventHandler(this.kapat_Click);
            // 
            // cozum
            // 
            this.cozum.BackColor = System.Drawing.Color.LightGreen;
            this.cozum.Location = new System.Drawing.Point(210, 24);
            this.cozum.Name = "cozum";
            this.cozum.Size = new System.Drawing.Size(136, 40);
            this.cozum.TabIndex = 0;
            this.cozum.Text = "Çözüm";
            this.cozum.UseVisualStyleBackColor = false;
            this.cozum.Click += new System.EventHandler(this.cozum_Click);
            // 
            // yenioyun
            // 
            this.yenioyun.BackColor = System.Drawing.Color.LightGreen;
            this.yenioyun.Location = new System.Drawing.Point(56, 24);
            this.yenioyun.Name = "yenioyun";
            this.yenioyun.Size = new System.Drawing.Size(136, 40);
            this.yenioyun.TabIndex = 0;
            this.yenioyun.Text = "Yeniden Başla";
            this.yenioyun.UseVisualStyleBackColor = false;
            this.yenioyun.Click += new System.EventHandler(this.yenioyun_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.button9);
            this.panel2.Controls.Add(this.button8);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(27, 139);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 236);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.LightGreen;
            this.button3.Location = new System.Drawing.Point(231, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 44);
            this.button3.TabIndex = 0;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(127, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 44);
            this.button2.TabIndex = 0;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightGreen;
            this.button6.Location = new System.Drawing.Point(231, 98);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(89, 44);
            this.button6.TabIndex = 0;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightGreen;
            this.button5.Location = new System.Drawing.Point(127, 98);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 44);
            this.button5.TabIndex = 0;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.LightGreen;
            this.button9.Location = new System.Drawing.Point(231, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(89, 44);
            this.button9.TabIndex = 0;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.LightGreen;
            this.button8.Location = new System.Drawing.Point(127, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(89, 44);
            this.button8.TabIndex = 0;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LightGreen;
            this.button7.Location = new System.Drawing.Point(23, 148);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(89, 44);
            this.button7.TabIndex = 0;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightGreen;
            this.button4.Location = new System.Drawing.Point(23, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 44);
            this.button4.TabIndex = 0;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(23, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SeaGreen;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.kacmatris);
            this.panel3.Controls.Add(this.sonuc);
            this.panel3.Controls.Add(this.amac);
            this.panel3.Location = new System.Drawing.Point(407, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(178, 235);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(57, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sonuç";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Başlangıç durum";
            // 
            // kacmatris
            // 
            this.kacmatris.BackColor = System.Drawing.Color.LightGreen;
            this.kacmatris.FormattingEnabled = true;
            this.kacmatris.Items.AddRange(new object[] {
            "2*2",
            "3*3",
            "5*5"});
            this.kacmatris.Location = new System.Drawing.Point(13, 14);
            this.kacmatris.Name = "kacmatris";
            this.kacmatris.Size = new System.Drawing.Size(151, 24);
            this.kacmatris.TabIndex = 1;
            this.kacmatris.Text = "Oyun kaç matris";
            this.kacmatris.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // sonuc
            // 
            this.sonuc.BackColor = System.Drawing.Color.LightGreen;
            this.sonuc.Location = new System.Drawing.Point(13, 177);
            this.sonuc.Margin = new System.Windows.Forms.Padding(4);
            this.sonuc.Multiline = true;
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(151, 40);
            this.sonuc.TabIndex = 0;
            this.sonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sonuc.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // amac
            // 
            this.amac.BackColor = System.Drawing.Color.LightGreen;
            this.amac.Location = new System.Drawing.Point(13, 95);
            this.amac.Margin = new System.Windows.Forms.Padding(4);
            this.amac.Multiline = true;
            this.amac.Name = "amac";
            this.amac.Size = new System.Drawing.Size(151, 40);
            this.amac.TabIndex = 0;
            this.amac.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amac.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGreen;
            this.ClientSize = new System.Drawing.Size(616, 400);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button kapat;
        private System.Windows.Forms.Button cozum;
        private System.Windows.Forms.Button yenioyun;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox kacmatris;
        private System.Windows.Forms.TextBox amac;
        private System.Windows.Forms.TextBox sonuc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;

    }
}

