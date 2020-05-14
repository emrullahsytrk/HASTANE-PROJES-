namespace HASTANE_PROJESİ
{
    partial class HastaGiris
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
            this.BtnGiris = new System.Windows.Forms.Button();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.BtnGeriDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGiris
            // 
            this.BtnGiris.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.BtnGiris.Location = new System.Drawing.Point(217, 205);
            this.BtnGiris.Name = "BtnGiris";
            this.BtnGiris.Size = new System.Drawing.Size(136, 44);
            this.BtnGiris.TabIndex = 0;
            this.BtnGiris.Text = "GİRİŞ";
            this.BtnGiris.UseVisualStyleBackColor = true;
            this.BtnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // MskTC
            // 
            this.MskTC.Location = new System.Drawing.Point(217, 120);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(136, 27);
            this.MskTC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.Location = new System.Drawing.Point(67, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "HASTA GİRİŞ PANELİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 123);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(140, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "TC KİMLİK NO:";
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(218, 162);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(135, 27);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(150, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "ŞİFRE:";
            // 
            // LnkUyeOl
            // 
            this.LnkUyeOl.AutoSize = true;
            this.LnkUyeOl.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold);
            this.LnkUyeOl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LnkUyeOl.Location = new System.Drawing.Point(102, 214);
            this.LnkUyeOl.Name = "LnkUyeOl";
            this.LnkUyeOl.Size = new System.Drawing.Size(109, 29);
            this.LnkUyeOl.TabIndex = 6;
            this.LnkUyeOl.TabStop = true;
            this.LnkUyeOl.Text = "ÜYE OL";
            this.LnkUyeOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkUyeOl_LinkClicked);
            // 
            // BtnGeriDon
            // 
            this.BtnGeriDon.Font = new System.Drawing.Font("Verdana", 13F, System.Drawing.FontStyle.Bold);
            this.BtnGeriDon.Location = new System.Drawing.Point(218, 255);
            this.BtnGeriDon.Name = "BtnGeriDon";
            this.BtnGeriDon.Size = new System.Drawing.Size(134, 44);
            this.BtnGeriDon.TabIndex = 7;
            this.BtnGeriDon.Text = "GERİ DÖN";
            this.BtnGeriDon.UseVisualStyleBackColor = true;
            this.BtnGeriDon.Click += new System.EventHandler(this.BtnGeriDon_Click);
            // 
            // HastaGiris
            // 
            this.AcceptButton = this.BtnGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(510, 408);
            this.Controls.Add(this.BtnGeriDon);
            this.Controls.Add(this.LnkUyeOl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MskTC);
            this.Controls.Add(this.BtnGiris);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.Name = "HastaGiris";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGiris;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LnkUyeOl;
        private System.Windows.Forms.Button BtnGeriDon;
    }
}