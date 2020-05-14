namespace HASTANE_PROJESİ
{
    partial class DoktorGiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnGiris = new System.Windows.Forms.Button();
            this.BtnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "ŞİFRE:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(194, 153);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(135, 27);
            this.TxtSifre.TabIndex = 11;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 44);
            this.label1.TabIndex = 9;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ";
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(193, 111);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(136, 27);
            this.MskTC.TabIndex = 8;
            // 
            // BtnGiris
            // 
            this.BtnGiris.Location = new System.Drawing.Point(193, 196);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(136, 44);
            this.BtnGiris.TabIndex = 7;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // BtnGeriDon
            // 
            this.BtnGeriDon.Location = new System.Drawing.Point(193, 246);
            this.BtnGeriDon.Name = "BtnGeriDon";
            this.BtnGeriDon.Size = new System.Drawing.Size(134, 44);
            this.BtnGeriDon.TabIndex = 13;
            this.BtnGeriDon.Text = "GERİ DÖN";
            this.BtnGeriDon.UseVisualStyleBackColor = true;
            this.BtnGeriDon.Click += new System.EventHandler(this.BtnGeriDon_Click);
            // 
            // DoktorGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(392, 318);
            this.Controls.Add(this.BtnGeriDon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.Name = "DoktorGiris";
            this.Text = "DoktorGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.Button BtnGeriDon;
    }
}