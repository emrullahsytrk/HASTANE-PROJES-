using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Net;

namespace HASTANE_PROJESİ
{
    public partial class HastaGiris : Form
    {
        public HastaGiris()
        {
            InitializeComponent();
        }

        private void LnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayıt uyekayıt = new HastaKayıt(); // HastaKayıt sayfasını çağırır
            uyekayıt.Show(); //uyekayıt sayfasını gösterir
            this.Hide(); // önceki formu gizler

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string m = GenerateSHA512String(TxtSifre.Text);

            SqlCommand komut = new SqlCommand("Select *From Tbl_Hastalar Where HastaTC=@p1 and HastaSifre=@p2", bgl.baglanti()); // hasta sql de p1 ve p2 ye kaydedilen değerleri doğru ise giriş yapar
            komut.Parameters.AddWithValue("@p1", MskTC.Text);  //parametreleri tanımlar
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);  // parametreleri tanımlar
            SqlDataReader dr = komut.ExecuteReader(); // komuttan  gelen verileri okur
            if(dr.Read())
            { 
            HastaDetay hastadetay = new HastaDetay(); // HastaDetay sayfasını çağırır
            hastadetay.tc = MskTC.Text; // msk girelen TC yi tc değişkenine atar
            hastadetay.Show(); // hastadetay sayfasını gösterir
            this.Hide();  // önceki formu gizler
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti();
        }

        public static string GenerateSHA512String(string inputString)
        {
            SHA512 sha512 = SHA512Managed.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(inputString);
            byte[] hash = sha512.ComputeHash(bytes);
            return GetStringFromHash(hash);

        }

        private static string GetStringFromHash(byte[] hash)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                result.Append(hash[i].ToString("X2"));
            }
            return result.ToString();
        }


        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            Girisler girisler = new Girisler(); // Girisler sayfasını çağırır
            girisler.Show(); //girisler sayfasını gösterir
            this.Hide(); // önceki formu gizler
       
        }
    }
}
