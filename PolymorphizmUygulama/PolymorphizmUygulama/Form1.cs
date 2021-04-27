using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolymorphizmUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkmek_Click(object sender, EventArgs e)
        {
            Sebet sb = new Sebet();           
            Ekmek ek = new Ekmek();
            ek.Gramaj = 100;
            ek.Fiyat = 0.7m;
            sb.UrunEkle(ek);

        }

        private void btnTekstil_Click(object sender, EventArgs e)
        {
            TekstilUrunu tks = new TekstilUrunu();
            tks.Adet = 5;
            tks.Fiyat = 10;
            tks.Renk = "Kirmizi";
            Sebet sb = new Sebet();
            sb.UrunEkle(tks);
        }

        private void btnElektronik_Click(object sender, EventArgs e)
        {
            Elektronik elk = new Elektronik();
            Sebet sb = new Sebet();
            elk.Fiyat = 150;
            sb.UrunEkle(elk);
        }
    }
}
