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
    public partial class DoktorDetay : Form
    {
        public DoktorDetay()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            DoktorBilgiDuzenle doktorbilgiduzenle = new DoktorBilgiDuzenle();
            doktorbilgiduzenle.TCNO = LblTC.Text;
            doktorbilgiduzenle.Show();
        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            Duyurular duyurular = new Duyurular();
            duyurular.Show();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            //AdSoyad çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar where DoktorTC=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where RandevuDoktor='"+LblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;


        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
