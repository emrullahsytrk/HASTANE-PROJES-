namespace HASTANE_PROJESİ
{
    partial class BilgileriDüzenle
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
            this.label7 = new System.Windows.Forms.Label();
            this.CmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.TxtSoyad = new System.Windows.Forms.TextBox();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.MskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnBilgiGüncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(17, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(481, 40);
            this.label7.TabIndex = 27;
            this.label7.Text = "HASTA BİLGİ GÜNCELLEME PANELİ";
            // 
            // CmbCinsiyet
            // 
            this.CmbCinsiyet.FormattingEnabled = true;
            this.CmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.CmbCinsiyet.Location = new System.Drawing.Point(167, 258);
            this.CmbCinsiyet.Name = "CmbCinsiyet";
            this.CmbCinsiyet.Size = new System.Drawing.Size(152, 26);
            this.CmbCinsiyet.TabIndex = 6;
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(167, 222);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(152, 27);
            this.TxtSifre.TabIndex = 5;
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(167, 116);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Size = new System.Drawing.Size(152, 27);
            this.TxtSoyad.TabIndex = 2;
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(167, 82);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(152, 27);
            this.TxtAd.TabIndex = 1;
            // 
            // MskTelefon
            // 
            this.MskTelefon.Location = new System.Drawing.Point(167, 186);
            this.MskTelefon.Mask = "(999) 000-0000";
            this.MskTelefon.Name = "MskTelefon";
            this.MskTelefon.Size = new System.Drawing.Size(152, 27);
            this.MskTelefon.TabIndex = 4;
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(167, 151);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(152, 27);
            this.MskTC.TabIndex = 3;
            // 
            // BtnBilgiGüncelle
            // 
            this.BtnBilgiGüncelle.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold);
            this.BtnBilgiGüncelle.Location = new System.Drawing.Point(167, 293);
            this.BtnBilgiGüncelle.Name = "BtnBilgiGüncelle";
            this.BtnBilgiGüncelle.Size = new System.Drawing.Size(152, 48);
            this.BtnBilgiGüncelle.TabIndex = 20;
            this.BtnBilgiGüncelle.Text = "GÜNCELLE";
            this.BtnBilgiGüncelle.UseVisualStyleBackColor = true;
            this.BtnBilgiGüncelle.Click += new System.EventHandler(this.BtnBilgiGüncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "CİNSİYET:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 18;
            this.label5.Text = "ŞİFRE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "TELEFON:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "TC KİMLİK NO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "SOYAD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD:";
            // 
            // BilgileriDüzenle
            // 
            this.AcceptButton = this.BtnBilgiGüncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(521, 382);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CmbCinsiyet);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.TxtSoyad);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.MskTelefon);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.BtnBilgiGüncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "BilgileriDüzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.BilgileriDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbCinsiyet;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.TextBox TxtSoyad;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.MaskedTextBox MskTelefon;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Button BtnBilgiGüncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}