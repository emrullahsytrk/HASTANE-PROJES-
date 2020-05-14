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
    public partial class DoktorGiris : Form
    {
        public DoktorGiris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            string m = GenerateSHA512String(TxtSifre.Text);

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar where DoktorTc=@p1 and DoktorSifre=@p2",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                DoktorDetay doktordetay = new DoktorDetay();
                doktordetay.TC = MskTC.Text;    
                doktordetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre","Bigi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            bgl.baglanti().Close();
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
            Girisler girisler = new Girisler();
            girisler.Show();
            this.Hide();
        }
    }
}
