namespace SDF1
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
            this.txtIsciKodu = new System.Windows.Forms.TextBox();
            this.txtIsciYas = new System.Windows.Forms.TextBox();
            this.txtIsciSoyad = new System.Windows.Forms.TextBox();
            this.txtIsciAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.addBtn = new System.Windows.Forms.Button();
            this.txtIsciKodu2 = new System.Windows.Forms.TextBox();
            this.txtMebleg = new System.Windows.Forms.TextBox();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.addBtn2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIsciKodu3 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIsciKodu
            // 
            this.txtIsciKodu.Location = new System.Drawing.Point(88, 33);
            this.txtIsciKodu.Name = "txtIsciKodu";
            this.txtIsciKodu.Size = new System.Drawing.Size(100, 22);
            this.txtIsciKodu.TabIndex = 0;
            this.txtIsciKodu.TextChanged += new System.EventHandler(this.txtIsciKodu_TextChanged);
            // 
            // txtIsciYas
            // 
            this.txtIsciYas.Location = new System.Drawing.Point(88, 224);
            this.txtIsciYas.Name = "txtIsciYas";
            this.txtIsciYas.Size = new System.Drawing.Size(100, 22);
            this.txtIsciYas.TabIndex = 1;
            this.txtIsciYas.TextChanged += new System.EventHandler(this.txtIsciYas_TextChanged);
            // 
            // txtIsciSoyad
            // 
            this.txtIsciSoyad.Location = new System.Drawing.Point(88, 159);
            this.txtIsciSoyad.Name = "txtIsciSoyad";
            this.txtIsciSoyad.Size = new System.Drawing.Size(100, 22);
            this.txtIsciSoyad.TabIndex = 2;
            this.txtIsciSoyad.TextChanged += new System.EventHandler(this.txtIsciSoyad_TextChanged);
            // 
            // txtIsciAd
            // 
            this.txtIsciAd.Location = new System.Drawing.Point(88, 91);
            this.txtIsciAd.Name = "txtIsciAd";
            this.txtIsciAd.Size = new System.Drawing.Size(100, 22);
            this.txtIsciAd.TabIndex = 3;
            this.txtIsciAd.TextChanged += new System.EventHandler(this.txtIsciAd_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "İşçi kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Yaşı:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(801, 453);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addBtn);
            this.tabPage1.Controls.Add(this.txtIsciKodu);
            this.tabPage1.Controls.Add(this.txtIsciSoyad);
            this.tabPage1.Controls.Add(this.txtIsciYas);
            this.tabPage1.Controls.Add(this.txtIsciAd);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "İşçi əlavə et";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.addBtn2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtPayment);
            this.tabPage2.Controls.Add(this.txtMebleg);
            this.tabPage2.Controls.Add(this.txtIsciKodu2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(793, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ödəniş yaz";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox2);
            this.tabPage3.Controls.Add(this.txtIsciKodu3);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Statistika";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(22, 298);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(106, 45);
            this.addBtn.TabIndex = 8;
            this.addBtn.Text = "İşçini əlavə et";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // txtIsciKodu2
            // 
            this.txtIsciKodu2.Location = new System.Drawing.Point(112, 53);
            this.txtIsciKodu2.Name = "txtIsciKodu2";
            this.txtIsciKodu2.Size = new System.Drawing.Size(100, 22);
            this.txtIsciKodu2.TabIndex = 1;
            this.txtIsciKodu2.TextChanged += new System.EventHandler(this.txtIsciKodu2_TextChanged);
            // 
            // txtMebleg
            // 
            this.txtMebleg.Location = new System.Drawing.Point(550, 59);
            this.txtMebleg.Name = "txtMebleg";
            this.txtMebleg.Size = new System.Drawing.Size(100, 22);
            this.txtMebleg.TabIndex = 2;
            this.txtMebleg.TextChanged += new System.EventHandler(this.txtMebleg_TextChanged);
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(335, 56);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 22);
            this.txtPayment.TabIndex = 3;
            this.txtPayment.TextChanged += new System.EventHandler(this.txtPayment_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "İşçi kodu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ödəniş adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(473, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Məbləğ:";
            // 
            // addBtn2
            // 
            this.addBtn2.Location = new System.Drawing.Point(679, 47);
            this.addBtn2.Name = "addBtn2";
            this.addBtn2.Size = new System.Drawing.Size(96, 47);
            this.addBtn2.TabIndex = 7;
            this.addBtn2.Text = "Ödəniş əlavə et:";
            this.addBtn2.UseVisualStyleBackColor = true;
            this.addBtn2.Click += new System.EventHandler(this.addBtn2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "İşçi kodu:";
            // 
            // txtIsciKodu3
            // 
            this.txtIsciKodu3.Location = new System.Drawing.Point(109, 37);
            this.txtIsciKodu3.Name = "txtIsciKodu3";
            this.txtIsciKodu3.Size = new System.Drawing.Size(100, 22);
            this.txtIsciKodu3.TabIndex = 1;
            this.txtIsciKodu3.TextChanged += new System.EventHandler(this.txtIsciKodu3_TextChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(23, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 276);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(43, 91);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(563, 260);
            this.listBox2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtIsciKodu;
        private System.Windows.Forms.TextBox txtIsciYas;
        private System.Windows.Forms.TextBox txtIsciSoyad;
        private System.Windows.Forms.TextBox txtIsciAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button addBtn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.TextBox txtMebleg;
        private System.Windows.Forms.TextBox txtIsciKodu2;
        private System.Windows.Forms.TextBox txtIsciKodu3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}

