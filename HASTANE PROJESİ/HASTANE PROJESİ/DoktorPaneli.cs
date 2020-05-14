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
    public partial class DoktorPaneli : Form
    {
        public DoktorPaneli()
        {
            InitializeComponent();
        }

        private void BtnGeriDon_Click(object sender, EventArgs e)
        {
            SekreterDetay sekreterdetay = new SekreterDetay();
            sekreterdetay.Show();
            this.Hide();
        }
        
        private void DoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * From Tbl_Doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            SqlCommand komut2 = new SqlCommand("Select  PolikinlikAd From Tbl_Polikinlikler", bgl.baglanti());
            SqlDataReader dt = komut2.ExecuteReader();
            while (dt.Read())
            {
                CmbPolikinlik.Items.Add(dt[0]);
            }
            bgl.baglanti().Close();

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorPolikinlik,DoktorTC,DoktorSifre) values (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbPolikinlik.Text);
            komut.Parameters.AddWithValue("@d4", MskTC.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //herhangi bir hücreye tıklanınca verileri düzenleme ekranına aktarıyor
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbPolikinlik.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Delete  From Tbl_Doktorlar where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); 
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@d1,DoktorSoyad=@d2,DoktorPolikinlik=@d3,DoktorSifre=@d5 where DoktorTC=@d4", bgl.baglanti());
            komut2.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@d2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@d3", CmbPolikinlik.Text);
            komut2.Parameters.AddWithValue("@d4", MskTC.Text);
            komut2.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
