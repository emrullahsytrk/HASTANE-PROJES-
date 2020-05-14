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
    public partial class HastaDetay : Form
    {
        public HastaDetay()
        {
            InitializeComponent();
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgileriDüzenle bilgidüzenle = new BilgileriDüzenle();
            bilgidüzenle.TCno = LblTC.Text;
            bilgidüzenle.Show();
        }

        private void BtnCıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        public string tc;

        sqlbaglantisi bgl = new sqlbaglantisi(); //sqlbaglantisi classında veri çekiyor

        private void HastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc; // HastaBilgisi kısmındaki TC yi yazar
           
            //Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text=dr[0]+" "+dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *From Tbl_Randevular where HastaTC="+tc,bgl.baglanti());
            da.Fill(dt); // data adapter içini table gelen değerle doldurur
            dataGridView1.DataSource = dt; //dataGridView1 veri kaynağı dt den gelen tablodur

            //Polikinlik Çekme
            SqlCommand komut2 = new SqlCommand("Select PolikinlikAd From Tbl_Polikinlikler",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CbmPolikinlik.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

        }

        private void CbmPolikinlik_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorPolikinlik=@p1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1",CbmPolikinlik.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                CmbDoktor.Items.Add(dr3[0] +" " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuPolikinlik='"+CbmPolikinlik.Text+ "'" + " and RandevuDoktor='" + CmbDoktor.Text + "' and RandevuDurum=0" ,bgl.baglanti()); // '"+CbmPolikinlik.Text+"'" tek tırnak ile sqlde gelen kelimeleri tek tırnakla yazar
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@p1,HastaSikayet=@p2 where Randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}