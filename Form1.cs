using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DovizKurlari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public List<Doviz> Kurlar { get; set; }
        public List<Doviz> Kurlar2 { get; set; }
        private void btnKurlariCek_Click(object sender, EventArgs e)
        {
            Kurlar = new Doviz().Kurlar;
            Kurlar2 = new List<Doviz>();
            Kurlar2.AddRange(Kurlar);
            timer1.Interval = 1000;
            if (Kurlar.Count > 0)
            {
                cmbAlis.DisplayMember = "KurKodu";
                cmbAlis.ValueMember = "AlisKuru";
                cmbAlis.DataSource = Kurlar;

                cmbSatis.DisplayMember = "KurKodu";
                cmbSatis.ValueMember = "SatisKuru";
                cmbSatis.DataSource = Kurlar2;
            }
            timer1.Start();
        }
        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            Doviz seciliDoviz = Kurlar[sayac % Kurlar.Count];
            lblAlis.Text = $"{seciliDoviz.AlisKuru:c4}";
            lblSatis.Text = $"{seciliDoviz.SatisKuru:c4}";
            lblKurAdi.Text = $"{seciliDoviz.KurAdi} {seciliDoviz.KurKodu}";
            sayac++;
        }

        private void cmbAlis_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal girilenBirim = Convert.ToDecimal(cmbAlis.SelectedValue);
            decimal donusenBirim = Convert.ToDecimal(cmbSatis.SelectedValue);
            Doviz girilenDoviz = cmbAlis.SelectedItem as Doviz;
            Doviz donusenDoviz = cmbSatis.SelectedItem as Doviz;
            if (girilenDoviz.Adet == 1 )
            {
                try
                {
                    nSatis.Value = (girilenBirim / donusenBirim) * nAlis.Value;
                }
                catch { }
            }
            else if (girilenDoviz.Adet > 1)
            {
                try
                {
                    nSatis.Value = ((girilenBirim / girilenDoviz.Adet) / donusenBirim) * nAlis.Value;
                }
                catch { }
            }
            else if (donusenDoviz.Adet > 1)
            {
                try
                {
                    nSatis.Value = ((girilenBirim * donusenDoviz.Adet) / donusenBirim) * nAlis.Value;
                }
                catch { }
            }

        }
    }
}
