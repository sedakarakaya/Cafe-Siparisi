using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeSiparis
{
    public partial class SiparisForm : Form
    {
        // int caySayisi = 0;   -- cayArtiLabel_Click teki ilk kod satırına gerek kalmıyor böylece. field(alan değişkeni) kullandık.
        public SiparisForm()
        {
            InitializeComponent();
        }

        private void cayArtiLabel_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(caySayisiLabel.Text);
            caySayisi++;
            caySayisiLabel.Text = Convert.ToString(caySayisi);
             
        }

        private void cayEksiLabel_Click(object sender, EventArgs e)
        {
            int caySayisi = Convert.ToInt32(caySayisiLabel.Text);
            if (caySayisi > 0)
            {
            caySayisi--;
            caySayisiLabel.Text = Convert.ToString(caySayisi);
            }
        }

        private void kahveArtiButton_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            kahveSayisi++;
            kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);
        }

        private void kahveEksiButton_Click(object sender, EventArgs e)
        {
            int kahveSayisi = Convert.ToInt32(kahveSayisiLabel.Text);
            if(kahveSayisi > 0 )
            {
            kahveSayisi--;
            kahveSayisiLabel.Text = Convert.ToString(kahveSayisi);
            }
        }

        private void kolaArtiButton_Click(object sender, EventArgs e)
        {
            int kolaSayisi = Convert.ToInt32(kolaSayisiLabel.Text);
            kolaSayisi++;
            kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);
        }

        private void kolaEksiButton_Click(object sender, EventArgs e)
        {
            int kolaSayisi = Convert.ToInt32(kolaSayisiLabel.Text);
            if(kolaSayisi > 0)
            {
            kolaSayisi--;
            kolaSayisiLabel.Text = Convert.ToString(kolaSayisi);
            }
        }

        private void sifirlaButton_Click(object sender, EventArgs e)
        {

            // caySayisi = 0;


            caySayisiLabel.Text = "0";
            kahveSayisiLabel.Text = "0";
            kolaSayisiLabel.Text = "0";
        }

        private void siparisiTamamlaButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SİPARİŞ ÖZETİ: "+caySayisiLabel.Text+" ÇAY," + kahveSayisiLabel.Text + " KAHVE," + kolaSayisiLabel.Text + " KOLA");
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
