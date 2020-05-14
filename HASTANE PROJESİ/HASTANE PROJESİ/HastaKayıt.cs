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

namespace HASTANE_PROJESİ
{
    public partial class HastaKayıt : Form
    {
        public HastaKayıt()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void BtnKayıt_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar(HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values(@p1,@p2,@p3,@p4,@p5,@p6)",bgl.baglanti()); // Sqlde Hastalar tablosuna verilen bilgileri kaydeder
            komut.Parameters.AddWithValue("@p1",TxtAd.Text); //parametreler tanımlandı
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text); //parametreler tanımlandı
            komut.Parameters.AddWithValue("@p3", MskTC.Text); //parametreler tanımlandı
            komut.Parameters.AddWithValue("@p4", MskTelefon.Text); //parametreler tanımlandı
            komut.Parameters.AddWithValue("@p5", TxtSifre.Text); //parametreler tanımlandı
            komut.Parameters.AddWithValue("@p6", CmbCinsiyet.Text); //parametreler tanımlandı
            komut.ExecuteNonQuery(); // insert çalıştırmak için kullanıldı
            bgl.baglanti().Close(); // baglantıyı kapatır
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz:"+ TxtSifre.Text,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information); //ekran mesaj verir
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris(); // hasta giriş sayfasını çağırır
            hastagiris.Show(); //hasta giriş sayfasını gösterir
            this.Hide();  //formu gizler
        }
    }
}
