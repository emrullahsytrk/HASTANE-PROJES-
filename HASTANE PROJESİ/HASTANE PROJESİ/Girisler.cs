using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HASTANE_PROJESİ
{
    public partial class Girisler : Form
    {
        public Girisler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiris hastagiris = new HastaGiris();
            hastagiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGiris doktorgiris = new DoktorGiris();
            doktorgiris.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sekreter sekreter = new Sekreter();
            sekreter.Show();
            this.Hide();
        }
    }
}
